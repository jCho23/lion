using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace lion.ViewModels
{
    public class FeedDetailsPageViewModel : INotifyPropertyChanged
    {
        string replyPostInput = string.Empty;
        ICommand postButtonCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public string ReplyPostInput
        {
            get => replyPostInput;
            set => SetProperty(ref replyPostInput, value);
        }

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

        void SetProperty<T>(ref T backingStore, T value, Action onChanged = null, [CallerMemberName] string propertyname = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return;

            backingStore = value;

            onChanged?.Invoke();

            OnPropertyChanged(propertyname);
        }

        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
