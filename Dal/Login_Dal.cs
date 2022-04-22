using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    class Login_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Login"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {
            if (!dataSet.Tables.Contains("Table_Login"))
            {
                Dal.FillDataSet(dataSet, "Table_Login","[Username]");

            }

        }
        public static bool Insert(string username,string passwordHash, bool isAdmin)
        {
            string sql = $"INSERT INTO Table_Login ([Username],[PasswordHash],[IsAdmin]) VALUES ('{username}','{passwordHash}',{(isAdmin ? 1 : 0)})";
            return Dal.ExecuteSql(sql);
        }
        public static bool Delete(int id)
        {

            //Delete the login from database

            string str = "DELETE FROM Table_Login WHERE ID = " + id;

            //Run the command and return result

            return Dal.ExecuteSql(str);
        }
        public static bool Update(int id, string username, string passwordHash, bool isAdmin)
        {
            //Update the Coin in database

            string str = "UPDATE Table_Login SET"

            + $" [Username] = '{username}'"
            + $",[PasswordHash] = '{passwordHash}'"
            + $",[IsAdmin] = {(isAdmin ? 1 : 0)}"
            + $" WHERE [Id] = {id}";
            //Return if success
            return Dal.ExecuteSql(str);
        }

    }
}
