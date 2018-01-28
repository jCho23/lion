using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lion.LoginPages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		private async void LoginWithFacebook_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new FacebookProfilePage());
		}
    }
}
