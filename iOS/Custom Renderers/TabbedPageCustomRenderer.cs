using System;
using lion.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageCustomRenderer))]

namespace lion.iOS.CustomRenderers
{
    public class TabbedPageCustomRenderer : TabbedRenderer

    {
        public TabbedPageCustomRenderer()
        {
            TabBar.TintColor = MonoTouch.UIKit.UIColor.Black;
            TabBar.BarTintColor = MonoTouch.UIKit.UIColor.Blue;
            TabBar.BackgroundColor = MonoTouch.UIKit.UIColor.Green;
        }
    }



}
