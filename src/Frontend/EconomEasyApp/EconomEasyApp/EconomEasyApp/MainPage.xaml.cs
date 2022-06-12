using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EconomEasyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            /*if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                DisplayAlert("Login efetuado", "Usuário identificado", "Ok");*/

                 Navigation.PushAsync(new TelaLogada());

           /* }
            else
            {
                DisplayAlert("Ocorreu um erro!", "Usuário não identificado", "Ok");
            }*/
        }

        private void Reconhecer_Tap(object sender, EventArgs e)
        {

        }
        /*public class Objeto
        {
            [JsonProperty("nome")]
            public string nome { get; set; }
            [JsonProperty("sobrenome")]
            public string sobrenome { get; set; }
            [JsonProperty("idade")]
            public int idade { get; set; }
            [JsonProperty("altura")]
            public float altura { get; set; }
        }


        async void Dados(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var resultados = await httpClient.GetStringAsync("http://132.1.3.1:3000/user");
            var resultadoFinal = JsonConvert.DeserializeObject<Objeto>(resultados);

            json.Text = resultados;
            userName.Text = resultadoFinal.nome;
            sureName.Text = resultadoFinal.sobrenome;
            userAge.Text = resultadoFinal.idade.ToString();
            userHeight.Text = resultadoFinal.altura.ToString();

        }*/

    }
}
