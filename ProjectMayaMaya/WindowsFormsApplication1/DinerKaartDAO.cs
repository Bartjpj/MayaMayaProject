using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DinerKaartDAO
    {
        public void haalDinerKaart_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Menuitem.naam FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            int rowsAffected = command.ExecuteNonQuery();

            List<DinerKaartClass> DinerKaartTable = new List<DinerKaartClass>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["Menuitem.naam"];
                //Onderzoeken wrm dit niet werkt

                DinerKaartClass DinerKaartDAO = new DinerKaartClass(bestelling_id, tafel_id, Aantal, Menuitem);
                DinerKaartTable.Add(DinerKaartDAO);
            }

            conn.Close();
        }
    }
}
