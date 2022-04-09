using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Dal;

namespace BL {
    public class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }   // Sha256
        public bool IsAdmin { get; set; }
        public Login() { }
        public Login(DataRow dr)
        {
            Id = (int)dr["Id"];
            Username = dr["Username"].ToString();
            PasswordHash = dr["passwordHash"].ToString();
            IsAdmin = dr["isAdmin"].ToString() == "True";
        }
        public bool Insert()
        {
            return Login_Dal.Insert(Username, PasswordHash, IsAdmin);
        }
        public bool Update()
        {
            return Login_Dal.Update(Id, Username, PasswordHash, IsAdmin);
        }
        public bool Delete()
        {
            return Login_Dal.Delete(Id);
        }

        public override string ToString()
        {
            return Username.Trim();
        }
    }
}
