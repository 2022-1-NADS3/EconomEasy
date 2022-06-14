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
    public partial class AddFin : ContentPage
    {
        public AddFin()
        {
            InitializeComponent();
        }
        private void VoltaPrimTela(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogada());
        }
        async void Button_AddFin(object sender, EventArgs e)
        {
            await DisplayAlert("Informações registradas!", "Suas informações foram salvas." , "Confirmar");
        }
        private void CategDesp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = CategDesp.Items[CategDesp.SelectedIndex];
        }
        private void FormPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelecionado = FormPag.Items[FormPag.SelectedIndex];
        }
    }
}