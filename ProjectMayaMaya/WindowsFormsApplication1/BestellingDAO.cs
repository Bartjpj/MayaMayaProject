using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class BestellingDAO
    {
      

        public BestellingDAO(){
 

        }
        
        
        public  List<Bestelling> haalBestellingOp()
        {

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlConnection connectie = new SqlConnection(connString);
            connectie.Open();

            
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling", connectie);

            SqlDataReader reader = command.ExecuteReader();
            List<Bestelling> bestellingen = new List<Bestelling>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int) reader["tafel_id"];
                string datum = (string) reader["datum"];
                string tijd = (string)reader["tijd"];
                int voorraad = (int) reader["voorraad"];
                int kaart_id = (int) reader["kaart_id"];
                bool betaald = (bool)reader.GetBoolean(6);
                Bestelling opgehaaldeBestelling = new Bestelling(bestelling_id, tafel_id, datum, tijd, voorraad, kaart_id, betaald);
                bestellingen.Add(opgehaaldeBestelling);
            
            }
            return bestellingen;
            connectie.Close();
           
           
           
        }

        public void voegBestellingToe(Bestelling bestellingen)
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

