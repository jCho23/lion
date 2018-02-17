using System;
using System.Linq;
using System.Collections.Generic;

using Xamarin.Forms;

using lion.Pages;
using lion.Models;

namespace lion.Views
{
    public partial class HomeView : TabbedPage
    {
        public HomeView()
        {
            InitializeComponent();

            this.BarBackgroundColor = Color.FromHex("#f6b93b");
            this.BarTextColor = Color.FromHex("#003366");

            switch(Xamarin.Forms.Device.RuntimePlatform)
            {
                case Xamarin.Forms.Device.iOS:
                    break;
                case Xamarin.Forms.Device.Android:
                    break;
            }
        }
    }
}
