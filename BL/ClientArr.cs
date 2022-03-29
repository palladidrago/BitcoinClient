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
    public class ClientArr : ArrayList
    {
        public ClientArr Filter(string lastName="",string btcAddress = "")
        {
            ClientArr clientArr = new ClientArr();
            Client client;
            for (int i = 0; i < this.Count; i++)
            {


                client = (this[i] as Client);
                if
                (client.LastName.ToLower().StartsWith(lastName.ToLower()) &&
                client.BtcAddress.Contains(btcAddress))

                    clientArr.Add(client);
            }
            return clientArr;
        }
        public bool DoesExist(City curCity)
        {

            //מחזירה האם לפחות לאחד מהלקוחות יש את היישוב

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Client).city.Id == curCity.Id)
                    return true;

            return false;
        }
        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות


            DataTable dataTable = Client_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Client curClient;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curClient = new Client(dataRow);
                this.Add(curClient);
            }
        }
    }
}
