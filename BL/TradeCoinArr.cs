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
    class TradeCoinArr : ArrayList
    {

        public void Fill()
        {
            //Table full of TradeCoin from dal


            DataTable dataTable = TradeCoin_Dal.GetDataTable();

            //Move the values from the table to the TradeCoinArr
            //Line by line

            DataRow dataRow;
            TradeCoin curTradeCoin;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curTradeCoin = new TradeCoin(dataRow);
                this.Add(curTradeCoin);
            }
        }
        public bool Insert()
        {

            // מוסיפה את אוסף המוצרים להזמנה למסד הנתונים

            TradeCoin tradeCoin = null;
            for (int i = 0; i < this.Count; i++)
            {
                tradeCoin = (this[i] as TradeCoin);
                if (!tradeCoin.Insert())
                    return false;
            }
            return true;
        }
    }
}
