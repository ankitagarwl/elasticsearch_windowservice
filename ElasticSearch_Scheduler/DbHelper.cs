using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ElasticSearchScheduler
{
  public   class DbHelper
    {
        static public SqlConnection CreateConnection()
        {
            string connectionString = "Data Source = 192.168.0.11; Initial Catalog = MonitoringIntelligence; User ID = sa; Password = ad#ujjwal";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }


    }
}
