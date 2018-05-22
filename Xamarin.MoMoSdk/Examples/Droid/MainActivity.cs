using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MoMoExample.Services;
using Xamarin.Forms;
using VN.Momo.Momo_partner;

namespace MoMoExample.Droid
{
    [Activity(Label = "MoMoExample.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            DependencyService.Get<IMoMoService>()
                             .Init(this.PackageName, "HCVN", "Home Credit Vietnam", "Home Credit App", "Payment for installments");


            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == AppMoMoLib.Instance.RequestCodeMomo && resultCode == Result.Ok)
            {
                if (data != null)
                {
                    if (data.GetIntExtra("status", -1) == 0)
                    {
                        Toast.MakeText(this,"message: " + "Get token " + data.GetStringExtra("message"), ToastLength.Short);

                        if (data.GetStringExtra("data") != null && !data.GetStringExtra("data").Equals(""))
                        {
                            // TODO:

                        }
                        else
                        {
                            Toast.MakeText(this,"message: " + this.GetString(Resource.String.not_receive_info), ToastLength.Short);
                        }
                    }
                    else if (data.GetIntExtra("status", -1) == 1)
                    {
                        String message = data.GetStringExtra("message") != null ? data.GetStringExtra("message") : "Thất bại";
                        Toast.MakeText(this,"message: " + message, ToastLength.Short);
                    }
                    else if (data.GetIntExtra("status", -1) == 2)
                    {
                        Toast.MakeText(this,"message: " + this.GetString(Resource.String.not_receive_info), ToastLength.Short);
                    }
                    else
                    {
                        Toast.MakeText(this,"message: " + this.GetString(Resource.String.not_receive_info), ToastLength.Short);
                    }
                }
                else
                {
                    Toast.MakeText(this, this.GetString(Resource.String.not_receive_info), ToastLength.Short);
                }
            }
            else
            {
                Toast.MakeText(this, this.GetString(Resource.String.not_receive_info_err), ToastLength.Short);
            }
        }
    }
}
