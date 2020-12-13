using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Serialization.Json;
using Common;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace StockFilter
{
    class Program
    {
        #region MyRegion
        static List<string> vn30 = new List<string>()
        {
            "BID",
            "BVH",
            "CTD",
            "CTG",
            "DPM",
            "EIB",
            "FPT",
            "GAS",
            "GMD",
            "HDB",
            "HPG",
            "MBB",
            "MSN",
            "MWG",
            "NVL",
            "PNJ",
            "REE",
            "ROS",
            "SAB",
            "SBT",
            "SSI",
            "STB",
            "TCB",
            "VCB",
            "VHM",
            "VIC",
            "VJC",
            "VNM",
            "VPB",
            "VRE"
        };

        static List<string> others = new List<string>()
        {
            "POW",
            "BSR"
        };
        #endregion
        static async Task Main(string[] args)
        {

            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("dangdd2@yahoo.com.vn", "Example User");
            var subject = "Sending with Twilio SendGrid is Fun";
            var to = new EmailAddress("dang.dang@episerver.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);

            return;

            var cache = new JsonSerializer();
            var fireAntClient = new FireAntClient(cache,new ErrorLogger());
            var data = new List<StockItem>();

            var intradayItems = fireAntClient.GetIntraday("SZC");

            
           
            var stockList = vn30.Union(others).Distinct();

            foreach (var symbol in stockList)
            {
                data.Add(fireAntClient.GetStockInfo(symbol));
            }
            
            
            ImportToSQLServer(data);

            Console.WriteLine(" -- DONE -- ");
            Console.ReadLine();
        }

        private static void ImportToSQLServer(List<StockItem> data)
        {
            var type = Type.GetType("StockFilter.StockItem");

            var table = new Table(type, "");
            table.Create();

            table.Insert(data);
        }
    }
}
