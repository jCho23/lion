using System;
using System.Collections.Generic;
using System.Linq;
using lion.Models;
using lion.Pages;
using lion.ViewModels;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedPage : ContentPage
    {
        public FeedPage()
        {
            var feedPageViewModel = new FeedViewModel();
            this.BindingContext = feedPageViewModel;

            InitializeComponent();
        }

        async void OnAddButton_Activated(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new FeedAddPostModalPage());
        }


        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var postMessage = e.SelectedItem as PostMessageModel;
            await Navigation.PushAsync(new FeedDetailsPage(postMessage));
            listViewFeed.SelectedItem = null;
        }

        async void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            await ((FeedViewModel)BindingContext)?.ExecuteSearch(e.NewTextValue);
        }

    }
}
