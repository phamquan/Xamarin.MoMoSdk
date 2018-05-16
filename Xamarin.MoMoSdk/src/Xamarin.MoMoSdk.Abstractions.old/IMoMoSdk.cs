using System;
namespace Xamarin.MoMoSdk.Abstractions
{
    public interface IMoMoSdk
    {
        void Init();
        void Init(string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle);
        void PayExample();
    }
}
