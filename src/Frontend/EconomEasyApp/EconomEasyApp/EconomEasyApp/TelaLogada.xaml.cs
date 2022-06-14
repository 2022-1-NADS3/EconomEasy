using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.ChartEntry;

namespace EconomEasyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaLogada : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Label = "Casa",
                ValueLabel = "200",
            },
            new Entry(500)
            {
                Label = "Automóvel",
                ValueLabel = "500",
            },
            new Entry(100)
            {
                Label = "Entretenimento",
                ValueLabel = "100",
            }
        };
        public TelaLogada()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            Chart1.Chart = new RadialGaugeChart { Entries = entries};
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