using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Teste_5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                DisplayAlert("Login efetuado", "Usuário identificado", "Ok");
            }
            else
            {
                DisplayAlert("Ocorreu um erro!", "Usuário não identificado", "Ok");
            }
        }

        private void Reconhecer_Tap(object sender, EventArgs e)
        {

        }
    }
}