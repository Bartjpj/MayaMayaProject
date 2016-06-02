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
        

        public List<InlogSchermClass> haalPersoneelslid_IDTabelOp()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Personeelslid", conn);
            SqlDataReader reader = command.ExecuteReader();

            List<InlogSchermClass> personeelIDtable = new List<InlogSchermClass>();

            while (reader.Read())
            {
                int personeel_id = (int)reader["personeel_id"];
                string naam = (string)reader["naam"];
                string functie = (string)reader["functie"];
                int code = (int)reader["code"];

                InlogSchermClass klantX = new InlogSchermClass(personeel_id, naam, functie, code);
                personeelIDtable.Add(klantX);
            }
            conn.Close();
            return personeelIDtable;
        }


    }
}
