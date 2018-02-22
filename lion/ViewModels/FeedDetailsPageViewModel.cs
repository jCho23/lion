using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace lion.ViewModels
{
    public class FeedDetailsPageViewModel : BaseViewModel
    {
        string replyPostInput = string.Empty;
        ICommand postButtonCommand;

        public string ReplyPostInput
        {
            get => replyPostInput;
            set => SetProperty(ref replyPostInput, value);
        }

        //public ICommand PostButtonCommand => postButtonCommand ??
            //(postButtonCommand = new Command(async () => await ExecutePostButtonCommand()));


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
