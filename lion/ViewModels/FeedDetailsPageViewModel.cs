using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using lion.Models;

namespace lion.ViewModels
{
    public class FeedDetailsPageViewModel : BaseViewModel
    {
        string postUserProfileUrl, postUserPostText, postUserName, numberOfReplies;
        ObservableCollection<ReplyMessageModel> listViewItemSource;


        public FeedDetailsPageViewModel(PostMessageModel postMessage)
        {
            //Pull all ReplyMessageModels from the database where ReplyMessageModel.PostMessageId == postMessage.Id
            PostUserProfileUrl = postMessage.PostUser.PictureUrl;
            PostUserName = postMessage.PostUser.Name;
            PostUserPostText = postMessage.PostText;

            if (postMessage.NumberOfReplies == 1)
                NumberOfReplies = $"{postMessage.NumberOfReplies} Reply";
            else
                NumberOfReplies = $"{postMessage.NumberOfReplies} Replies";

            PostButtonCommand = new Command(() =>
            {
                var dummyPostMessage = new ReplyMessageModel
                {
                    Id = "This was created via Command",
                    ReplyText = "This was created via Command",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                };

                ListViewItemSource.Add(dummyPostMessage);
            });

            ListViewItemSource = new ObservableCollection<ReplyMessageModel>
            {
                new ReplyMessageModel
                {
                    ReplyText = "And the only way to do great work is to love what you do. ",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new ReplyMessageModel
                {
                    ReplyText = "Everything around you that you call life was made up by people that were no smarter than you",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "https://cdn.inquisitr.com/wp-content/uploads/2016/04/kylie-jenner-paper-photoshoot.png"
                    }
                },
                new ReplyMessageModel
                {
                    ReplyText = "What's the best pizza joint around campus? ",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "https://healthyceleb.com/wp-content/uploads/2016/07/Kevin-Hart-headshot.jpg",
                    }
                },
                new ReplyMessageModel
                {
                    ReplyText = "Everything around you that you call life was made up by people that were no smarter than you",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "https://i.ytimg.com/vi/RnSgCv2X0ns/hqdefault.jpg",
                    }
                },
                new ReplyMessageModel
                {
                    ReplyText= "Everything around you that you call life was made up by people that were no smarter than you",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                },
                new ReplyMessageModel
                {
                    ReplyText = "Everything around you that you call life was made up by people that were no smarter than you",
                    ReplyUser = new UserProfileModel
                    {
                        PictureUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
                    }
                }
            };
        }

        public ICommand PostButtonCommand { get; }

        public string PostUserName
        {
            get => postUserName;
            set => SetProperty(ref postUserName, value);
        }

        public string PostUserPostText
        {
            get => postUserPostText;
            set => SetProperty(ref postUserPostText, value);
        }

        public string PostUserProfileUrl
        {
            get => postUserProfileUrl;
            set => SetProperty(ref postUserProfileUrl, value);
        }

        public string NumberOfReplies
        {
            get => numberOfReplies;
            set => SetProperty(ref numberOfReplies, value);
        }

        public ObservableCollection<ReplyMessageModel> ListViewItemSource
        {
            get => listViewItemSource;
            set => SetProperty(ref listViewItemSource, value);
        }



        //async Task ExecutePostButtonCommand()
        //{
        //    //try
        //    //{
        //    //   
        //    //}
        //    //catch 
        //    //{
        //    //}
        //    //finally
        //    //{
        //    //}
        //}




    }
}
