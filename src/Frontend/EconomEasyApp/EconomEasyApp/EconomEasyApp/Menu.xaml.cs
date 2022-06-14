using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EconomEasyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void VoltaPrimTela(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogada());
        }

        private void Button_DadosPerfil(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DadosPerfil());
        }

        private void Button_InfFin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InfoFinan());
        }

        private void Button_Config(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Config());
        }

        private void Button_PolPriv(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PoliticasPriv());
        }

        private void Button_Sair(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}