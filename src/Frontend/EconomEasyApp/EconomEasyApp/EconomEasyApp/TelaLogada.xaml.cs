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
            new Entry(800)
            {
                Label = "Casa",
                ValueLabel = "800",
                Color = SKColor.Parse("#FFD700"),
                TextColor = SKColor.Parse("#FFD700"),
                ValueLabelColor = SKColor.Parse("#FFD700"),
            },
            new Entry(700)
            {
                Label = "Veículo",
                ValueLabel = "700",
                Color = SKColor.Parse("#0000FF"),
                TextColor = SKColor.Parse("#0000FF"),
                ValueLabelColor = SKColor.Parse("#0000FF"),
            },
            new Entry(200)
            {
                Label = "Entretenimento",
                ValueLabel = "200",
                Color = SKColor.Parse("#FF0000"),
                TextColor = SKColor.Parse("#FF0000"),
                ValueLabelColor = SKColor.Parse("#FF0000"),
            },
            new Entry(1200)
            {
                Label = "Educação",
                ValueLabel = "1200",
                Color = SKColor.Parse("#008000"),
                TextColor = SKColor.Parse("#008000"),
                ValueLabelColor = SKColor.Parse("#008000"),
            },
            new Entry(100)
            {
                Label = "Salário",
                ValueLabel = "-7000",
                Color = SKColor.Parse("#808080"),
                TextColor = SKColor.Parse("#808080"),
                ValueLabelColor = SKColor.Parse("#808080"),
            }
        };
        List<Entry> entries2 = new List<Entry>
        {
            new Entry(800)
            {
                Label = "Jan/22",
                ValueLabel = "800",
                Color = SKColor.Parse("#FFD700"),
                TextColor = SKColor.Parse("#FFD700"),
                ValueLabelColor = SKColor.Parse("#FFD700"),
            },
            new Entry(900)
            {
                Label = "Fev/22",
                ValueLabel = "900",
                Color = SKColor.Parse("#0000FF"),
                TextColor = SKColor.Parse("#0000FF"),
                ValueLabelColor = SKColor.Parse("#0000FF"),
            },
            new Entry(870)
            {
                Label = "Mar/22",
                ValueLabel = "870",
                Color = SKColor.Parse("#FF0000"),
                TextColor = SKColor.Parse("#FF0000"),
                ValueLabelColor = SKColor.Parse("#FF0000"),
            },
            new Entry(1200)
            {
                Label = "Abr/22",
                ValueLabel = "1200",
                Color = SKColor.Parse("#008000"),
                TextColor = SKColor.Parse("#008000"),
                ValueLabelColor = SKColor.Parse("#008000"),
            },
            new Entry(1000)
            {
                Label = "Mai/22",
                ValueLabel = "1000",
                Color = SKColor.Parse("#808080"),
                TextColor = SKColor.Parse("#808080"),
                ValueLabelColor = SKColor.Parse("#808080"),
            }
        };
        List<Entry> entries3 = new List<Entry>
        {
            new Entry(460)
            {
                Label = "Jan/22",
                ValueLabel = "460",
                Color = SKColor.Parse("#FFD700"),
                TextColor = SKColor.Parse("#FFD700"),
                ValueLabelColor = SKColor.Parse("#FFD700"),
            },
            new Entry(570)
            {
                Label = "Fev/22",
                ValueLabel = "570",
                Color = SKColor.Parse("#0000FF"),
                TextColor = SKColor.Parse("#0000FF"),
                ValueLabelColor = SKColor.Parse("#0000FF"),
            },
            new Entry(400)
            {
                Label = "Mar/22",
                ValueLabel = "400",
                Color = SKColor.Parse("#FF0000"),
                TextColor = SKColor.Parse("#FF0000"),
                ValueLabelColor = SKColor.Parse("#FF0000"),
            },
            new Entry(360)
            {
                Label = "Abr/22",
                ValueLabel = "360",
                Color = SKColor.Parse("#008000"),
                TextColor = SKColor.Parse("#008000"),
                ValueLabelColor = SKColor.Parse("#008000"),
            },
            new Entry(710)
            {
                Label = "Mai/22",
                ValueLabel = "710",
                Color = SKColor.Parse("#808080"),
                TextColor = SKColor.Parse("#808080"),
                ValueLabelColor = SKColor.Parse("#808080"),
            }
        };
        public TelaLogada()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            Chart1.Chart = new RadialGaugeChart { Entries = entries};
            Chart2.Chart = new BarChart {Entries = entries2 };
            Chart3.Chart = new LineChart { Entries = entries3 };
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