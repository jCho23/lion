using System;
using System.Collections.Generic;
using lion.Models;
using Xamarin.Forms;

namespace lion.Pages
{
    public partial class PostsDetailsPage : ContentPage
    {
        public event EventHandler<Post> PostAdded;


        public PostsDetailsPage(FeedDetails feedDetails)
        {
            if (feedDetails == null)
                throw new ArgumentNullException();

            BindingContext = feedDetails;

            InitializeComponent();
        }

        public class EntryLengthValidatorBehavior : Behavior<Entry>
        {
            public int MaxLength { get; set; }

            protected override void OnAttachedTo(Entry bindable)
            {
                base.OnAttachedTo(bindable);
                bindable.TextChanged += OnEntryTextChanged;
            }

            protected override void OnDetachingFrom(Entry bindable)
            {
                base.OnDetachingFrom(bindable);
                bindable.TextChanged -= OnEntryTextChanged;
            }

            void OnEntryTextChanged(object sender, TextChangedEventArgs e)
            {
                var entry = (Entry)sender;

                // if Entry text is longer then valid length
                if (entry.Text.Length > this.MaxLength)
                {
                    string entryText = entry.Text;

                    entryText = entryText.Remove(entryText.Length - 1); // remove last char

                    entry.Text = entryText;
                }
            }
        }


		void Handle_Completed(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
		
		
		
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}
    }
}
