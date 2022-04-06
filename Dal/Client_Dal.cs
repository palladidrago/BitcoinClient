﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    class Client_Dal
    {
        public static bool Insert(string firstName, string lastName, int birthYear, string phoneNumber, double btcAmount, string btcAddress, int shoeSize,int city)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[BirthYear],[PhoneNumber],[BtcAmount],[BtcAddress],[ShoeSize],[City]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{firstName}',N'{lastName}',{birthYear},N'{phoneNumber}',{btcAmount},N'{btcAddress}',{shoeSize}, {city}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Update(int id, string firstName, string lastName, int birthYear, string phoneNumber, double btcAmount, string btcAddress, int shoeSize, int city)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"

            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[BirthYear] = {birthYear}"
            + $",[PhoneNumber] = N'{phoneNumber}'"
            + $",[BtcAmount] = {btcAmount}"
            + $",[BtcAddress] = N'{btcAddress}'"
            + $",[ShoeSize] = {shoeSize}"
            + $",[City] = {city}"
            + $" WHERE [Id] = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה

            return Dal.ExecuteSql(str);
        }
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }
        public static void FillDataSet(DataSet dataSet)
        {

            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");
            //Creating a connection
            DataRelation dataRelation = null;
            City_Dal.FillDataSet(dataSet);
            //Add data relation
            dataRelation = new DataRelation(
                "ClientCity",
                dataSet.Tables["Table_City"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["City"]);
            dataSet.Relations.Add(dataRelation);

            //Fill login dataset
            Login_Dal.FillDataSet(dataSet);
            //Create relation
            dataRelation = new DataRelation(
                "LoginCity",
                dataSet.Tables["Table_Login"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["Login"]);
            dataSet.Relations.Add(dataRelation);
        }
    }
}
