using System;
using System.Collections.Generic;
using lion.Models;
using lion.ViewModels;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class MyPostsPage : ContentPage
    {
        public MyPostsPage()
        {
			var myPostsViewModel = new MyPostsViewModel();
			this.BindingContext = myPostsViewModel;

            InitializeComponent();

            //MyPostsListView.ItemsSource = new List<PostMessage>();
            //{
            //    GetPostMessages
            //};
           

            //MyPostsListView.ItemsSource = new List <PostMessage>{
                //new PostMessage {
                //    Post = "And the only way to do great work is to love what you do. ",
                //    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                //    Status= "23 replies"},
                //new PostMessage {
                //    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                //    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                //    Status= "8 replies" },
                //new PostMessage {
                //    Post = "What's the best pizza joint around campus? ",
                //    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                //    Status= "48 replies" },
                //new PostMessage {
                //    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                //    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                //    Status= "8 replies" },
                //new PostMessage {
                //    Post = "Everything around you that you call life was made up by people that were no smarter than you",
                //    UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                //    Status= "8 replies" },
                //new PostMessage {
                    //Post = "Everything around you that you call life was made up by people that were no smarter than you",
                    //UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    //Status= "8 replies" }
           

            //};
        }
    }
}
