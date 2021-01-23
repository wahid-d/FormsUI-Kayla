using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace formsUI.Views
{
    public partial class Cards : ContentPage
    {
        public Cards()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
