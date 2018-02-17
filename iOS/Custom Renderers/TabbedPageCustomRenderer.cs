using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;
using lion.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageCustomRenderer))]
namespace lion.iOS.CustomRenderers
{
    public class TabbedPageCustomRenderer : TabbedRenderer

    {
        public TabbedPageCustomRenderer()
        {
            TabBar.TintColor = UIColor.Black;
            TabBar.BarTintColor = UIColor.Blue;
            TabBar.BackgroundColor = UIColor.Green;
        }
    }
}
