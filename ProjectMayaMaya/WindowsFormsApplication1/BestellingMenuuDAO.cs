using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class BestellingMenuDAO
    {
      

        public BestellingMenuDAO(){
 

        }
        
        
        public  List<BestellingMenuClass> getAllBestellingen() // deze methode haalt de gegevens op voor het baroverzicht/keukenoverzicht
        {

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlConnection connectie = new SqlConnection(connString);
            connectie.Open();

            
            SqlCommand command = new SqlCommand("SELECT bestelling_id, tafel_id, ItemId, aantal  FROM Bestelling, BestellingItems, MenuItem, Menucategorie WHERE (bestelling_id = BestellingId AND ItemId = menu_id) AND (Menuitem.categorie_id = Menucategorie.categorie_id);", connectie);
            // deze query zorgt ervoor dat via het koppeltabel een menu-item geselecteerd kan worden.
            SqlDataReader reader = command.ExecuteReader();
            List<BestellingMenuClass> bestellingen = new List<BestellingMenuClass>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int) reader["tafel_id"];
                //string datum = (string) reader["datum"];
                //string tijd = (string)reader["tijd"];
                int ItemdId = (int)reader["ItemId"];
                int aantal = (int)reader["aantal"];



                //bool betaald = (bool)reader.GetBoolean(6);
                BestellingMenuClass opgehaaldeBestelling = new BestellingMenuClass(bestelling_id, tafel_id, aantal, ItemdId);
                bestellingen.Add(opgehaaldeBestelling);
            
            }
            
            connectie.Close();
            return bestellingen;
           
           
           
        }

        public void voegBestellingToe(BestellingMenuClass bestellingen)
        {
             
    

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlConnection connectie = new SqlConnection(connString);
            connectie.Open();

            string sql = String.Format("INSERT INTO Bestelling(bestelling_id, tafel_id, datum, tijd, voorraad, kaart_id, betaald, personeel_id)" + " values({0},{1},{2}{3},{4},{5},{6},{7})",  1, 2, 3, 4, 5, 6, 7,8);
            SqlCommand command = new SqlCommand(sql, connectie);
            int rowsAffected = command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader(); // datareaderobject

           
            connectie.Close();
           
        }

       

        }
    }

