using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dal;


namespace BL
    {
        public class Valid
        {
            public string Name { get; set; } // Validation method
            public int Id { get; set; } //Id
            public Valid(string Name, int id) { this.Name = Name; this.Id = Id; }
            public Valid() { }
            public Valid(DataRow dataRow)
            {
                this.Name = dataRow["Name"].ToString().Trim();
                this.Id = (int)dataRow["Id"];
            }
            public bool Insert()
            {
                return Valid_Dal.Insert(Name);
            }
            public bool Delete()
            {
                return Valid_Dal.Delete(Id);
            }

            public override string ToString()
            {
                return Name.Trim();
            }
        }
}
