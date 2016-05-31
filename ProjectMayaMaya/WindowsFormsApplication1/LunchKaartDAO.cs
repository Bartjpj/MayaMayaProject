using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class LunchKaartDAO
    {
        public void haalLunchKaart_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menuitem WHERE categorie_id < 4", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<LunchKaartClass> LunchKaartTable = new List<LunchKaartClass>();

            while (reader.Read())
            {
                int kaart_id = (int)reader["kaart_id"];
                int categorie_id = (int)reader["categorie_id"];
                string naam = (string)reader["naam"];
                int prijs = (int)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                //Onderzoeken wrm dit niet werkt

                LunchKaartClass LunchKaartDAO = new LunchKaartClass(kaart_id, categorie_id, naam, prijs, voorraad);
                LunchKaartTable.Add(LunchKaartDAO);
            }

            conn.Close();
        }
    }
}
