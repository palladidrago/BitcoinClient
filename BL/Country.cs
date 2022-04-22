using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;

namespace BL
{
    public class Country
    {
        public string Name { get; set; } //Name of the Country
        public int Id { get; set; } //Id of the Country
        public Country (string Name)
        {
            this.Name = Name;
        }
        public Country() { }
        public Country (DataRow dataRow)
        {
            this.Name = dataRow["Name"].ToString();
            this.Id = (int)dataRow["Id"];
        }
        public bool Insert()
        {
            return Country_Dal.Insert(Name);
        }
        public bool Delete()
        {
            return Country_Dal.Delete(Id);
        }
    
        public override string ToString()
        {
            return Name.Trim();
        }
    }
}
