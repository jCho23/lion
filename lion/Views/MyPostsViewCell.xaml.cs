using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Views
{
    public partial class MyPostsViewCell : ViewCell
    {
        public MyPostsViewCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var model = BindingContext as PostMessageModel;

            MyPostsMessageLabel.Text = model.PostText;
            UserProfilePicture.Source = model.PostUser.PictureUrl;
        }
    }
}
