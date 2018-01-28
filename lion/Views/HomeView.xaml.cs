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
				new FeedDetails {Post= "1", UserUrl = "http://lorempixel.com/100/100/people/1"},
				new FeedDetails { Post = "2", UserUrl = "http://lorempixel.com/100/100/people/4", Status= "Hiya!" } 
            };
			
		}
		
		void Handle_Refreshing(object sender, System.EventArgs e)
		{
            listViewFeed.ItemsSource = GetPosts();
		}
        public HomeView()
        {
            InitializeComponent();

            listViewFeed.ItemsSource = GetPosts();
        }

    }
}
