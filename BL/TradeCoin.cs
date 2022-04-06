using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
namespace BL
{
    internal class TradeCoin
    {
        public int Id { get; set;}
        public Trade Trade { get; set; }
        public Coin Coin { get; set; }
        public long Count { get; set; }

        public TradeCoin() { }
        public TradeCoin(DataRow dr)
        {
            Id = (int)dr["ID"];
            Trade = new Trade(dr.GetParentRow("TradeCoinTrade"));
            Coin = new Coin(dr.GetParentRow("TradeCoinCoin"));
            Count = (long)dr["Count"];

        }
        public bool Insert()
        {
            return TradeCoin_Dal.Insert(Trade.Id, Coin.Id,Count);
        }
        public bool Delete()
        {
            return TradeCoin_Dal.Delete(Id);
        }
    }
}
