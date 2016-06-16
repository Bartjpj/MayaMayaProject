using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace WindowsFormsApplication1
{
    public class BarOverzichtDAO
    {
        public List<BarOverzichtBLL> haalBarOverzicht_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND bar_gereed = 0;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
         

            List<BarOverzichtBLL> BarOverzichtTable = new List<BarOverzichtBLL>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];
                //Onderzoeken wrm dit niet werkt

                BarOverzichtBLL BarOverzichtDAO = new BarOverzichtBLL(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd, opmerking);
                BarOverzichtTable.Add(BarOverzichtDAO);
            }
            conn.Close();
            return BarOverzichtTable;
          
        }

        public List<BarOverzichtBLL> haalDagBarOverzicht() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND bar_gereed = 1;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();


            List<BarOverzichtBLL> BarOverzichtTable = new List<BarOverzichtBLL>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];
                //Onderzoeken wrm dit niet werkt

                BarOverzichtBLL BarOverzichtDAO = new BarOverzichtBLL(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd, opmerking);
                BarOverzichtTable.Add(BarOverzichtDAO);
            }
            conn.Close();
            return BarOverzichtTable;

        }

        public List<BarOverzichtBLL> haalBestellingTafel(int tafelNr)
        {
            string connString = ConfigurationManager
           .ConnectionStrings["BestellingConnectionStringSQL"]
           .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE tafel_id =  "+ tafelNr +" AND bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            List<BarOverzichtBLL> BarOverzichtTable = new List<BarOverzichtBLL>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                string opmerking = (string)reader["opmerking"];

                //Onderzoeken wrm dit niet werkt

                BarOverzichtBLL BarOverzichtDAO = new BarOverzichtBLL(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd, opmerking);
                BarOverzichtTable.Add(BarOverzichtDAO);
            }
            conn.Close();
            return BarOverzichtTable;
            
        } // haal de bestelling op per tafel

        public void updateTafelsGereed(int tafelNr)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Bestelling SET bar_gereed=1 WHERE bar_gereed = 0 AND tafel_id =" + tafelNr , conn);
            command.ExecuteNonQuery();

            conn.Close();
        } // als een tafel gereed wordt gemeld, zorgt deze methode ervoor dat hij in de database wordt geupdate

        public List<int> haalTafelNrOp() // hier worden de tafelnrs uit de database opgehaald
        {
            string connString = ConfigurationManager
                .ConnectionStrings["BestellingConnectionStringSQL"]
                .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT tafel_id FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND bar_gereed = 0;", conn);
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

        //public List<BarOverzichtClass> dagBarOverzicht()
        //{
        //    string connString = ConfigurationManager
        //   .ConnectionStrings["BestellingConnectionStringSQL"]
        //   .ConnectionString;
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();

        //    SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND Bestelling.is_gereed = 1", conn);
        //    // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
        //    SqlDataReader reader = command.ExecuteReader();
        //    List<BarOverzichtClass> BarOverzichtTable = new List<BarOverzichtClass>();

        //    while (reader.Read())
        //    {
        //        int bestelling_id = (int)reader["bestelling_id"];
        //        int tafel_id = (int)reader["tafel_id"];
        //        int Aantal = (int)reader["Aantal"];
        //        string Menuitem = (string)reader["naam"];
        //        DateTime datum_tijd = (DateTime)reader["datum_tijd"];
        //        //Onderzoeken wrm dit niet werkt

        //        BarOverzichtClass BarOverzichtDAO = new BarOverzichtClass(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd);
        //        BarOverzichtTable.Add(BarOverzichtDAO);
        //    }
        //    conn.Close();
        //    return BarOverzichtTable;

        //}
    }
}
