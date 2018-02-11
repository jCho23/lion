using System;
using System.Collections.Generic;
using System.Linq;
using lion.Models;
using lion.Pages;
using Xamarin.Forms;

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


        }

    }
}
