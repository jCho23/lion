using System;
using System.Collections.ObjectModel;
using lion.Models;

namespace lion.ViewModels
{
    public class MyPostsViewModel : BaseViewModel
    {
        private ObservableCollection<PostMessageModel> _myPostMessages = new ObservableCollection<PostMessageModel>();
        public ObservableCollection<PostMessageModel> MyPostMessages
        {
            get{
                return _myPostMessages;
            }

            set{
                _myPostMessages = value;
            }
        }


        //IList<PostMessage> 
        //MyPostsListView.ItemsSource = new List<PostMessage>{
        //        new PostMessage {
        //            Post = "And the only way to do great work is to love what you do. ",
        //            UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
        //            Status= "23 replies"},
        //        new PostMessage {
        //            Post = "Everything around you that you call life was made up by people that were no smarter than you",
        //            UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
        //            Status= "8 replies" },
        //        new PostMessage {
        //            Post = "What's the best pizza joint around campus? ",
        //            UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
        //            Status= "48 replies" },
        //        new PostMessage {
        //            Post = "Everything around you that you call life was made up by people that were no smarter than you",
        //            UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
        //            Status= "8 replies" },
        //        new PostMessage {
        //            Post = "Everything around you that you call life was made up by people that were no smarter than you",
        //            UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
        //            Status= "8 replies" },
        //        new PostMessage {
        //            Post = "Everything around you that you call life was made up by people that were no smarter than you",
        //            UserUrl = "http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg",
        //            Status= "8 replies" }
        //};
    }
}
