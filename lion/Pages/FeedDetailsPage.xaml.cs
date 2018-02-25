using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using lion.Models;
using lion.Persistence;
using lion.ViewModels;

namespace lion.Pages
{
    public partial class FeedDetailsPage : ContentPage
    {
        public FeedDetailsPage(PostMessageModel postMessage)
        {
            var feedDetailsPageViewModel = new FeedDetailsViewModel(postMessage);
            this.BindingContext = feedDetailsPageViewModel;

            InitializeComponent();
        }

        //async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //        return;

        //    var postMessage = e.SelectedItem as PostMessageModel;
        //    await Navigation.PushAsync(new ProfilePage(postMessage));
        //    FeedDetailsPageListView.SelectedItem = null;
        //}

        void OnReplyTextLimit(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 23)
            {
                replyPostInput.Text = replyPostInput.Text.Remove(23);

            }
        }
    }
}
