using System;
using Xamarin.Forms;
using XFGloss;

namespace lion.XFGloss
{
    public class ContentPageGloss
    {
        #region BackgroundGradient

      
        public static readonly BindableProperty BackgroundGradientProperty =
            BindableProperty.CreateAttached("BackgroundGradient", typeof(Gradient), typeof(Cell), null);

        public static Gradient GetBackgroundGradient(BindableObject bindable)
        {
            return (Gradient)(bindable?.GetValue(BackgroundGradientProperty) ??
                              BackgroundGradientProperty.DefaultValue);
        }

        public static void SetBackgroundGradient(BindableObject bindable, Gradient value)
        {
            bindable?.SetValue(BackgroundGradientProperty, value);
        }

        #endregion

        #region Instance access

        WeakReference<BindableObject> _bindable;

      
        public ContentPageGloss(BindableObject bindable)
        {
            _bindable = new WeakReference<BindableObject>(bindable);
        }

      
        public BindableObject Bindable
        {
            get
            {
                BindableObject bindable;
                if (_bindable.TryGetTarget(out bindable))
                {
                    return bindable;
                }

                return null;
            }

            set
            {
                _bindable.SetTarget(value);
            }
        }

        public Gradient BackgroundGradient
        {
            get { return GetBackgroundGradient(Bindable); }
            set { SetBackgroundGradient(Bindable, value); }
        }

        #endregion
    }
}
