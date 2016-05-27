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
        public List<Bestelling> bestellingOpgehaald = new List<Bestelling>();
        
        public void haalBestellingOp()
        {

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlConnection connectie = new SqlConnection(connString);
            connectie.Open();

            
            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling", connectie);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int) reader["tafel_id"];
                DateTime besteldatum = (DateTime) reader["besteldatum"];
                int voorraad = (int) reader["voorraad"];
                int kaart_id = (int) reader["kaart_id"];
                bool betaald = (bool) reader["betaald"];
                Bestelling opgehaaldeBestelling = new Bestelling(bestelling_id, tafel_id, besteldatum, voorraad, kaart_id, betaald);
                bestellingOpgehaald.Add(opgehaaldeBestelling);
            
            }
           
            connectie.Close();
           
        }
    }
}
