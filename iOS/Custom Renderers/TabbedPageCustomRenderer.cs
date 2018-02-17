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
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
 
            //View.BackgroundColor = UIColor.Clear;
            //TabBar.TintColor = UIColor.Cyan;
            //TabBar.BarTintColor = UIColor.Clear;
            //TabBar.BackgroundColor = UIColor.Clear;
           
        }
    }
}
