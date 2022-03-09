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
    class ValidArr : ArrayList
    {
        public bool IsContains(string cityName)
        {
            //Check wether city exitst wit the sam ename
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Valid).validationMethod == cityName)
                    return true;
            return false;
        }
        public Valid GetValidWithMaxId()
        {
            //Return the city with the highest id
            Valid maxValid = new Valid();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Valid).id > maxValid.id)
                    maxValid = this[i] as Valid;

            return maxValid;
        }
        public void Fill()
        {

            //Table full of cities from dal


            DataTable dataTable = Valid_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Valid curValid;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curValid = new Valid(dataRow);
                this.Add(curValid);
            }
        }
    }
}
