using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ClientApp.BL
    {
        class Valid
        {
            public string validationMethod { get; set; } // Validation method
            public int id { get; set; } //Id
            public Valid(string validationMethod, int id) { this.validationMethod = validationMethod; this.id = id; }
            public Valid() { }
            public Valid(DataRow dataRow)
            {
                this.validationMethod = dataRow["ScamLevel"].ToString();
                this.id = (int)dataRow["Id"];
            }
            public bool Insert()
            {
                return Scam_Dal.Insert(scamLevel);
            }
            public bool Delete()
            {
                return Scam_Dal.Delete(id);
            }

            public override string ToString()
            {
                return scamLevel.Trim();
            }
        }
    }

}
}
