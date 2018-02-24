using System;
using System.Collections.Generic;
using lion.Models;
using lion.ViewModels;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class MyPostsPage : ContentPage
    {
        public MyPostsPage()
        {
            var myPostsViewModel = new MyPostsViewModel();
            this.BindingContext = myPostsViewModel;


            InitializeComponent();

        }
    }
}