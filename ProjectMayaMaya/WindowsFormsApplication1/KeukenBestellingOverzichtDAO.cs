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
//---------------------------- Begin KeukenOverzicht Connecties -------------------------------------
        public List<keukenOverzichtBLL> haalKeukenBestelling_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3 AND keuken_gereed = 0;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<keukenOverzichtBLL> KeukenOverzichTable = new List<keukenOverzichtBLL>(); // maakt lijst van keukenOverzichtBLL om vervolgens het object te vullen

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];

                keukenOverzichtBLL KeukenOverzichtDAO = new keukenOverzichtBLL(bestelling_id, tafel_id, Menuitem, Aantal, datum_tijd, opmerking);
                KeukenOverzichTable.Add(KeukenOverzichtDAO);
            }

            conn.Close();
            return KeukenOverzichTable;
        }
      
        public List<keukenOverzichtBLL> haalDagKeukenBestelling() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3 AND keuken_gereed = 1;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<keukenOverzichtBLL> KeukenOverzichTable = new List<keukenOverzichtBLL>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                string Menuitem = (string)reader["naam"];
                int Aantal = (int)reader["Aantal"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];

                keukenOverzichtBLL KeukenOverzichtDAO = new keukenOverzichtBLL(bestelling_id, tafel_id, Menuitem, Aantal, datum_tijd, opmerking);
                KeukenOverzichTable.Add(KeukenOverzichtDAO);
            }

            conn.Close();
            return KeukenOverzichTable;
        }

        public List<keukenOverzichtBLL> haalBestellingTafel(int tafelNr)
        {
            string connString = ConfigurationManager
           .ConnectionStrings["BestellingConnectionStringSQL"]
           .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE tafel_id =  " + tafelNr + " AND bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id != 3 AND Bestelling.keuken_gereed = 0", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            List<keukenOverzichtBLL> KeukenOverzichtTable = new List<keukenOverzichtBLL>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];
                //Onderzoeken wrm dit niet werkt

                keukenOverzichtBLL keukenOverzichtDAO = new keukenOverzichtBLL(bestelling_id, tafel_id,  Menuitem, Aantal, datum_tijd, opmerking);
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
        //---------------------------- Begin KeukenOverzicht Connecties -------------------------------------
    }
}