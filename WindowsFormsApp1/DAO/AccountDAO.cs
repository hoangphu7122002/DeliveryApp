using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { 
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance; 
            }
            private set { instance = value; }
        }

        private AccountDAO()
        {

        }   

        public bool Login(string username, string password)
        {
            string query = "EXEC LOGIN_ACCOUNT @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ username,password});


            return result.Rows.Count > 0;
        }

        public bool updateAccount(string username, string password, string newpassword)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdateAccount @username , @password , @newPassword", new object[] { username, password, newpassword });
            return result > 0;
        }

        public Account getAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT WHERE UserName = '" + username + "'");
            DataTable result = DataProvider.Instance.ExecuteQuery("EXEC GET_DISPLAY_NAME @username",new object[] {username});

            string name = "";
            foreach (DataRow row in result.Rows)
            {
                name = row["NAME"].ToString();
                break;
            }

            if (name == "")
            {
                return null;
            }

            foreach (DataRow item in data.Rows)
            {
                return new Account(item,name);
            }
            return null;
        }
    }
}
