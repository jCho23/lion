using System;
using System.Collections.ObjectModel;
using lion.Models;

namespace lion.ViewModels
{
    public class MyPostsViewModel : BaseViewModel
    {
        ObservableCollection<PostMessageModel> myPostsListViewItemSource;

        public MyPostsViewModel()
        {
            myPostsListViewItemSource = new ObservableCollection<PostMessageModel>
            {
                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }

                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }

                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }

                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }

                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }

                },

                new PostMessageModel()
                {
                    PostText = "And the only way to do great work is to love what you do. ",
                    PostUser= new UserProfileModel
                    {
                        PictureUrl="http://www.profightdb.com/img/wrestlers/thumbs-600/6baee11272the-rock.jpg"
                    }

                }
            };
                   
        }
    }
}
