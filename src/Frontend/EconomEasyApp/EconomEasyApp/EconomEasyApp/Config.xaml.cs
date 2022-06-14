using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        DateTime _triggerTime;

        public Config()
        {
            InitializeComponent();
        }
        private void VoltaPrimTela(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogada());
        }
        async void Button_Clear(object sender, EventArgs e)
        {
            await DisplayAlert("Tem certeza que deseja LIMPAR seus dados?", "Seus dados não poderão ser recuperados", "Sim", "Não");
        }
        async void Button_Delete(object sender, EventArgs e)
        {
            await DisplayAlert("Tem certeza que deseja DELETAR sua conta?", "Sua conta será excluída definitivamente", "Sim", "Não");
        }
        bool OnTimerTick()
        {
            if (_switch.IsToggled && DateTime.Now >= _triggerTime)
            {
                _switch.IsToggled = false;
                DisplayAlert("Timer Alert", "The '" + _entry.Text + "' timer has elapsed", "OK");
            }
            return true;
        }

        void OnTimePickerPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            SetTriggerTime();
        }

        void SetTriggerTime()
        {
            if (_switch.IsToggled)
            {
                _triggerTime = DateTime.Today + _timePicker.Time;
                if (_triggerTime < DateTime.Now)
                {
                    _triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
    }
}