using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;
using Newtonsoft.Json.Linq;

namespace BL
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; } //(3 letter) 
        public long Supply { get; set; } //How many coins in circualtion
        public Valid Valid { get; set; }
        public Scam Scam { get; set; }
        public int CMC_Id { get; set; } //Coin market cap id

        public string LogoUrl { get; set; }
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
            Supply = (long)dataRow["Supply"];
            Valid = new Valid(dataRow.GetParentRow("CoinValid"));
            Scam = new Scam(dataRow.GetParentRow("CoinScam"));
            CMC_Id = (int)dataRow["CMC_Id"];
            LogoUrl = dataRow["LogoUrl"].ToString();

        }
        public bool Insert()
        {
            return Coin_Dal.Insert(Name,Symbol,Supply,Valid.Id,Scam.Id,CMC_Id,LogoUrl);
        }
        public bool Update()
        {
            return Coin_Dal.Update(Id, Name, Symbol, Supply, Valid.Id, Scam.Id,CMC_Id,LogoUrl);
        }
        public bool Delete()
        {
            return Coin_Dal.Delete(Id);
        }


        public override string ToString()
        {
            if (Supply > 0) { return $"{Name.Trim()}  ({Supply} in stock)"; }
            else { return $"{Name.Trim()} (Out of stock)"; }
        }
        public bool UpdateSupply() {
            return Coin_Dal.UpdateSupply(this.Id, this.Supply);
        }

    }
}
