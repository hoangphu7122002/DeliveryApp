using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private EmployeeDAO()
        {

        }

        public string getSalaryEmp(string ssn)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.GET_SALARY_EMPLOYEE('" + ssn +"') AS SALARY");
            return data.Rows[0]["SALARY"].ToString();
        }

        public DataTable getEmployeeTable()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM EMPLOYEE");
            return data;
        }

        public bool checkInSupperSSN(string supperSSN)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT SSN FROM EMPLOYEE WHERE SuperSSN = '{0}'", supperSSN));
            if (data.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }

        public bool uniqueEID(string eid,string ssn)
        {
            DataTable dataEID = DataProvider.Instance.ExecuteQuery(string.Format("SELECT EID FROM EMPLOYEE WHERE SSN = '{0}';", ssn));
            DataTable data = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM EMPLOYEE WHERE EID = '{0}';", eid));

            string eid_emp = dataEID.Rows[0]["EID"].ToString();

            if (eid_emp == eid)
            {
                return true;
            }
            if (data.Rows.Count > 0)
            {
                return false;
            }
            
            return true;
        }

        public bool updateEmp(Employee emp)
        {
            string ssn = emp.Ssn;
            string superSSN = emp.SuperSSN;
            byte exp = emp.EXP1;
        
            string dateBegin = emp.DateBegin;
            string eid = emp.EID;

            int res = DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE EMPLOYEE SET EID = '{0}', SuperSSN = '{1}', EXP = {2}, DateBegin = '{3}' WHERE SSN = '{4}';",eid,superSSN,exp.ToString(),dateBegin,ssn)); 
           
            return res > 0;
        }

        public bool deleteEmp(string ssn)
        {
            int res = DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM EMPLOYEE WHERE SSN = '{0}'",ssn));

            return res > 0;
        }
    }
}
