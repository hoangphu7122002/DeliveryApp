using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
