using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedAddPostModalPage : ContentPage
    {


        void Handle_Completed(object sender, System.EventArgs e)
        {
            var app = Application.Current as App;
            app.Post = ModalEditor.Text;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }


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