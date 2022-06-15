const express = require('express')

const cors = require('cors');

const{Pool} = require('pg')

require('dotenv').config()

const PORT = process.env.PORT || 3333

const pool = new Pool({
    connectionString: process.env.POSTGRES_URL,
    ssl: {
        rejectUnauthorized: false
    }
 });

const app = express() 

app.use(express.json())

app.use(cors());

app.get('/', (req,res) => {console.log('olá mundo')})

app.get('/cadastrousuario', async (req,res) => {
    
    try {
        const { rows } = await pool.query('SELECT * FROM cadastrousuario')
        return res.status(200).send(rows)
    } catch(err) {
        return res.status(400).send(err)
    }
 })

 app.post('/session', async (req,res) =>{
    const {celular} = req.body
    let user =''
    try{
        user  = await pool.query('SELECT * FROM cadastrousuario WHERE celular = ($1)', [celular])
        if(!user.rows[0]){
            user = await pool.query('INSERT INTO cadastrousuario(celular) VALUES ($1) RETURNING*',[celular])

        }
        
        return res.status(200).send(user.rows)
    } catch(err) {
        return res.status(400).send(err)
    }

 })

 app.post('/cadastroconta/:usuario_id', async(req,res) => {
    const { description, done } = req.body
    const { usuario_id } = req.params
    try{
        const newcadastroconta = await pool.query('INSERT INTO cadastroconta (nomeConta, conta_done, usuario_id) VALUES ($1,$2,$3) RETURNING*', [description, done, usuario_id])
        return res.status(200).send(newcadastroconta.rows)
    } catch(err){
        return res.status(400).send(err)
    }
 })

app.get('/cadastroconta/:usuario_id', async (req,res) =>{
    const{usuario_id} = req.params
    try{
        const allcadastroconta = await pool.query('SELECT * FROM cadastroconta WHERE usuario_id = ($1)', [usuario_id])
        return res.status(200).send(allcadastroconta.rows)
    } catch(err){
        return res.status(400).send(err)
    }
})

/*app.put('/cadastroconta/:usuario_id/:conta_id', async (req,res) =>{
    const {conta_id} = req.params
    const data = req.body
    try{
        const updatedCadastroconta = await pool.query('UPDATE cadastroconta SET nomeConta = ($1), conta_done = ($2) WHERE conta_id($3) RETURNING *', 
        [data.description, data.done, conta_id])
        return res.status(200).send(updatedCadastroconta.rows)
    }
    catch(err){
        return res.status(400).send(err)
    }
} )*/

app.listen(PORT, () => console.log('Server runnig on port ${PORT}'))