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
            //BindingContext = new FeedPageViewModel();

            InitializeComponent();

            listViewFeed.ItemsSource = GetPosts();



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

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listViewFeed.ItemsSource = GetPosts(e.NewTextValue);
        }

        IEnumerable<PostMessageModel> GetPosts(string searchText = null)
        {
            //Call to a remote service, placeholder for now
            var posts = new List<PostMessageModel>
            {
                //new PostMessageModel
                //{
                //    PostText = "And the only way to do great work is to love what you do. ",
                //    NumberOfReplies =23,
                //    PostUser= new UserProfileModel
                //    {
                //        Name = "Sarah Jenner",
                //        PictureUrl = "https://lion.blob.core.windows.net/pic1/pic1.jpeg"
                //    }
                //},
                //new PostMessageModel
                //{
                //    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                //    NumberOfReplies = 8,
                //    PostUser= new UserProfileModel
                //    {
                //        Name = "Suzanne Jenner",
                //        PictureUrl = "https://lion.blob.core.windows.net/pic2/pic2.jpeg",
                //    }
                //},
                //new PostMessageModel
                //{
                //    PostText = "What's the best pizza joint around campus? ",
                //    NumberOfReplies = 48,
                //    PostUser= new UserProfileModel
                //    {
                //        Name = "The Rock",
                //        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                //    }
                //},
                //new PostMessageModel
                //{
                //    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                //    NumberOfReplies = 8,
                //    PostUser= new UserProfileModel
                //    {
                //        Name = "Kylie Jenner",
                //        PictureUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.png",
                //    }
                //},
                //new PostMessageModel
                //{
                //    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                //    NumberOfReplies = 8,
                //    PostUser= new UserProfileModel
                //    {
                //        Name = "Kevin Hart",
                //        PictureUrl = "https://healthyceleb.com/wp-content/uploads/2016/07/Kevin-Hart-headshot.jpg",
                //    }
                //},
                new PostMessageModel
                {
                    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies = 8,
                    PostUser= new UserProfileModel
                    {
                        Name = "Michael Jordan",
                        PictureUrl = "https://i.ytimg.com/vi/RnSgCv2X0ns/hqdefault.jpg",
                    }
                }
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return posts;


            return posts.Where(x => x.Id.ToLower().Contains(searchText.ToLower()));
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listViewFeed.ItemsSource = GetPosts();

            listViewFeed.EndRefresh();
        }


    }
}
