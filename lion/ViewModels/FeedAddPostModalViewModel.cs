//using System;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using Xamarin.Forms;

//namespace lion.ViewModels
//{
//    public class FeedAddPostModalViewModel :BaseViewModel
//    {
//        string userInputPost = string.Empty;

//        ICommand postMessageCommand;

//        public ICommand SubmitButtonCommand => postMessageCommand ??
//        (postMessageCommand = new Command(async () => await ExecutePostMessageCommand()));


//        public string UserInputPost
//        {
//            get => userInputPost;
//            set => SetProperty(ref userInputPost, value);
//        }

//        async Task ExecutePostMessageCommand()
//        {
//            try
//            {
//                //var result = await UserInputPost;
//                //if (result == null)
//                {
                    
//                }
//                else
//                {
         
//                }

//            }
           
//            catch (Exception e)
//            {
                
//            }

//        }
//    }
//}
