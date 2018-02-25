﻿using System;
using System.Collections.Generic;
using lion.Controls;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedAddPostModalPage : ContentPage
    {

        private const string PostKey = "PostText";


        async void OnCanceled_Clicked(object sender, System.EventArgs e)
        {
            var homeView = new ContentPage();

            await Navigation.PushModalAsync(new NavigationPage(new Pages.LionTabbedPage()));
        }

        void OnSaveUserPost(object sender, System.EventArgs e)
        {
            Application.Current.Properties["PostText"] = ModalEditor.Text;

            //Application.Current.SavePropertiesAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

		public FeedAddPostModalPage()
		{
			InitializeComponent();

            BindingContext = Application.Current;
		}
    }
}