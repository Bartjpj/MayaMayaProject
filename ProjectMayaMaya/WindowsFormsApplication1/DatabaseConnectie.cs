using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class DatabaseConnectie
    {
        public void testSQL()
        {
            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString); // connectieobject wordt aangemaakt

            conn.Open();   // connectie wordt opengezet 

            SqlCommand command = new SqlCommand();
            SqlDataReader reader = command.ExecuteReader(); // datareaderobject

            while (reader.Read())
            {

            }

            conn.Close();

        }
       
    }
}
