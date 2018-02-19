using System;
using System.Collections.Generic;
using System.ComponentModel;
using lion.Models;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedDetailsPage : ContentPage
    {
        //public event EventHandler<PostMessage> PostedMessage;


        public FeedDetailsPage(PostMessage feedDetails)
        {
            if (feedDetails == null)
                throw new ArgumentNullException();

            BindingContext = feedDetails;


            InitializeComponent();

            FeedDetailsPageListView.ItemsSource = new List<PostMessage>{
                new PostMessage {
                    Post = "And the only way to do great work is to love what you do. ",
                    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    Status= "23 replies"},
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.png",
                    Status= "8 replies" },
                new PostMessage {
                    Post = "What's the best pizza joint around campus? ",
                    UserUrl = "https://healthyceleb.com/wp-content/uploads/2016/07/Kevin-Hart-headshot.jpg",
                    Status= "48 replies" },
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "https://i.ytimg.com/vi/RnSgCv2X0ns/hqdefault.jpg",
                    Status= "8 replies" },
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    Status= "8 replies" },
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    Status= "8 replies" }
            };

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



        //void OnPostEntry_Completed(object sender, System.EventArgs e)
        //{
        //	throw new NotImplementedException();
        //}

        void OnReplyPost_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
