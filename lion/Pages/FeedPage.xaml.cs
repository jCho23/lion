using System;
using System.Collections.Generic;
using System.Linq;
using lion.Models;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class FeedPage : ContentPage
    {

       

        async void Handle_Activated(object sender, System.EventArgs e)
        {

            await Navigation.PushModalAsync(new FeedAddPostModalPage());
				
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var feedDetails = e.SelectedItem as PostMessage;
            await Navigation.PushAsync(new FeedDetailsPage(feedDetails));
            listViewFeed.SelectedItem = null;




        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listViewFeed.ItemsSource = GetPosts(e.NewTextValue);
        }

        IEnumerable<PostMessage> GetPosts(string searchText = null)
        {
            //Call to a remote service, placeholder for now
            var posts = new List<PostMessage>{
                new PostMessage {
                    Post = "And the only way to do great work is to love what you do. ",
                    UserUrl = "https://lion.blob.core.windows.net/pic1/pic1.jpeg",
                    Status= "23 replies"},
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "https://lion.blob.core.windows.net/pic2/pic2.jpeg",
                    Status= "8 replies" },
                new PostMessage {
                    Post = "What's the best pizza joint around campus? ",
                    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    Status= "48 replies" },
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.png",
                    Status= "8 replies" },
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "https://healthyceleb.com/wp-content/uploads/2016/07/Kevin-Hart-headshot.jpg",
                    Status= "8 replies" },
                new PostMessage {
                    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    UserUrl = "https://i.ytimg.com/vi/RnSgCv2X0ns/hqdefault.jpg",
                    Status= "8 replies" }
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return posts;


            return posts.Where(x => x.Post.ToLower().Contains(searchText.ToLower()));
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listViewFeed.ItemsSource = GetPosts();

            listViewFeed.EndRefresh();
        }


        public FeedPage()
        {
            InitializeComponent();

            listViewFeed.ItemsSource = GetPosts();
        }
    }
}
