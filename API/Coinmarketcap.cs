using System;
using System.Net;
using System.Web;

namespace API
{
    /// <summary>
    /// Инфо о топовых криптовалютах в формате json
    /// </summary>
    class Coinmarketcap
    {
        private static string API_KEY = "273a2a84-04c6-443c-ac36-f4d94ee75d7a";
        void Enter()
        {
            try
            {
                Console.WriteLine(makeAPICall());
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// limit - количество показываемых криптовалют
        /// </summary>
        /// <returns></returns>
        static string makeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "100";
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            return client.DownloadString(URL.ToString());
        }
    }
}
