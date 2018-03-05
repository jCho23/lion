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

        ICommand refreshCommand;

        public ICommand RefreshCommand
        {
            get { return refreshCommand ?? (refreshCommand = new Command(async () => await ExecuteRefreshCommand())); }
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
        ObservableCollection<PostMessageModel> feedListViewItemSource = new ObservableCollection<PostMessageModel>();

        public FeedViewModel()
        {
            
            //if (postMessage.NumberOfReplies == 1)
            //    NumberOfReplies = $"{postMessage.NumberOfReplies} Reply";
            //else
            //NumberOfReplies = $"{postMessage.NumberOfReplies} Replies";



            ItemsCurrentlyDisplayedInList = new ObservableCollection<PostMessageModel>
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

            originalMessages = ItemsCurrentlyDisplayedInList.ToList();

        }

		async Task  ExecuteRefreshCommand()
		{
			if (IsBusy)
				return;
			
			IsBusy = true;
			feedListViewItemSource.Clear();
			
			var ClearedList = feedListViewItemSource;
			var GetPosts = originalMessages;
			
			if (ClearedList.Count() == 0)
			{
				foreach (var item in GetPosts)
					ItemsCurrentlyDisplayedInList.Add(item);
				
				IsBusy = false;
			}
			
			else
			{
			}
		}

        public async Task ExecuteSearch(string text)
        {
            var messagesToDisplay = originalMessages.Where(
                message => message.PostText.ToLower()
                    .Contains(text.ToLower()));

            if (messagesToDisplay.Count() == 0)
                ItemsCurrentlyDisplayedInList.Clear();
            else if (messagesToDisplay.Count() > 0)
            {
                var messagesToAdd = messagesToDisplay.Except(ItemsCurrentlyDisplayedInList).ToList();
                foreach (var message in messagesToAdd)
                    ItemsCurrentlyDisplayedInList.Add(message);

                var messagesToRemove = ItemsCurrentlyDisplayedInList.Except(messagesToDisplay).ToList();
                foreach (var message in messagesToRemove)
                    ItemsCurrentlyDisplayedInList.Remove(message);
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                var messagesToAdd = originalMessages.Except(ItemsCurrentlyDisplayedInList).ToList();
                foreach (var item in messagesToAdd)
                    ItemsCurrentlyDisplayedInList.Add(item);
            }
            //ListViewItemSource2.Clear();

            //var searchResults = originalMessages.Where(message => message.PostText.ToLower().Contains(text.ToLower()));

            //if (searchResults.Count() > 0)
            //{
            //    foreach (var item in searchResults)
            //        ListViewItemSource2.Add(item);
            //}
            //else if (string.IsNullOrWhiteSpace(text))
            //{
            //    foreach (var item in originalMessages)
            //        ListViewItemSource2.Add(item);
            //}
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

        public ObservableCollection<PostMessageModel> ListViewItemSource { get; set; } = new ObservableCollection<PostMessageModel>();

        public ObservableCollection<PostMessageModel> ItemsCurrentlyDisplayedInList
        {
            get => feedListViewItemSource;
            set => SetProperty(ref feedListViewItemSource, value);
        }
    }
}