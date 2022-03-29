using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    public class Trade 
    {
        public int Id { get; set; } // Id of the trade
        public Client Client { get; set; } //Client that owns the trade
        public DateTime Date { get; set; } //Time the trade was created
        public string Memo { get; set; } //Memo for the trade
        public Trade() { }
        public Trade(DataRow dr) 
        {
            this.Id = (int)dr["ID"];
            this.Client = new Client(dr.GetParentRow("TradeClient"));
            
            this.Date = DateTime.Parse(dr["Date"].ToString()); //IDK IF THIS WORKS
            this.Memo = dr["Memo"].ToString();
        }
        public bool Insert()
        {
            return Trade_Dal.Insert(Client.Id,Date,Memo);
        }
        public bool Delete()
        {
            return Trade_Dal.Delete(Id);
        }
        public bool Update()
        {
            return Trade_Dal.Update(Id,Client.Id,Date);
        }
        public override string ToString()
        {
            return $"Client: {Client.ToString().Trim()} Id: {this.Id}";
        }
    }
}

