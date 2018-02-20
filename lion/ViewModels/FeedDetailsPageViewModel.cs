using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lion.ViewModels
{
    public class FeedDetailsPageViewModel:INotifyPropertyChanged
    {
        string replyPostInput = string.Empty;
        ICommand postButtonCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand PostButtonCommand => postButtonCommand ??
            (postButtonCommand = new Command(async () => await ExecutePostButtonCommand()));


        async Task ExecutePostButtonCommand()
        {
            //try
            //{
            //   
            //}
            //catch 
            //{
            //}
            //finally
            //{
            //}
        }
    }
}
