using System;
using Xamarin.Forms;

namespace HandheldOrdering.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
