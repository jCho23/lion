using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedAddPostModalPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var homeView = new ContentPage();

            await Navigation.PushModalAsync(new NavigationPage(new Views.HomeView()));
        }

		public FeedAddPostModalPage()
		{
			InitializeComponent();

            BindingContext = Application.Current;
		}
    }
}