using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class DrankenKaartDAO
    {
        public void haalDrankenKaart_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menuitem WHERE categorie_id > 7", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<DrankenKaartClass> DrankenKaartTable = new List<DrankenKaartClass>();

            while (reader.Read())
            {
                int kaart_id = (int)reader["kaart_id"];
                int categorie_id = (int)reader["categorie_id"];
                string naam = (string)reader["naam"];
                int prijs = (int)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                //Onderzoeken wrm dit niet werkt

                DrankenKaartClass DrankenKaartDAO = new DrankenKaartClass(kaart_id, categorie_id, naam, prijs, voorraad);
                DrankenKaartTable.Add(DrankenKaartDAO);
            }

            conn.Close();
        }

    }
}
