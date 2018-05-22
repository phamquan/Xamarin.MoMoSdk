using System;
namespace MoMoExample.Services
{
    public interface IMoMoService
    {
        void PayExample();
        void Init(string bundleid, string merchantId, string merchantname, string merchantNameTitle, string billTitle);
    }

    namespace MoMo
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
                    Extra = "{\"key1\":\"value1\",\"key2\":\"value2\"}",
                    Username = "username_accountId@yahoo.com",
                    Language = "vi"
                };
            }
        }

    }
}
