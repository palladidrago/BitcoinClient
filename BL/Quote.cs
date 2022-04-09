using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Data;
using Dal;


namespace BL
{
    public class Quote
    {
        //Coin Quote, for given time
        public int Id { get; set; }
        public double Price { get; set; } 
        public long Volume { get; set; } //24 hour volume
        public long MarketCap { get; set; } //In dollars
        public DateTime LastUpdated { get; set; }
        public double PercentChange { get; set; } //Percent change in 24 hours
        public Quote() { }
        public Quote(DataRow dr)
        {
            Id = (int)dr["Id"];
            Price = (double)dr["Price"];
            Volume = (long)dr["Volume"];
            MarketCap = (long)dr["MarketCap"];
            LastUpdated = DateTime.Parse(dr["LastUpdated"].ToString());
            PercentChange = (double)dr["PercentChange"];
        }

        public bool Insert()
        {
            return Quote_Dal.Insert(Price,Volume,MarketCap,LastUpdated,PercentChange);
        }
        public bool Update()
        {
            return Quote_Dal.Update(Id,Price, Volume, MarketCap, LastUpdated, PercentChange);
        }
        public bool Delete()
        {
            return Quote_Dal.Delete(Id);
        }


        public override string ToString()
        {
            return $"{Price}$"; 
        }
        //public Quote(JObject obj) {
        //    Price = (double)obj["price"];
        //    Volume = (long)obj["volume_24h"];
        //    PercentChange = (double)obj["percent_change_24h"];
        //    MarketCap = (long)obj["market_cap"];
        //    LastUpdated = DateTime.Parse((string)obj["last_updated"]);
        //}
    }
}
