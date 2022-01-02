using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClientApp.BL
{
    class Scam
    {
        public string scamLevel { get; set; }
        public int id { get; set; }
        public Scam(string scamLevel, int id) { this.scamLevel = scamLevel; this.id = id; }
        public Scam() { }
        public Scam(DataRow dataRow)
        {
            this.scamLevel = dataRow["ScamLevel"].ToString();
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
