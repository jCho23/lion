using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class PostsDetailsPage : ContentPage
    {
        

        public PostsDetailsPage(FeedDetails feedDetails)
        {
            if (feedDetails == null)
                throw new ArgumentNullException();

            BindingContext = feedDetails;

            InitializeComponent();

          
        }



        void OnReplyTextLimit(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length > 23)
            {
                replyPostInput.Text = replyPostInput.Text.Remove(23);

            }
        }

		void Handle_Completed(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
		
		
		
		void OnReplyPost_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
    }
}
