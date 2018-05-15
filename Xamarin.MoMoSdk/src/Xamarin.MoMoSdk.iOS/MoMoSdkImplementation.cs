using System;
using Foundation;
using MoMoSdkBindings.iOS;
using Xamarin.MoMoSdk.Abstractions;

namespace Xamarin.MoMoSdk
{

    public class PaymentInfo
    {
        public int Amount { get; set; }
        public int Fee { get; set; }
        public string Description { get; set; }
        public string Extra { get; set; }
        public string Language { get; set; }
        public string Username { get; set; }

        public static PaymentInfo ExamplePayment()
        {
            return new PaymentInfo
            {
                Amount = 99000,
                Fee = 0,
                Description = "Mua vé xem phim cgv",
                Extra = "{}",
                Username = "username_accountId@yahoo.com"
            };
        }

        public NSMutableDictionary ToNSMutableDictionary()
        {
            var result = NSMutableDictionary
                .FromObjectsAndKeys(
                    objects: new object[] {
                    Amount, Fee, Description, Extra, Language, Username
                },
                    keys: new object[] {
                    "amount", "fee", "description", "extra", "language", "username"
                });

            return result;
        }
    }

    public partial class MoMoSdkImplementation : IMoMoSdk
    {
        public MoMoSdkImplementation()
        {
        }

        public void Init(string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle)
        {
            MoMoPayment.ShareInstant.InitializingAppBundleId(bundleid, merchantId, merchantname, merchantNameTitle, billTitle);
            MoMoPayment.ShareInstant.RequestToken();
        }

        public void PayExample()
        {
            var paymentInfo = PaymentInfo.ExamplePayment().ToNSMutableDictionary();
            MoMoPayment.ShareInstant.InitPaymentInformation(info: paymentInfo, bundleId: "com.momo.appv2.ios",
                                                            type_environment: MomoEnvirontment.Development);
        }
    }
}
