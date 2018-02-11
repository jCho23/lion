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
        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Post new message", "Post new message", "OK");
        }

        public HomeView()
        {
            InitializeComponent();

            this.BarBackgroundColor = Color.Gold;
            this.BarTextColor = Color.MidnightBlue;
        }
    }
}
