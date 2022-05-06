var express = require ("express");
var app = express();
var port = process.env.PORT || 3000; 
var hostname = "localhost";
//var nome = "Erika"; Ou após a barra do navegador incluir ?nome=onome
const json = '[{"nome":"Erika", "sobrenome":"Barros", "altura":1.55}, {"nome":"Willians", "sobrenome":"Frozen", "altura":1.90}]';
var objeto = JSON.parse(json);

//PORTA DE ACESSO PROCESS.ENV = N SABEMOS QUAL PORTA VAI ADOTAR  E NO LOCAL USAMOS || PARA DETERMINAL A PORTA 3000
app.get("/", function (req, res){
    req.query.nome;
    res.send("<h1>Olá: <h1>" + objeto[0].nome + " " + objeto[0].sobrenome + " " + objeto[0].altura + " e " + objeto[1].nome + " " + objeto[1].sobrenome + " " + objeto[1].altura);
    console.log("Passei aqui!");
});
//CHAMA O / E CONSEGUE COLETAR DADOS ATRAVÉS DO "REQ" E "RES"É A RESPOSTA.

app.listen(port, hostname, () =>{
    console.log("Servidor http://"+hostname+":"+[port]);
}
);

//LISTEN É UMA ESPÉCIE DE LOG PARA FICAR "ESCUTANDO" A FUNCAO ANTERIOR.

app.get("/paginainicial", function (req, res){
    res.send("Página inicial!");
    console.log("Passei aqui2!");
});

app.get("/user", function (req, res){
    res.send("Aqui seu usuário!");
    console.log("Passei aqui3!");
});
