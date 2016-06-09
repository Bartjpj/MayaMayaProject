using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class TafelOverzichtDAO
    {

        public List<TafelOverzichtClass> haalTafelOverzicht_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT *  FROM Tafel ", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<TafelOverzichtClass> TafelOverzichtTable = new List<TafelOverzichtClass>();

            while (reader.Read())
            {
                int TafelId = (int)reader["TafelId"];
                bool Bezet = (bool)reader["Bezet"];

                TafelOverzichtClass TafelOverzichtDAO = new TafelOverzichtClass(TafelId, Bezet);
                TafelOverzichtTable.Add(TafelOverzichtDAO);
            }

            conn.Close();
            return TafelOverzichtTable;
        }


    }
}
