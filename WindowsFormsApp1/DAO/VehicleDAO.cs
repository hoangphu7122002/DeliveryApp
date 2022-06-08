using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    public class VehicleDAO
    {
        private static VehicleDAO instance;

        public static VehicleDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VehicleDAO();
                }
                return instance;
            }
            private set { instance = value; }

        }
        
        public DataTable getVehicle(string driverSSN)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT VNUM FROM DRIVES ='" + driverSSN + "'");
            return data;
        }

        public DataTable getVehicleTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM VEHICLE");
        }
    }
}
