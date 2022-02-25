using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    internal class Trade //INCOMPLETE: Missing order items
    {
        public int id { get; set; }
        public Client client { get; set; }
        public DateTime Date { get; set; }

        public Trade(DataRow dr) 
        {
            this.id = (int)dr["ID"];
            this.client = new Client(dr.GetParentRow("TradeClient"));
            this.Date = DateTime.Parse(dr["Date"].ToString()); //IDK IF THIS WORKS
        }
        public bool Insert()
        {
            return Trade_Dal.Insert(client.id);
        }
        public bool Delete()
        {
            return Trade_Dal.Delete(id);
        }

        public override string ToString()
        {
            return $"Client: {client.ToString().Trim()} Id: {this.id}";
        }
    }
}

