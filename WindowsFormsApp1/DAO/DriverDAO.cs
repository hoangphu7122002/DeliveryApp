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

        public bool deleteDriver(string ssn)
        {
            return DataProvider.Instance.ExecuteNonQuery(string.Format("DELETE FROM DRIVER WHERE SSN = '{0}'", ssn)) > 0;
        }

        public bool updateDriverVehicle(Driver driver, Vehicle vehicle)
        {
            string ssn = driver.Ssn;
            string lisenceID = driver.LisenceID;
            byte exp = driver.Exp;

            string vnum = vehicle.Vnum;
            string rnum = vehicle.Rnum;
            string type = vehicle.Vtype;

            DataTable dataLisenceID = DataProvider.Instance.ExecuteQuery(string.Format("SELECT LICENSE_ID FROM DRIVER WHERE SSN = '{0}'", ssn));
            DataTable dataRnumID = DataProvider.Instance.ExecuteQuery(string.Format("SELECT RNUM FROM VEHICLE WHERE VNUM = '{0}'", vnum));

            bool flagLisenceID = dataLisenceID.Rows[0]["LICENSE_ID"].ToString() == lisenceID;
            bool flagDataRnumID = dataRnumID.Rows[0]["RNUM"].ToString() == rnum;
            bool isUniqueLisenceID = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM DRIVER WHERE LICENSE_ID = '{0}'", lisenceID)).Rows.Count == 0;
            bool isRnumID = DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM VEHICLE WHERE RNUM = '{0}'", rnum)).Rows.Count == 0;

            bool validLID = false;
            bool validRnum = false;
            if (flagLisenceID || isUniqueLisenceID)
            {
                validLID = true;
            }
            if (flagDataRnumID || isRnumID)
            {
                validRnum = true;
            }
            if (validLID & validRnum == false)
            {
                MessageBox.Show("HERE1!!");
                return false;
            }
            else
            {
                bool updateVehicle = DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE VEHICLE SET RNUM = '{0}', VTYPE = '{1}' WHERE VNUM = '{2}';", rnum, type,vnum)) > 0;
                bool updateDriver = DataProvider.Instance.ExecuteNonQuery(string.Format("UPDATE DRIVER SET LICENSE_ID = '{0}', EXP = {1} WHERE SSN = '{2}';", lisenceID, exp.ToString(), ssn)) > 0;
                
                return updateVehicle & updateDriver;   
            }

            return true;
        }
    }
}
