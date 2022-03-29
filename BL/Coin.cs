using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    public class Coin
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Symbol { get; set; }
        public Valid Valid { get; set; }
        public Scam Scam { get; set; }
        public Coin() { }
        public Coin(string Name, int Id)
        {
            this.Id = Id;
            this.Name = Name;
            this.Valid = new Valid();
            this.Scam = new Scam();
        }
        public Coin(DataRow dataRow)
        {
            Id = (int)dataRow["id"];
            Name = dataRow["Name"].ToString().Trim();
            Symbol = dataRow["Symbol"].ToString().Trim();

            Valid = new Valid(dataRow.GetParentRow("CoinValid"));
            Scam = new Scam(dataRow.GetParentRow("CoinScam"));

        }
        public bool Insert()
        {
            return Coin_Dal.Insert(Name,Symbol,Valid.Id,Scam.Id);
        }
        public bool Delete()
        {
            return Coin_Dal.Delete(Id);
        }


        public override string ToString()
        {
            return Name.Trim();
        }
    }
}
