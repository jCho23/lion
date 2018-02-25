using System;
using Xamarin.Forms;
namespace lion.Pages
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var splashLayout = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "Bears.png",
                WidthRequest = 100,
                HeightRequest = 100
            };

            AbsoluteLayout.SetLayoutFlags(splashImage, 
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5,0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            splashLayout.Children.Add(splashImage);

            this.BackgroundColor = Color.Accent;
            this.Content = splashLayout;
        }
    }
}
