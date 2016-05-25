using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public class PersoneelsLidDAO
    {
        public void haalPersoneelslid_IDTabelOp()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Personeelslid", conn);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int personeel_id = (int)reader["personeeld_id"];
                int tafel_id = (int)reader["tafel_id"];
                int bestelling_id = (int)reader["tafel_id"];
                string naam = (string)reader["naam"];
                string functie = (string)reader["functie"];
                int barnotificatie_id = (int)reader["barnotificatie_id"];
                int keukennotificatie_id = (int)reader["keukennotificatie_id"];

                Klantenlijst klantX = new Klantenlijst(personeel_id, tafel_id, bestelling_id, naam, functie, barnotificatie_id, keukennotificatie_id);
                klantX.klantenlijstList.Add(klantX);
            }
            
            conn.Close();
        }




    }
}
