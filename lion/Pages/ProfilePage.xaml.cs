using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {


            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var model = BindingContext as PostMessageModel;

            UserProfilePicture.Source = model.PostUser.PictureUrl;
        }
    }
}
