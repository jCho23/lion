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
using System.Threading.Tasks;

namespace lion.ViewModels
{
    public class FeedViewModel : BaseViewModel
    {
        string numberOfReplies;

       

        //public ICommand RefreshCommand
        //{
        //    get
        //    {
        //        return new Command(async () =>
        //        {
        //            IsRefreshing = true;

        //            await listViewItemSource2();

        //            IsRefreshing = false;
        //        });
        //    }
        //}
       

        private Command loadPostsCommand;

        public Command LoadPostsCommand
        {
            get
            {
                return loadPostsCommand ?? (loadPostsCommand = new Command(ExecuteLoadTweetsCommand, () =>
                {
                    return !IsBusy;
                }));
            }
        }

        private async void ExecuteLoadTweetsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;
            LoadPostsCommand.ChangeCanExecute();

            //DoStuff

            IsBusy = false;
            LoadPostsCommand.ChangeCanExecute();
        }

        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                if (isBusy == value)
                    return;

                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        List<PostMessageModel> originalMessages = new List<PostMessageModel>();
        ObservableCollection<PostMessageModel> listViewItemSource2 = new ObservableCollection<PostMessageModel>();

        public FeedViewModel()
        {
            
            //if (postMessage.NumberOfReplies == 1)
            //    NumberOfReplies = $"{postMessage.NumberOfReplies} Reply";
            //else
            //NumberOfReplies = $"{postMessage.NumberOfReplies} Replies";



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

            originalMessages = ListViewItemSource2.ToList();
			//_refreshCommand = new Command(RefreshListViewFeed);

        }

        //async  void RefreshListViewFeed()
        //{
        //    listViewFeed = await originalMessages();
        //}

       

        public async Task ExecuteSearch(string text)
        {
            ListViewItemSource2.Clear();

            var searchResults = originalMessages.Where(message => message.PostText.ToLower().Contains(text.ToLower()));

            if (searchResults.Count() > 0)
            {
                foreach (var item in searchResults)
                    ListViewItemSource2.Add(item);
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                foreach (var item in originalMessages)
                    ListViewItemSource2.Add(item);
            }
            else
            {
                //Change UI Label to show that no records are found


            }
        }


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