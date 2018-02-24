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

            BindingContext = new FeedDetailsPageViewModel(postMessage);    

            InitializeComponent();
 
           
        }

        void OnReplyTextLimit(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 23)
            {
                replyPostInput.Text = replyPostInput.Text.Remove(23);

            }
        }
    }
}
