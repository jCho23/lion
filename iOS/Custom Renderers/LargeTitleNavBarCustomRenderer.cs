using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;
using lion.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(NavigationPage),typeof(LargeTitleNavBarCustomRenderer))]
namespace lion.iOS.CustomRenderers
{
    public class LargeTitleNavBarCustomRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
            {
                NavigationBar.PrefersLargeTitles = true;
            }
        }
    }
}