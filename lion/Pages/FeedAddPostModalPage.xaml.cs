using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedAddPostModalPage : ContentPage
    {
        public FeedAddPostModalPage()
        {
            InitializeComponent();

            if(Application.Current.Properties.ContainsKey("Post"))
            ModalEditor.Text = Application.Current.Properties["Post"].ToString();
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            Application.Current.Properties["Post"] = ModalEditor.Text;
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
    }
}