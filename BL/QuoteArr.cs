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
    public class QuoteArr : ArrayList
    {
        public Quote GetQuoteWithMaxId()
        {
            //Return the coin with the highest id
            Quote maxQuote = new Quote();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Quote).Id > maxQuote.Id)
                    maxQuote = this[i] as Quote;

            return maxQuote;
        }
        public void Fill()
        {

            //Table full of quotes from dal


            DataTable dataTable = Quote_Dal.GetDataTable();

            //Move the values from the table to the QuoteArr
            //Line by line


            DataRow dataRow;
            Quote curQuote;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                
                curQuote = new Quote(dataRow);
                this.Add(curQuote);
            }
        }
        
        public void Remove(QuoteArr quoteArr)
        {

            //Remove from current coin array the given array

            for (int i = 0; i < quoteArr.Count; i++)
                this.Remove(quoteArr[i] as Quote); //Remove(): Remove from current array given coin
        }
        public void Remove(Quote quote)
        {

            //Remove from current array given coin

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Quote).Id == quote.Id)
                {
                    this.RemoveAt(i); return;
                }
            
        }
    }
}
