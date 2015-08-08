using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=mssql02.qsh.eu,1481;Initial Catalog = db1002584-storyhub; Persist Security Info=True;User ID = db1002584-storyhub; Password=HubityHub153");
            conn.Open();
        }
    }
}
