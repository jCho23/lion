using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lion.Views
{
    public partial class HomeView : TabbedPage
    {
        public HomeView()
        {
            InitializeComponent();

            var posts = new List<string>
            {
                "Post1",
                "Post2",
                "Post3"
            };

            ListView.ItemsSource = posts;
        }
    }
}
