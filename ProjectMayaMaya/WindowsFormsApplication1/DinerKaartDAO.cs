using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class MenuItemsDAO
    {
        private List<MenuItemsClass> haalMenuItemsOp(int groterDan, int kleinerDan) // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menuitem WHERE categorie_id >= " + groterDan + " AND categorie_id <= " + kleinerDan, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenuItemsClass> DinerKaartTable = new List<MenuItemsClass>();

            while (reader.Read())
            {
                int menu_id = (int)reader["menu_id"];
                int categorie_id = (int)reader["categorie_id"];
                string naam = (string)reader["naam"];
                double prijs = (double)reader["prijs"];
                int voorraad = (int)reader["voorraad"];

                MenuItemsClass DinerKaartDAO = new MenuItemsClass(menu_id, categorie_id, naam, prijs, voorraad);
                DinerKaartTable.Add(DinerKaartDAO);
            }

            conn.Close();
            return DinerKaartTable;
        }

       public List<MenuItemsClass> haalDinerKaartOp(int groterDan, int kleinerDan)
       {
           List<MenuItemsClass> DinerKaart = haalMenuItemsOp(groterDan, kleinerDan);
           return DinerKaart;
       }

        //public List<MenuItemsClass> haalLunchKaartOp()
       //{

       //}

        //public List<MenuItemsClass> haalDrankenKaartOp()
       //{

       //}


    }
}

