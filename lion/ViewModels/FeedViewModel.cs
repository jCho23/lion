using System;
using System.ComponentModel;
using System.Windows.Input;
using lion.Pages;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using lion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace lion.ViewModels
{
    public class FeedViewModel : BaseViewModel
    {
        string  numberOfReplies;

        ObservableCollection<PostMessageModel> listViewItemSource2;

        public FeedViewModel()
        {
            //if (postMessage.NumberOfReplies == 1)
            //    NumberOfReplies = $"{postMessage.NumberOfReplies} Reply";
            //else
                //NumberOfReplies = $"{postMessage.NumberOfReplies} Replies";


            //IEnumerable<PostMessageModel> GetPosts(string searchText = null)
            //{
                ListViewItemSource2 = new ObservableCollection<PostMessageModel>
            {
                new PostMessageModel
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    NumberOfReplies =23,
                    PostUser= new UserProfileModel
                    {
                        Name = "Sarah Jenner",
                        PictureUrl = "https://lion.blob.core.windows.net/pic1/pic1.jpeg"
                    }
                },
                new PostMessageModel
                {
                    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies = 8,
                    PostUser= new UserProfileModel
                    {
                        Name = "Suzanne Jenner",
                        PictureUrl = "https://lion.blob.core.windows.net/pic2/pic2.jpeg",
                    }
                },
                new PostMessageModel
                {
                    PostText = "What's the best pizza joint around campus? ",
                    NumberOfReplies = 48,
                    PostUser= new UserProfileModel
                    {
                        Name = "The Rock",
                        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new PostMessageModel
                {
                    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies = 8,
                    PostUser= new UserProfileModel
                    {
                        Name = "Kylie Jenner",
                        PictureUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.png",
                    }
                },
                new PostMessageModel
                {
                    PostText = "Everything around you that you call life was made up by people that were no smarter than you",
                    NumberOfReplies = 8,
                    PostUser= new UserProfileModel
                    {
                        Name = "Kevin Hart",
                        PictureUrl = "https://healthyceleb.com/wp-content/uploads/2016/07/Kevin-Hart-headshot.jpg",
                    }
                },
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
        }
        //if (string.IsNullOrWhiteSpace(searchText))
        //    return posts;


        //return posts.Where(x => x.Id.ToLower().Contains(searchText.ToLower()));


        //        }

       
        public string NumberOfReplies
        {
            get => numberOfReplies;
            set => SetProperty(ref numberOfReplies, value);
        }

        public ObservableCollection<PostMessageModel> ListViewItemSource2
        {
            get => listViewItemSource2;
            set => SetProperty(ref listViewItemSource2, value);
        }
    }
}

