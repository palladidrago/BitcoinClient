using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Dal;

namespace BL
{
    public class CoinQuoteArr : ArrayList
    {
        public void Fill()
        {
            //Table full of CoinQuote from dal


            DataTable dataTable = CoinQuote_Dal.GetDataTable();

            //Move the values from the table to the CoinQuoteArr
            //Line by line

            DataRow dataRow;
            CoinQuote curCoinQuote;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCoinQuote = new CoinQuote(dataRow);
                this.Add(curCoinQuote);
            }
        }
        public CoinQuoteArr Filter(Quote q)
        {
            //Filter CoinQuoteArr by trade and return a CoinQuoteArr
            CoinQuoteArr cqArrNew = new CoinQuoteArr();
            if (q == null) return cqArrNew; //If q is null return empty CoinQuoteArr
            for (int i = 0; i < this.Count; i++)
            {
                if (q.Id == (this[i] as CoinQuote).Quote.Id) cqArrNew.Add(this[i]);
            }
            return cqArrNew;
        }
        public CoinQuoteArr Filter(Coin c) //Polymorphism :)
        {
            CoinQuoteArr cqArrNew = new CoinQuoteArr();
            if (c == null) return cqArrNew;

            for (int i = 0; i < this.Count; i++)
            {
                if (c.Id == (this[i] as CoinQuote).Coin.Id) cqArrNew.Add(this[i]);
            }
            return cqArrNew;
        }
        
       
        public Quote LatestQuote(Coin c)
        {
            //Returns latest quote for given coin
            CoinQuoteArr cqArr = Filter(c);
            Quote latestQ = new Quote();

            latestQ.LastUpdated = DateTime.MinValue; //Start from smallest value
            Quote curQ;
            foreach (CoinQuote cq in cqArr)
            {
                curQ = cq.Quote;
                if (curQ.LastUpdated.Date > latestQ.LastUpdated.Date) latestQ = curQ;
            }
            return latestQ;
        }
        public bool IsCoinIn(Coin c)
        {
            foreach (CoinQuote cq in this)
            {
                if (cq.Coin.Id == c.Id) return true;
            }
            return false;
        }
        public CoinArr GetCoinArr()
        {

            //Return all the coins from the current CoinQuoteArr

            CoinArr coinArr = new CoinArr();
            for (int i = 0; i < this.Count; i++)
                coinArr.Add((this[i] as CoinQuote).Coin);
            return coinArr;
        }
        public QuoteArr GetQuoteArr()
        {

            //Return all the quotes from the current CoinQuoteArr

            QuoteArr quoteArr = new QuoteArr();
            for (int i = 0; i < this.Count; i++)
                quoteArr.Add((this[i] as CoinQuote).Quote);
            return quoteArr;
        }
        public bool Insert()
        {

            // Add coins from client to database
            CoinQuote CoinQuote = null;
            for (int i = 0; i < this.Count; i++)
            {
                CoinQuote = (this[i] as CoinQuote);
                if (!CoinQuote.Insert())
                    return false;
            }
            return true;
        }
        public bool Delete()
        {

            //Delete this CoinQuoteArr from database

            for (int i = 0; i < this.Count; i++)
                (this[i] as CoinQuote).Delete();
            return true;
        }
    }
}
