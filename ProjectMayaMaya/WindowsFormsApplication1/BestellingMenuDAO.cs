using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class BestellingMenuDAO
    {
        //WORK IN PROGRESS
        public void haalBestellingMenu_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT BestellingId, Aantal, ItemId, prijs FROM BestellingItems, Menuitem WHERE ItemId = menu_id", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            int rowsAffected = command.ExecuteNonQuery();

            List<BestellingMenuConstructor> BestellingMenuTable = new List<BestellingMenuConstructor>();

            while (reader.Read())
            {
                int BestellingId = (int)reader["BestellingId"];
                int Aantal = (int)reader["Aantal"];
                int ItemId = (int)reader["ItemId"];
                int prijs = (int)reader["prijs"];

                BestellingMenuConstructor BestellingMenuDAO = new BestellingMenuConstructor(BestellingId, Aantal, ItemId, prijs);
                BestellingMenuTable.Add(BestellingMenuDAO);
            }

            conn.Close();
        }
    }
}
