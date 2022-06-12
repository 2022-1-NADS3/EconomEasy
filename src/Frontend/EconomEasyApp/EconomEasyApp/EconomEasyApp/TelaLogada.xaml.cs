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
    public partial class TelaLogada : ContentPage
    {
        public TelaLogada()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void AddAddInfFin(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddFin());
        }
        private void VoltaPrimTela(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogada());
        }
        private void Hamburguer(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Menu());
        }
    }
}