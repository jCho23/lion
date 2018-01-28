using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Views
{
    public partial class HomeView : TabbedPage
    {
        List<FeedDetails> GetPosts()
		{
			//Call to a remote service, placeholder for now
			return new List<FeedDetails>{
                new FeedDetails {Post= "Your work is going to fill a large part of your life, and the only way to be truly satisfied is to do what you believe is great work. ", UserUrl = "http://lorempixel.com/100/100/people/1"},
                new FeedDetails { Post = "And the only way to do great work is to love what you do. ", UserUrl = "http://lorempixel.com/100/100/people/4", Status= "Hiya!" } 
            };
		}
		
		void Handle_Refreshing(object sender, System.EventArgs e)
		{
            listViewFeed.ItemsSource = GetPosts();

            listViewFeed.EndRefresh();
		}

        public HomeView()
        {
            InitializeComponent();

            listViewFeed.ItemsSource = GetPosts();
        }

    }
}
