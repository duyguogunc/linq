using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    //Order o1 = new Order();
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation property
        public Customer Customer { get; set; } = new Customer();

        public List<Order> GetOrders()
        {
            List<Order> liste = new List<Order>();
            string sorgu = @"
SELECT o.CustomerID, o.EmployeeID, o.OrderID, o.OrderDate,
(SELECT ContactName FROM Customers 
WHERE CustomerID = o.CustomerID) AS ContactName
FROM Orders o";
            DataTable dt = GetDataTable(sorgu);
            foreach (DataRow item in dt.Rows)
            {
                Order o = new Order();
                o.OrderID = (int)item["OrderID"]; //unboxing
                o.CustomerID = (string)item["CustomerID"];
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderDate = (DateTime)item["OrderDate"];
                o.Customer = new Customer();
                o.Customer.ContactName = item["ContactName"].ToString();
                o.Customer.CustomerID = (string)item["CustomerID"];
                liste.Add(o);
            }
            return liste;
        }

        private DataTable GetDataTable(string sorgu)
        {
            //1- Connected architecture
            //2- Disconnected architecture

            //SqlCommand
            //SqlConnection
            //SqlDataReader
            string cs = @"Data Source=WISSEN\SQLEXPRESS;
                          Initial Catalog = Northwnd;
                          User ID = Section1;
                          Trusted_Connection=true;";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }

        public List<Order> Orders { get; set; }

        public int OrderCount
        {
            get{return Orders.Count;  }
        }
    }
}
