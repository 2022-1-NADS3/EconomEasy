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
    public partial class Config : ContentPage
    {
        public Config()
        {
            InitializeComponent();
        }
        private void VoltaPrimTela(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogada());
        }
    }
}