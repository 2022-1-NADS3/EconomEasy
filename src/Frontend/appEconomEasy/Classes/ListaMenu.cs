using System;
using System.Collections.Generic;
using System.Text;

namespace appEconomEasy.Classes
{
    public class ListaMenu
    {
        public string nomeCampo { get; set; }

        public static ObservableCollection<ListaMenu> _listaMenu { get; set; }

        public static ObservableCollection<ListaMenu> GetListaMenu()
        {
            _listaMenu = new ObservableCollection<ListaMenu>();

            _listaMenu.Add(new ListaMenu() { nomeCampo = "Dados de Perfil" });
            _listaMenu.Add(new ListaMenu() { nomeCampo = "Informações Financeiras" });
            _listaMenu.Add(new ListaMenu() { nomeCampo = "Configurações" });
            _listaMenu.Add(new ListaMenu() { nomeCampo = "Políticas e Privacidade" });
            _listaMenu.Add(new ListaMenu() { nomeCampo = "Sair" });

            return _listaMenu;
        }

    }

    
}
