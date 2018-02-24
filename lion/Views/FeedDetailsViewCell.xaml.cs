using System;
using System.Collections.Generic;

using Xamarin.Forms;
using lion.Models;

namespace lion.Views
{
    public partial class FeedDetailsViewCell : ViewCell
    {
        public FeedDetailsViewCell()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var model = BindingContext as ReplyMessageModel;

            ReplyMessageLabel.Text = model.ReplyText;
            UserProfilePicture.Source = model.ReplyUser.PictureUrl;
        }
    }
}