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
    public partial class MenuNavegacao : FlyoutPage
    {
        List<MenuItems> MenuItems;
        public MenuNavegacao()
        {
            InitializeComponent();
            MenuItems = new List<MenuItems>();
            MenuItems.Add(new MenuItems { NomeMenu = "Dados de Perfil"});
            MenuItems.Add(new MenuItems { NomeMenu = "Informações Financeiras"});
            MenuItems.Add(new MenuItems { NomeMenu = "Configurações"});
            MenuItems.Add(new MenuItems { NomeMenu = "Políticas e Privacidades"});
            MenuItems.Add(new MenuItems { NomeMenu = "Sair"});
            Detail = new NavigationPage(new TelaLogada());
        }

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;

                switch (item.NomeMenu)
                {
                    case "Dados de Perfil":
                        Detail = new NavigationPage(new DadosPerfil());
                        IsPresented = false; break;
                    case "Informações Financeiras":
                        Detail = new NavigationPage(new InfoFinan());
                        IsPresented = false; break;
                    case "Configurações":
                        Detail = new NavigationPage(new Config());
                        IsPresented = false; break;
                    case "Políticas e Privacidades":
                        Detail = new NavigationPage(new PoliticasPriv());
                        IsPresented = false; break;
                    case "Sair":
                        Detail = new NavigationPage(new MainPage());
                        IsPresented = false; break;
                }
            }
            catch
            {

            }
        }
    }
    public class MenuItems
    {
        public string NomeMenu { get; set; }
    }
}