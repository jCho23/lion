using System;
using Android.Content;
using Android.Graphics;
using lion.Droid.CustomRenderers;
using Plugin.CurrentActivity;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(LabelCustomRenderer))]
namespace lion.Droid.CustomRenderers
{
    public class LabelCustomRenderer : LabelRenderer
    {
        #region Constructors
        public LabelCustomRenderer(Context context) : base(context)
        {
        }
        #endregion

        #region Properties
        Context CurrentContext => CrossCurrentActivity.Current.Activity;
        #endregion

        #region Methods
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
                Control.Typeface = Typeface.CreateFromAsset(CurrentContext.Assets, "Roboto-Thin.ttf");
        }
        #endregion
    }
}
