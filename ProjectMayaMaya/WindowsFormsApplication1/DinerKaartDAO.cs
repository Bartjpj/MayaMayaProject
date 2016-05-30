using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class DinerKaartDAO
    {
        public List<DinerKaartClass> haalDinerKaart_TabelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menuitem WHERE categorie_id > 3 AND categorie_id < 8", conn);
            // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<DinerKaartClass> DinerKaartTable = new List<DinerKaartClass>();

            while (reader.Read())
            {
                int menu_id = (int)reader["menu_id"];
                int categorie_id = (int)reader["categorie_id"];
                string naam = (string)reader["naam"];
                double prijs = (double)reader["prijs"];
                int voorraad = (int)reader["voorraad"];
                //Onderzoeken wrm dit niet werkt

                DinerKaartClass DinerKaartDAO = new DinerKaartClass(menu_id, categorie_id, naam, prijs, voorraad);
                DinerKaartTable.Add(DinerKaartDAO);
            }

            conn.Close();
            return DinerKaartTable;
        }


    }
}

