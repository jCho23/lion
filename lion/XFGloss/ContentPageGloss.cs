using System;
using Xamarin.Forms;
using XFGloss;

namespace lion.XFGloss
{
    public class ContentPageGloss
    {
        #region BackgroundGradient

        /// <summary>
        /// Allows a <see cref="T:XFGloss.Gradient"/> instance to be assigned as a multiple step gradient fill to
        /// <see cref="T:Xamarin.Forms.ContentPage"/> derived classes.
        /// </summary>
        public static readonly BindableProperty BackgroundGradientProperty =
            BindableProperty.CreateAttached("BackgroundGradient", typeof(Gradient), typeof(Cell), null);

        /// <summary>
        /// Gets the <see cref="T:XFGloss.Gradient"/> instance that is currently assigned to the passed
        /// <see cref="T:Xamarin.Forms.BindableObject"/>.
        /// </summary>
        /// <returns>The currently assigned background gradient or null if nothing is assigned.</returns>
        /// <param name="bindable">The <see cref="T:Xamarin.Forms.BindableObject"/> that the BackgroundGradient attached 
        /// property value should be retrieved from.</param>
        public static Gradient GetBackgroundGradient(BindableObject bindable)
        {
            return (Gradient)(bindable?.GetValue(BackgroundGradientProperty) ??
                              BackgroundGradientProperty.DefaultValue);
        }

        /// <summary>
        /// Sets the passed <see cref="T:XFGloss.Gradient"/> value as the currently assigned background gradient for
        /// the passed <see cref="T:Xamarin.Forms.BindableObject"/>.
        /// </summary>
        /// <param name="bindable">The <see cref="T:Xamarin.Forms.BindableObject"/> that the BackgroundGradient attached 
        /// property value should be assigned to.</param>
        /// <param name="value">The <see cref="T:XFGloss.Gradient"/> value that should be assigned to the passed
        /// <see cref="T:Xamarin.Forms.BindableObject"/>.</param>
        public static void SetBackgroundGradient(BindableObject bindable, Gradient value)
        {
            bindable?.SetValue(BackgroundGradientProperty, value);
        }

        #endregion

        #region Instance access

        WeakReference<BindableObject> _bindable;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:XFGloss.ContentPageGloss"/> class. Used as a convenient way 
        /// to assign multiple XFGloss property values to the target <see cref="Xamarin.Forms.BindableObject"/> instance.
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        public ContentPageGloss(BindableObject bindable)
        {
            _bindable = new WeakReference<BindableObject>(bindable);
        }

        /// <summary>
        /// Gets or sets the <see cref="T:Xamarin.Forms.BindableObject"/> that the 
        /// <see cref="T:XFGloss.ContentPageGloss"/> instance methods will retrieve values from or assign values to.
        /// </summary>
        /// <value>The bindable.</value>
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

        /// <summary>
        /// Gets or sets the <see cref="T:XFGloss.Gradient"/> instance of the background gradient for the assigned
        /// <see cref="T:XFGloss.ContentPageGloss.Bindable"/> instance.
        /// </summary>
        /// <value>The background gradient.</value>
        public Gradient BackgroundGradient
        {
            get { return GetBackgroundGradient(Bindable); }
            set { SetBackgroundGradient(Bindable, value); }
        }

        #endregion
    }
}
