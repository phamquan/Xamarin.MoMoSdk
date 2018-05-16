using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MoMoExample.Services;
using MoMoSdkBindings.iOS;
using UIKit;
using Xamarin.Forms;

namespace MoMoExample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            //var t  = MoMoPayment.ShareInstant;


            //CrossMoMoSdk.Current.Init();

            global::Xamarin.Forms.Forms.Init();

            DependencyService.Get<IMoMoService>()
                             .Init(NSBundle.MainBundle.BundleIdentifier, "HCVN", "Home Credit Vietnam", "Home Credit App", "Payment for installments");

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }

		public override bool HandleOpenURL(UIApplication application, NSUrl url)
		{

            MoMoPayment.ShareInstant.HandleOpenUrl(url);
            return true;
		}
	}
}
