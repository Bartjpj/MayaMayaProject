using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class TafelDAO
    {
        public void haalBestellingOp()
        {

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlConnection connectie = new SqlConnection(connString);
            connectie.Open();

            string sql = String.Format("INSERT INTO Tafel(tafel_id, bezet)" + " values({0},{1})", 3, 1);
            SqlCommand command = new SqlCommand(sql, connectie);
            int rowsAffected = command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader(); // datareaderobject

            connectie.Close();

        }
    }
}
