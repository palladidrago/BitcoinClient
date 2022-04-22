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
    class ScamArr : ArrayList
    {
        public bool IsContains(string scamLevel)
        {
            //Check wether scam level exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Scam).Name == scamLevel)
                    return true;
            return false;
        }
        public void Fill()
        {

            //Table full of scams from dal


            DataTable dataTable = Scam_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Scam curScam;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curScam = new Scam(dataRow);
                this.Add(curScam);
            }
        }
    }
}
