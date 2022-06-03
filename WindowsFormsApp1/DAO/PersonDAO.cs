using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class PersonDAO
    {
        private static PersonDAO instance;

        public static PersonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private PersonDAO()
        {

        }



        public bool customerInDatabase(string ssn)
        {
            string query = "SELECT SSN FROM PERSON WHERE SSN = @ssn";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {ssn});
            return result.Rows.Count > 0;
        }
        
        public bool insertPepole(Person per)
        {
            string ssn = per.SSN1;
            string fname = per.FName;
            string lname = per.LName;
            char g = per.Gender;

            string query = "INSERT INTO PERSON VALUES( @ssn , @fname , @lname , @gender )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ssn, fname, lname, g });
            return result > 0;
        }

        public void insertPhone(Person per)
        {
            int numPhone = per.NumberPhone;
            string[] phone = per.Phone;
            string ssn = per.SSN1;
      

            string query = "INSERT INTO PERSON_PHONE VALUES ( @ssn , @phone )";
          
            for (int i = 0; i < numPhone; ++i)
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { ssn, phone[i]});
            }
        }

        public void insertMail(Person per)
        {
            int numMail = per.NumberMail;
            string[] mail = per.Mail;
            string ssn = per.SSN1;

            string query = "INSERT INTO PERSON_MAIL VALUES ( @ssn , @mail )";
            for (int i = 0; i < numMail; ++i)
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { ssn, mail[i] });
            }
        }

        public bool insertAccount(string userName, string passWord, string ssn)
        {
            string query = "EXEC InsertAccount @username , @password , @type , @ssn ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, passWord, "CUSTOMER", ssn });

            return result > 0;
        }

        public bool checkExistAccout(string account)
        {
            string query = "SELECT * FROM ACCOUNT WHERE UserName = @account";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { account });
            return dt.Rows.Count > 0;
        }

        

    }
}
