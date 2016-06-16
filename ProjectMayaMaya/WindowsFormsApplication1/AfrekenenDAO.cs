using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class AfrekenenDAO
    {
        public List<AfrekenenBLL> haalMenuItemsOp(int tafelNr) // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT tafel_id, Aantal,  Menuitem.naam, Menuitem.prijs FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND tafel_id = " + tafelNr + " AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id  AND is_betaald = 0 ", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<AfrekenenBLL> AfrekenTable = new List<AfrekenenBLL>();

            while (reader.Read())
            {

                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                double prijs = (double)reader["prijs"];
              

                AfrekenenBLL AfrekeneningDAO = new AfrekenenBLL( tafel_id, Aantal, Menuitem, prijs);
                AfrekenTable.Add(AfrekeneningDAO);
            }

            conn.Close();
            return AfrekenTable;
        }
    }
}
