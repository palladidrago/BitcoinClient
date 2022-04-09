using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
namespace BL
{
    public class CoinQuote
    {
        public int Id { get; set; }
        public Coin Coin { get; set; }
        public Quote Quote { get; set; }

        public CoinQuote() { }
        public CoinQuote(DataRow dr)
        {
            Id = (int)dr["ID"];
            Coin = new Coin(dr.GetParentRow("CoinQuoteCoin"));
            Quote = new Quote(dr.GetParentRow("CoinQuoteQuote"));

        }
        public bool Insert()
        {
            return CoinQuote_Dal.Insert(Coin.Id, Quote.Id);
        }
        public bool Delete()
        {
            return CoinQuote_Dal.Delete(Id);
        }
    }
}
