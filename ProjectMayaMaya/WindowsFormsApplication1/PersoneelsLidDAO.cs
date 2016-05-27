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
        public List<Klantenlijst> klantenlijstList = new List<Klantenlijst>(); //dit is de lijst waar de personeelslidtabel in opgeslagen zal worden.

        public bool haalPersoneelslid_IDTabelOp(int inlogcode)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Personeelslid WHERE code = '" + inlogcode + "'", conn);
            SqlDataReader reader = command.ExecuteReader();
            int rowsAffected = command.ExecuteNonQuery();

            while (reader.Read())
            {
                int personeel_id = (int)reader["personeel_id"];
                string naam = (string)reader["naam"];
                string functie = (string)reader["functie"];
                int code = (int)reader["code"];

                Klantenlijst klantX = new Klantenlijst(personeel_id, naam, functie, code);
                klantenlijstList.Add(klantX);
            }

            bool juisteCode = false;

            if (rowsAffected == 1)
            {
                juisteCode = true;
            }

            conn.Close();
            return juisteCode;
        }



        private void GetAllPersoneelsID(PersoneelsLidDAO klantenlijstList)
        {
           // personeelsTabel = klantenlijstList.haalPersoneelslid_IDTabelOp();
        }


    }
}
