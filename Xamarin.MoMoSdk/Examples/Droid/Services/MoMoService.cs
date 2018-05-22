using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using MoMoExample.Droid.Services;
using MoMoExample.Services;
using MoMoExample.Services.MoMo;
using Plugin.CurrentActivity;
using VN.Momo.Momo_partner;
using Xamarin.Forms;

[assembly: Dependency(typeof(MoMoService))]
namespace MoMoExample.Droid.Services
{

    public class MoMoParameterNamePayment
    {
        public String MERCHANT_CODE = "merchantcode";
        public String MERCHANT_NAME = "merchantname";
        public String MERCHANT_NAME_LABEL = "merchantnamelabel";
        public String AMOUNT = "amount";
        public String FEE = "fee";
        public String DESCRIPTION = "description";
        public String EXTRA = "extra";

        public String REQUEST_ID = "requestId";
        public String PARTNER_CODE = "partnerCode";
        public String EXTRA_DATA = "extraData";
        public String REQUEST_TYPE = "requestType";
        public String LANGUAGE = "language";
        public String SUBMIT_URL_WEB = "SUBMIT_URL_WEB";
    }


    public class MoMoService : MoMoParameterNamePayment, IMoMoService
    {

        string Bundleid;
        string MerchantId;
        string Merchantname;
        string MerchantNameTitle;
        string BillTitle;

        public void Init(string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle)
        {
            AppMoMoLib.Instance.SetEnvironment(AppMoMoLib.ENVIRONMENT.Production);
            this.Bundleid = bundleid;
            this.MerchantId = merchantId;
            this.Merchantname = merchantname;
            this.MerchantNameTitle = merchantNameTitle;
            this.BillTitle = billTitle;
        }

        public IDictionary<string, Java.Lang.Object> ToNSMutableDictionary(PaymentInfo paymentInfo)
        {

            //var result = NSMutableDictionary
            //.FromObjectsAndKeys(
            //    objects: new object[] {
            //    paymentInfo.Amount, paymentInfo.Fee, paymentInfo.Description, paymentInfo.Extra, paymentInfo.Language, paymentInfo.Username
            //},
            //    keys: new object[] {
            //    "amount", "fee", "description", "extra", "language", "username"
            //});

            var result = new Dictionary<string, Java.Lang.Object>
            {
                //IOS
                {AMOUNT , paymentInfo.Amount},
                {FEE , paymentInfo.Fee},
                {DESCRIPTION, paymentInfo.Description},
                {EXTRA , paymentInfo.Extra},
                {LANGUAGE , paymentInfo.Language},
                {"username" , paymentInfo.Username},

                {MERCHANT_NAME, this.Merchantname},
                {MERCHANT_CODE, this.MerchantId}
            };
            return result;
        }

        public void PayExample()
        {
            //var paymentInfo = ToNSMutableDictionary(PaymentInfo.ExamplePayment());
            //MoMoPayment.ShareInstant.InitPaymentInformation(info: paymentInfo, bundleId: "com.momo.appv2.ios",
            //                                                type_environment: MomoEnvirontment.Development);

            //MoMoPayment.ShareInstant.RequestToken();

            AppMoMoLib.Instance.SetAction(AppMoMoLib.ACTION.Payment);
            AppMoMoLib.Instance.SetActionType(AppMoMoLib.ACTION_TYPE.GetToken);

            var paymentInfo = ToNSMutableDictionary(PaymentInfo.ExamplePayment());

            AppMoMoLib.Instance.RequestMoMoCallBack(CrossCurrentActivity.Current.Activity, paymentInfo);
        }



    }
}
