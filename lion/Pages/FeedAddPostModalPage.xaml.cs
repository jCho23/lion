using System;
using System.Collections.Generic;

using Xamarin.Forms;

using lion.Controls;

namespace lion.Pages
{
    public partial class FeedAddPostModalPage : ContentPage
    {
		public FeedAddPostModalPage()
		{
			InitializeComponent();
			
			BindingContext = Application.Current;
		}

        async void OnCanceled_Clicked(object sender, System.EventArgs e)
        {
            var homeView = new ContentPage();

            await Navigation.PushModalAsync(new NavigationPage(new Pages.LionTabbedPage()));
        }

    }
}