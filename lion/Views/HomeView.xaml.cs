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

            this.BarBackgroundColor = Color.Gold;
            this.BarTextColor = Color.FromHex("#003366");
        }
    }
}
