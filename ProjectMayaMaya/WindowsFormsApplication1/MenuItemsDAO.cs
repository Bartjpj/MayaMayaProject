using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class BestellingOpnemenDAO
    {
        //---------------------------- Begin KeukenOverzicht Connecties ------------------------------------- IVO
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

                keukenOverzichtBLL keukenOverzichtDAO = new keukenOverzichtBLL(bestelling_id, tafel_id, Menuitem, Aantal, datum_tijd, opmerking);
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
        //---------------------------- Einde KeukenOverzicht Connecties ------------------------------------- IVO


        //----------------------- Begin BAROVERZICHT CONNECTIES------------------------ IVO
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

            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, Aantal, Bestelling.datum_tijd, Menuitem.naam, opmerking FROM Bestelling, BestellingItems, Menuitem, Menucategorie, Menukaart WHERE tafel_id =  " + tafelNr + " AND bestelling_id = BestellingId AND ItemId = menu_id AND Menuitem.categorie_id = Menucategorie.categorie_id AND Menukaart.kaart_id = Menucategorie.kaart_id AND Menukaart.kaart_id = 3 AND Bestelling.bar_gereed = 0", conn);
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

            SqlCommand command = new SqlCommand("UPDATE Bestelling SET bar_gereed=1 WHERE bar_gereed = 0 AND tafel_id =" + tafelNr, conn);
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
        //----------------------- Einde BAROVERZICHT CONNECTIES------------------------ IVO






//--------------------- BestellingOpnemen Connecties ---------------------------
        public List<MenuItemsClass> haalMenuItemsOp(int categorie) // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menuitem WHERE categorie_id = " + categorie, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenuItemsClass> DinerKaartTable = new List<MenuItemsClass>();

            while (reader.Read())
            {
                int menu_id = (int)reader["menu_id"];
                int categorie_id = (int)reader["categorie_id"];
                string naam = (string)reader["naam"];
                double prijs = (double)reader["prijs"];
                int voorraad = (int)reader["voorraad"];

                MenuItemsClass DinerKaartDAO = new MenuItemsClass(menu_id, categorie_id, naam, prijs, voorraad);
                DinerKaartTable.Add(DinerKaartDAO);
            }

            conn.Close();
            return DinerKaartTable;
        }

        public List<MenukaartClass> haalKaartenOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menukaart", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenukaartClass> KaartenTable = new List<MenukaartClass>();

            while (reader.Read())
            {
                int kaart_id = (int)reader["kaart_id"];
                string naam = (string)reader["naam"];

                MenukaartClass KaartenDAO = new MenukaartClass(kaart_id, naam);
                KaartenTable.Add(KaartenDAO);
            }

            conn.Close();
            return KaartenTable;
        }


        public List<MenucategorieClass> haalCategorieOp(int kaart) // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT categorie_id, kaart_id, naam FROM Menucategorie WHERE kaart_id = " + kaart, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenucategorieClass> CategorieTable = new List<MenucategorieClass>();

            while (reader.Read())
            {
                int categorie_id = (int)reader["categorie_id"];
                int kaart_id = (int)reader["kaart_id"];
                string naam = (string)reader["naam"];

                MenucategorieClass CategorieDAO = new MenucategorieClass(categorie_id, kaart_id, naam);
                CategorieTable.Add(CategorieDAO);
            }

            conn.Close();
            return CategorieTable;
        }

        public List<int> haalIdOp()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT id FROM Bestelling", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<int> ids = new List<int>();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                ids.Add(id);
            }
            conn.Close();
            return ids;
        }

        public List<int> haalBestellingIdOp()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id FROM Bestelling", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<int> Bestellingen = new List<int>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                Bestellingen.Add(bestelling_id);
            }
            conn.Close();
            return Bestellingen;
        }





        public void VerstuurBestelling(List<int> Menu_ID, List<int> Aantal, int tafel, int BestellingID, DateTime actueleTijd, string opmerking, int personeel_id)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string sql1 = string.Format("INSERT INTO Bestelling (bestelling_id, tafel_id, kaart_id, personeel_id, datum_tijd, keuken_gereed, bar_gereed, opmerking) VALUES (" + BestellingID + ", " + tafel + ", " + 1 + ", " + 1 + ", convert(datetime, '" + actueleTijd + "', 103), " + 0 + ", " + 0 + ", '" + opmerking + "');");
            SqlCommand command = new SqlCommand(sql1, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            command.ExecuteNonQuery();

            var IDenAantal = Menu_ID.Zip(Aantal, (id, aantal) => new { Menu_ID = id, Aantal = aantal }); //maak één lijst van 2 lijsten zodat je er met één foreach doorheen kan lopen.
            foreach (var idAantal in IDenAantal)
            {
                string sql2 = string.Format("INSERT INTO BestellingItems (BestellingId, ItemId, Aantal) VALUES (" + BestellingID + ", " + idAantal.Menu_ID + ", " + idAantal.Aantal + ");");
                SqlCommand command2 = new SqlCommand(sql2, conn);
                command2.ExecuteNonQuery();

            }
            conn.Close();
        }

        public void WijzigVoorraad(int menu_id, int aantal)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Menuitem SET voorraad = voorraad - " + aantal + " WHERE menu_id = " + menu_id, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            command.ExecuteNonQuery();
            
            conn.Close();
        }



        public List<TafelOverzichtClass> haalTafelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id FROM Bestelling", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<TafelOverzichtClass> TafelTable = new List<TafelOverzichtClass>();

            while (reader.Read())
            {
                int TafelId = (int)reader["TafelId"];
                bool Bezet = (bool)reader["Bezet"];

                TafelOverzichtClass TafelTableDAO = new TafelOverzichtClass(TafelId, Bezet);
                TafelTable.Add(TafelTableDAO);
            }

            conn.Close();
            return TafelTable;
        }
    }
}


