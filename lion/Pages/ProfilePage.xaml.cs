using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;
using lion.ViewModels;

namespace lion.Pages
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            //var profileViewModel = new ProfileViewModel(postMessage);
            //this.BindingContext = profileViewModel;
                

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
