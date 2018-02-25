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
                HeightRequest= 100
            };
                
        }
    }
}
