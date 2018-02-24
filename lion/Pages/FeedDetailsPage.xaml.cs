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
 
          

            //switch (Xamarin.Forms.Device.RuntimePlatform)
            //{
            //    case Xamarin.Forms.Device.iOS:
            //        //postButton.Margin = new Thickness(0, 1, 0, 0);
            //        break;
            //    case Xamarin.Forms.Device.Android:
            //        break;
            //}
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
