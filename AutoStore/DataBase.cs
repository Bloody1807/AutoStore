using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AutoStore
{
    class DataBase
    {
        SqlConnection dataBase = new SqlConnection(@"Data Source=DESKTOP-JHDTFKK\SQLEXPRESS;Initial Catalog=AutoStore;Integrated Security=True");

        public void openConnection()
        {
            if (dataBase.State == System.Data.ConnectionState.Closed)
            {
                dataBase.Open();
            }
        }

        public void closeConnection()
        {
            if (dataBase.State == System.Data.ConnectionState.Open)
            {
                dataBase.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return dataBase; 
        }

    }
}
