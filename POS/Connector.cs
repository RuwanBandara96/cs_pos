using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POS
{
    class Connector
    {
        private MySqlConnection conn;

        public Connector()
        {
            ConnectDatabase();
        }

        private void ConnectDatabase()
        {
            String connectionString = "server=localhost;user=root;database=pos_cs;port=3306;password=gayanu.amb";
            conn = new MySqlConnection(connectionString);
        }

        public MySqlDataReader ReadDatabaseData(String sqlString)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sqlString, conn);
                return cmd.ExecuteReader();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public int InsetDelteUpdate(String sql_str)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql_str, conn);
                return cmd.ExecuteNonQuery()
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
