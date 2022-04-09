using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Dal;
using System.Data;

namespace BL
{
    public class LoginArr : ArrayList
    {

        public void Fill()
        {

            //Table full of logins from dal


            DataTable dataTable = Login_Dal.GetDataTable();

            //Move the values from the table to the LoginArr
            //Line by line


            DataRow dataRow;
            Login curLogin;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curLogin = new Login(dataRow);
                this.Add(curLogin);
            }
        }
        public bool IsUsernameExists(string username)
        {
            foreach (Login l in this) if (l.Username == username) return true;  return false; //One liner :)
        }
        public Login Auth(string username, string passwordHash)
        {
            Login login;

            for (int i = 0; i < this.Count; i++)
            {

                //Add the current coin to helper var

                login = (this[i] as Login);
                if (
                //Auth username

                (login.Username == username)

                //Auth password
                && (passwordHash == login.PasswordHash)

                )
                    //If login is valid, return

                    return login;
            }
            return null; //Return null if no matches
        }
        public void Remove(Login login)
        {

            //Remove from current array given login

            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Login).Id == login.Id)
                {
                    this.RemoveAt(i); return;
                }

        }
        public Login GetLoginWithMaxId()
        {
            //Return the coin with the highest id
            Login maxLogin = new Login();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Login).Id > maxLogin.Id)
                    maxLogin = this[i] as Login;

            return maxLogin;
        }
    }
}
