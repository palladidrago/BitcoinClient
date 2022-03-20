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
        public Trade trade { get; set; }
        public Coin coin { get; set; }
        public TradeCoin() { }
        public TradeCoin(DataRow dr)
        {
            trade = new Trade(dr.GetParentRow("TradeCoinTrade"));
            coin = new Coin(dr.GetParentRow("TradeCoinCoin"));
        }
        public bool Insert()
        {
            return TradeCoin_Dal.Insert(trade.id, coin.id);
        }
    }
}
