using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EconomEasyApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TelaLogada());
            
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
