using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class DriverDAO
    {
        private static DriverDAO instance;

        public static DriverDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DriverDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private DriverDAO()
        {

        }

        public string getSalary(string ssnDriver)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.GET_SALARY_DRIVER('" + ssnDriver + "') AS SALARY)");
            return data.Rows[0]["SALARY"].ToString();
        }

        public DataTable getDriverTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM DRIVER");
        }
    }
}
