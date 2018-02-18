using System;
using lion.iOS.CustomRenderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(ViewCell), typeof(ViewCellCustomRenderer))]
namespace lion.iOS.CustomRenderers
{
    public class ViewCellCustomRenderer
    {
        public ViewCellCustomRenderer()
        {
        }
    }
}
