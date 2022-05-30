using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appEconomEasy.ListaMenu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appEconomEasy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        private ObservableCollection<ListaMenu> listavMenu;

        public Menu()
        {
            InitializeComponent();
            listavMenu = ListaMenu.GetListaMenu();
            lvItens.ItemSource = listavMenu;
        }

        private void selecaoItens (object sender, SelectedItemChangedEventArgs e)
        {
            var pagina = e.SelectedItem as ListaMenu;
            Detail = new modeloPagina(pagina);
            IsPresented = false;
        }


    }
}