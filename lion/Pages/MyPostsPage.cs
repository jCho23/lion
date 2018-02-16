using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class MyPostsPage : ContentPage
    {
        public MyPostsPage()
        {
            InitializeComponent();

            MyPostsListView.ItemsSource = new List <PostMessage>{
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
        }
    }
}
