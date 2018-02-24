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


            MyPostsListView.ItemsSource = new List<PostMessageModel>{
                new PostMessageModel
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies= 23,
                    PostUser = new UserProfileModel
                    {
                       PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new PostMessageModel
                {
                    Id = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies= 8,
                    PostUser = new UserProfileModel
                    {
                       PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new PostMessageModel
                {
                    Id = "What's the best pizza joint around campus? ",
                    NumberOfReplies= 48,
                    PostUser = new UserProfileModel
                    {
                       PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new PostMessageModel
                {
                    Id = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies= 8,
                    PostUser = new UserProfileModel
                    {
                       PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new PostMessageModel
                {
                    Id = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies= 8,
                    PostUser = new UserProfileModel
                    {
                       PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new PostMessageModel
                {
                    Id = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies= 8,
                    PostUser = new UserProfileModel
                    {
                       PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                }
            };
        }
    }
}