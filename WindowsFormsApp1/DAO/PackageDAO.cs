using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    public class PackageDAO
    {
        private static PackageDAO instance;

        public static PackageDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PackageDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private PackageDAO()
        {

        }

        public List<Package> loadPackageList(string orderid)
        {

            List<Package> packages = new List<Package>();

            DataTable dataPackage = DataProvider.Instance.ExecuteQuery("EXEC GET_PACKAGE_FROM_ORDERID @orderid", new object[] { orderid });

            foreach (DataRow row in dataPackage.Rows)
            {
                Package package = new Package(row);
                packages.Add(package);
            }

            return packages;
        }
    }
}
