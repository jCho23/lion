using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Views
{
    public partial class PostsDetailsPage : ContentPage
    {
        public PostsDetailsPage(FeedDetails feedDetails)
        {
            if (feedDetails == null)
                throw new ArgumentNullException();
            InitializeComponent();
        }
    }
}
