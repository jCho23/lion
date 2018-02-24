using System;
using System.Linq;
using System.Collections.Generic;

using Xamarin.Forms;

using lion.Models;

namespace lion.Pages
{
    public partial class LionTabbedPage : TabbedPage
    {
        public LionTabbedPage()
        {
            InitializeComponent();

            this.BarBackgroundColor = Color.FromHex("#f6b93b");
            this.BarTextColor = Color.FromHex("#0c2461");

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
