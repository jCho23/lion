using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Views
{
    public partial class FeedViewCell : ViewCell
    {
        public FeedViewCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var model = BindingContext as PostMessageModel;

            PostMessageLabel.Text = model.PostText;
            UserProfilePicture.Source = model.PostUser.PictureUrl;
        }
    }
}
