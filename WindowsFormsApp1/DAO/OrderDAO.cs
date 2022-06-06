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
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static int OrderWidth = 105;
        public static int OrderHeight = 105;

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
            private set { instance = value; }
        }

        private OrderDAO()
        {

        }   
        
        public List<Order> loadOrderList()
        {
            List<Order> orders = new List<Order>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CORDER");
            
            foreach(DataRow row in data.Rows)
            {
                
                string orderid = row["ORDERID"].ToString();
                DataTable dataPackage = DataProvider.Instance.ExecuteQuery("EXEC GET_PACKAGE_FROM_ORDERID @orderid", new object[] { orderid });
                Order order = new Order(row, dataPackage);
                orders.Add(order);
            }

            return orders;
        }

        public Single getCost(string add,string order_id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT dbo.COST_ORDER( @add_cr , @o_id ) AS COST", new object[] { add, order_id });
            Single cost = (Single)data.Rows[0]["COST"];
            return cost;
        }
    }
}
