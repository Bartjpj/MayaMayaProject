using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
  public  class keukenBestellingOverzichtDAO
    {
        public List<keukenOverzichtClass> haalKeukenBestelling_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3 AND keuken_gereed = 0;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<keukenOverzichtClass> KeukenOverzichTable = new List<keukenOverzichtClass>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];

                keukenOverzichtClass KeukenOverzichtDAO = new keukenOverzichtClass(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd, opmerking);
                KeukenOverzichTable.Add(KeukenOverzichtDAO);
            }

            conn.Close();
            return KeukenOverzichTable;
        }

        public List<keukenOverzichtClass> haalBestellingTafel(int tafelNr)
        {
            string connString = ConfigurationManager
           .ConnectionStrings["BestellingConnectionStringSQL"]
           .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE tafel_id =  " + tafelNr + " AND bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            List<keukenOverzichtClass> KeukenOverzichtTable = new List<keukenOverzichtClass>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];
                //Onderzoeken wrm dit niet werkt

                keukenOverzichtClass keukenOverzichtDAO = new keukenOverzichtClass(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd, opmerking);
                KeukenOverzichtTable.Add(keukenOverzichtDAO);
            }
            conn.Close();
            return KeukenOverzichtTable;

        }

        public void updateTafelsGereed(int tafelNr)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Bestelling SET keuken_gereed=1 WHERE keuken_gereed = 0 AND tafel_id =" + tafelNr, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }

        public List<int> haalTafelNrOp()
        {
            string connString = ConfigurationManager
                .ConnectionStrings["BestellingConnectionStringSQL"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT tafel_id FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3 AND keuken_gereed = 0;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            List<int> TafelNummers = new List<int>();

            while (reader.Read())
            {

                int tafel_id = (int)reader["tafel_id"];

                TafelNummers.Add(tafel_id);
            }
            conn.Close();
            return TafelNummers;

        }
    }
}