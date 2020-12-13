using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;

namespace Common
{
    public class FireAntClient : BaseClient
    {
        private static string _baseUrl = "https://svr3.fireant.vn";
        
        public FireAntClient(ICacheService cache, IDeserializer serializer, IErrorLogger errorLogger, string baseUrl) : base(cache, serializer, errorLogger, baseUrl)
        {
        }

        public FireAntClient(IDeserializer serializer, IErrorLogger errorLogger) : base(serializer, errorLogger, _baseUrl)
        {
        }

        public StockItem GetStockInfo(string symbol)
        {
            string api = "/api/Data/Finance/LastestFinancialInfo";
            var request = new RestRequest(api, Method.GET);
            request.AddQueryParameter("symbol", symbol);

            return Get<StockItem>(request);
        }

        public List<IntraDayQuotes> GetIntraday(string symbol)
        {
            string api = "api/Data/Markets/IntradayQuotes";
            var request = new RestRequest(api, Method.GET);
            request.AddQueryParameter("symbol", symbol);

            return Get<List<IntraDayQuotes>>(request);
        }

    }
}
