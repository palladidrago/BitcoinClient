using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BL
{
    public static class Helpers
    {
        public static string API_KEY = "c6dcc0ad-2b84-452a-886d-ed893f37375c";
        public static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        //}
        //public static int PriceOfCoin(string coin)
        //{
        //    return 
        //}

        public static JObject CMCTop20()
        {
            //Make api call to CMC
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v2/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty); //Empty string
            //Add params
            queryString["start"] = "1";
            queryString["limit"] = "20";
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string jsonString = client.DownloadString(URL.ToString());
            JObject obj = JObject.Parse(jsonString);
            JObject data = (JObject)obj["data"];
            return data;

        }
        public static JObject JObjectCoinFromSymbol(string symbol)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty); //Empty string
            //Add params
            queryString["symbol"] = symbol.ToUpper();
            queryString["convert"] = "USD";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string jsonString = client.DownloadString(URL.ToString());

            JObject obj = JObject.Parse(jsonString);
            return (JObject)obj["data"][symbol.ToUpper()][0];
        }
        public static string GetLogoURLFromCMCId(int cmc_id)
        {
            //Make api call to CMC
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v2/cryptocurrency/info");

            var queryString = HttpUtility.ParseQueryString(string.Empty); //Empty string
            //Add params
            queryString["id"] = cmc_id.ToString();

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string jsonString = client.DownloadString(URL.ToString());
            JObject obj = JObject.Parse(jsonString);
            return (string)obj["data"][$"{cmc_id}"]["logo"];

        }
        public static void SetCoinInfoFromApi(Coin c)
        {
            JObject obj = Helpers.JObjectCoinFromSymbol(c.Symbol);//Symbol is always manually entered
            c.CMC_Id = (int)obj["id"];
            c.Supply = (long)obj["total_supply"];
            c.LogoUrl = Helpers.GetLogoURLFromCMCId(c.CMC_Id);
        }
        public static CoinQuoteArr FillCoinQuoteArrFromApi(CoinArr cArr)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty); //Empty string
            //Add params

            URL.Query = queryString.ToString();
            queryString["convert"] = "USD";
            string symbols = "";
            foreach (Coin c in cArr)
            {
                symbols += c.Symbol.ToUpper()+",";
            }

            queryString["symbol"]= symbols.Remove(symbols.Length - 1); //Remove last character


            URL.Query = queryString.ToString();
            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");
            string jsonString = client.DownloadString(URL.ToString());
            JObject obj = JObject.Parse(jsonString);
            CoinQuoteArr newCoinQuoteArr = new CoinQuoteArr();
            foreach (Coin c in cArr)
            {
                Quote newQuote = new Quote();
                JObject curObj = (JObject)obj["data"][c.Symbol.ToUpper()][0]["quote"]["USD"];
                newQuote.Price = (double)curObj["price"];
                newQuote.Volume = (long)curObj["volume_24h"];
                newQuote.PercentChange = (double)curObj["percent_change_24h"];
                newQuote.MarketCap = (long)curObj["market_cap"];
                newQuote.LastUpdated = DateTime.Parse((string)curObj["last_updated"]);
                newQuote.Insert();

                QuoteArr qArr = new QuoteArr();
                qArr.Fill();
                newQuote = qArr.GetQuoteWithMaxId();


                CoinQuote cqNew = new CoinQuote();
                cqNew.Coin = c;
                cqNew.Quote = newQuote;
                newCoinQuoteArr.Add(cqNew);

            }
            return newCoinQuoteArr;
        }

    }
}
