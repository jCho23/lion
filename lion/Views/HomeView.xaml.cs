using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Views
{
    public partial class HomeView : TabbedPage
    {
        public HomeView()
        {
            InitializeComponent();

            //var posts = new List<string>
            //{
            //    "Post1",
            //    "Post2",
            //    "Post3"
            //};
            //listViewFeed.ItemsSource = posts;

            listViewFeed.ItemsSource = new List<FeedDetails>{
                new FeedDetails {Post= "1", UserUrl = "http://lorempixel.com/100/100/people/1"},
                new FeedDetails { Post = "2", UserUrl = "http://lorempixel.com/100/100/people/4", Status= "Hiya!" } };

        }

        List<Post> GetPosts()
        {
            //Call to a remote service, placeholder for now
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
