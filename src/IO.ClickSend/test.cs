using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;
using IO.ClickSend.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.ClickSend
{
    internal class test
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration()
            {
                Username = "michael.sharich@clicksend.com",
                Password = "E2F88A51-2D55-5105-12C2-2809D24632DF"
            };
            var smsApi = new SMSApi(configuration);

            var listOfSms = new List<SmsMessage>
            {
                new SmsMessage(
                    to: "+13854996522",
                    body: "Test C# SDK",
                    source: "sdk"
                )
            };

            var smsCollection = new SmsMessageCollection(listOfSms);
            var response = smsApi.SmsSendPost(smsCollection);
            Console.WriteLine(response);

        }
    }
}
