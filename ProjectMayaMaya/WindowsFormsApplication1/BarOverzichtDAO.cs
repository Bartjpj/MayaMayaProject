﻿using System;
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
        public List<BarOverzichtClass> haalBarOverzicht_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND is_gereed = 0;", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
         

            List<BarOverzichtClass> BarOverzichtTable = new List<BarOverzichtClass>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                //Onderzoeken wrm dit niet werkt

                BarOverzichtClass BarOverzichtDAO = new BarOverzichtClass(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd);
                BarOverzichtTable.Add(BarOverzichtDAO);
            }
            conn.Close();
            return BarOverzichtTable;
          
        }
        public List<BarOverzichtClass> haalBestellingTafel(int tafelNr)
        {
            string connString = ConfigurationManager
           .ConnectionStrings["BestellingConnectionStringSQL"]
           .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE tafel_id =  "+ tafelNr +" AND bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();
            List<BarOverzichtClass> BarOverzichtTable = new List<BarOverzichtClass>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int Aantal = (int)reader["Aantal"];
                string Menuitem = (string)reader["naam"];
                DateTime datum_tijd = (DateTime)reader["datum_tijd"];
                //Onderzoeken wrm dit niet werkt

                BarOverzichtClass BarOverzichtDAO = new BarOverzichtClass(bestelling_id, tafel_id, Aantal, Menuitem, datum_tijd);
                BarOverzichtTable.Add(BarOverzichtDAO);
            }
            conn.Close();
            return BarOverzichtTable;
            
        }
        public void updateTafelsGereed(int tafelNr)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Bestelling SET is_gereed=1 WHERE is_gereed = 0 AND tafel_id =" + tafelNr , conn);
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

            SqlCommand command = new SqlCommand("SELECT tafel_id FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE  bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND is_gereed = 0;", conn);
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
        //public virtual void Enqueue(List<BarOverzichtClass> q)
        //{
        //    q = haalBarOverzicht_TabelOp();

        //    Queue <BarOverzichtClass> lijsFifo = new Queue<BarOverzichtClass>();

        //    lijsFifo.Enqueue(q);
        //}
    }
}
