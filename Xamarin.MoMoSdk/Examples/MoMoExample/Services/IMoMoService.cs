using System;
namespace MoMoExample.Services
{
    public interface IMoMoService
    {
        void PayExample();
        void Init(string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle);
	}
}
