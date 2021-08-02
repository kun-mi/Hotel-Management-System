using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotelManagementSystem
{
    class USER
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root; password= melanogasta; database=hotel");

        public MySqlConnection getconnection
        {
            get
            {
                return connection;
            }
        }

        public void openconnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeconnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
