using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;



namespace lion.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            PrintFontNamesToConsole();

            ImageCircleRenderer.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

		[Conditional("DEBUG")]
		void PrintFontNamesToConsole()
		{
			foreach (var fontFamilyName in UIFont.FamilyNames)
			{
				Console.WriteLine(fontFamilyName);
				
				foreach (var fontName in UIFont.FontNamesForFamilyName(fontFamilyName))
					Console.WriteLine($"={fontName}");
			}
		}
    }
}
