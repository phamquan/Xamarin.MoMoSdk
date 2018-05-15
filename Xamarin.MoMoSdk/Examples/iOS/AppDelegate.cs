using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.MoMoSdk;

namespace MoMoExample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            //var t  = MoMoPayment.ShareInstant;

            MoMoSdk.Current.Init(NSBundle.MainBundle.BundleIdentifier,
                                 "HCVN", "Home Credit Vietnam", "Home Credit App", "Payment for installments");
            
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
