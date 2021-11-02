﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Dal
{
    class Dal
    {
        public static bool ExecuteSql(string sql)
        {
            //מקשר
            SqlConnection connection = new SqlConnection();
            //הצבת מחרוזת הקישור במקשר - שימוש בפעולת עזר למציאת מחרוזת זאת
            connection.ConnectionString = GetConnectionString();


            //ההוראה
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            //בגלל שיש גישה לקבצים חיצוניים וכן בגלל פתיחת קשר לקובץ חיצוני - "עוטפים" במנגנון טיפול בשגיאות"
            try
            {
                //Open the connection
                connection.Open();

                //Run the command
                command.ExecuteNonQuery();

                //Close the connection
                connection.Close();

                return true;
            }
            catch (Exception e)
            {
                //משמש רק לצרכי בקרה במקרה של תקלה - חשוב להשאיר כאן נקודת עצירה
                e.ToString();
            }

            return false;
        }

        public static void FillDataSet(DataSet dataSet, string tableName, string orderBy = "")
        {
            //מקשר

            //using System.Data.SqlClient;

            SqlConnection connection = new SqlConnection();
            //הצבת מחרוזת הקישור במקשר
            connection.ConnectionString = GetConnectionString();

            //מבצע פעולה
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            if (orderBy != "")
                command.CommandText = "SELECT * FROM " + tableName + " ORDER BY " + orderBy;
            else
                command.CommandText = "SELECT * FROM " + tableName;

            //מתאם
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataSet, tableName);
        }

        private static string GetConnectionString()
        {
            //בניית מחרוזת הקישור
            SqlConnectionStringBuilder cString = new SqlConnectionStringBuilder();

            cString.DataSource = @"(localdb)\.";
            cString.AttachDBFilename = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Project_Database.mdf";


            return cString.ToString();
        }
    }
}