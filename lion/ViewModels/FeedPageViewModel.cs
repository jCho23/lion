using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace lion.ViewModels
{
    public class FeedPageViewModel : BaseViewModel
    {
        private ICommand _searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                return _searchCommand ?? (_searchCommand = new Command<string>((text) =>
                {
                    
                }));
            }
        }
    }
}
