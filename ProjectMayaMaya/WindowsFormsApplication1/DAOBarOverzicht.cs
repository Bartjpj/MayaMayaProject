using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    class DAOBarOverzicht
    {
        protected SqlConnection dbConnection; // connectieobject wordt aangemaakt
        public DAOBarOverzicht(SqlConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public void DAOBar()
        {

            dbConnection.Open();   // connectie wordt opengezet 

            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;

            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling INNER JOIN BestellingItems ON Bestelling.bestelling_id = BestellingItems.bestelling_id;");

            SqlDataReader reader = command.ExecuteReader(); // datareaderobject

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int ItemId = (int)reader["ItemId"];
                // maak bestellingoverzicht object aan en voeg deze gegevens toe aan het bestellingsoverzicht
            }


            dbConnection.Close();
        }
    }
}


