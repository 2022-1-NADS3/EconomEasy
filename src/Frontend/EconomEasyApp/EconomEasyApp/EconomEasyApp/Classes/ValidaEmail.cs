using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EconomEasyApp.Classes
{
    internal class ValidaEmail : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.Text.IndexOf("@") > 3)
            {
                if (sender.Text.Length < 6)
                {
                    sender.TextColor = Color.Red;
                }
            }
        }
    }
}
