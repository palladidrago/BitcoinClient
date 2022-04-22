using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dal
{
    class Client_Dal
    {
        public static bool Insert(string firstName, string lastName, int birthYear, string mail, double btcAmount, string btcAddress,int country,int login)
        {
            //Add client to database

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[BirthYear],[Mail],[BtcAmount],[BtcAddress],[Country],[Login]"
            + ")"
            + " VALUES "
            + "("
            + $"N'{firstName}',N'{lastName}',{birthYear},N'{mail}',{btcAmount},N'{btcAddress}', {country},{login}"
            + ")";
            //Return success
            return Dal.ExecuteSql(str);
        }
        public static bool Update(int id, string firstName, string lastName, int birthYear, string mail, double btcAmount, string btcAddress, int country,int login)
        {

            //Update client in database

            string str = "UPDATE Table_Client SET"

            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[BirthYear] = {birthYear}"
            + $",[Mail] = N'{mail}'"
            + $",[BtcAmount] = {btcAmount}"
            + $",[BtcAddress] = N'{btcAddress}'"
            + $",[Country] = {country}"
            + $",[Login] = {login}"
            + $" WHERE [Id] = {id}";
            //Return success
            return Dal.ExecuteSql(str);
        }
        public static bool Delete(int id)
        {
            //Delete the client from database
            string str = $"DELETE FROM Table_Client WHERE ID = {id}";

            //Return success

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
            Country_Dal.FillDataSet(dataSet);
            //Add data relation
            dataRelation = new DataRelation(
                "ClientCountry",
                dataSet.Tables["Table_Country"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["Country"]);
            dataSet.Relations.Add(dataRelation);

            //Fill login dataset
            Login_Dal.FillDataSet(dataSet);
            //Create relation
            dataRelation = new DataRelation(
                "ClientLogin",
                dataSet.Tables["Table_Login"].Columns["Id"],
                dataSet.Tables["Table_Client"].Columns["Login"]);
            dataSet.Relations.Add(dataRelation);
        }
    }
}
