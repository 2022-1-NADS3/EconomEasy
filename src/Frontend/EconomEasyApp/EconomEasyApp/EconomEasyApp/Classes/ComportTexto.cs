using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EconomEasyApp.Classes
{
    public class ComportTexto : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += Minusculo;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Minusculo;
        }

        private void Minusculo(object sender, TextChangedEventArgs args)
        {
            if (string.IsNullOrEmpty(args.NewTextValue))
            {
                //NewTextValue é o valor que o usuário digitou, e OldTextValue é o anterior
                ((Entry)sender).Text = args.NewTextValue.ToLower();
            }
        }
    }
}
