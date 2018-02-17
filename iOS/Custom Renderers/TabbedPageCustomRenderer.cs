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
        //public TabbedPageCustomRenderer()
        //{
        //    TabBar.TintColor = UIColor.Clear;
        //    TabBar.BarTintColor = UIColor.Clear;
        //    TabBar.BackgroundColor = UIColor.Clear;
        //}
    }
}
