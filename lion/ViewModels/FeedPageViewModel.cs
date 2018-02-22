using System;
using System.ComponentModel;
using System.Windows.Input;
using lion.Pages;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace lion.ViewModels
{
    public class FeedPageViewModel : BaseViewModel
    {
        public ICommand OnAddButtonCommand { get; private set; }

        public FeedPageViewModel()
        {
            OnAddButtonCommand = new Command(AddButton);
        }

        async private void AddButton()
        {
            await Navigation.PushModalAsync(new FeedAddPostModalPage());

        }

        //private ICommand _searchCommand;
        //public ICommand SearchCommand
        //{
        //    get
        //    {
        //        return _searchCommand ?? (_searchCommand = new Command<string>((text) =>
        //        {
                    
        //        }));
        //    }
        //}

    }
}
