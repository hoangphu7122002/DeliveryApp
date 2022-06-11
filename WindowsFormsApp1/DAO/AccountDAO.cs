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

        public DataTable getAccountTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM ACCOUNT");
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

        public string getIDBySSN(string ssn)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT ID FROM ACCOUNT WHERE SSN = '{0}'",ssn));
            return data.Rows[0]["ID"].ToString();
        }

        public bool checkINDB(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM ACCOUNT WHERE ID = '{0}'", id));
            return data.Rows.Count > 0;
        }

        public bool UpdateAccount(string ssn, string id, string type)
        {
            return DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE ACCOUNT SET ID = '{0}', ATYPE = '{1}' WHERE SSN = '{2}'", id, type, ssn)) > 0;
        }

        public bool deleteAccount(string ssn)
        {
            return DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM ACCOUNT WHERE SSN = '{0}'",ssn)) > 0;
        }
    }
}
