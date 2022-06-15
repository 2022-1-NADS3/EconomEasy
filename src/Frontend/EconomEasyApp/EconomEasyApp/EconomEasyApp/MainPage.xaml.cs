using EconomEasyApp.Classes;
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

        void Button_LogIn(object sender, EventArgs e)
        {
            User user = new User(entryUsername.Text, entryPassword.Text);
            if(user.CheckInformation())
            {
                DisplayAlert("Log In", "Log In realizado!", "Entrar");
                Navigation.PushAsync(new TelaLogada());
            }
            else
            {
                DisplayAlert("Log In", "Usuário ou senha incorretos!", "Tentar Novamente");
            }
        }

        private static void Reconhecer_Tap(object sender, EventArgs e)
        {

        }
    }
}
