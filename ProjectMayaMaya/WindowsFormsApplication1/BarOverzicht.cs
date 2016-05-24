using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class BarOverzicht : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        public BarOverzicht()
        {
            InitializeComponent();
        }

        private void btn_BARnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left; // geeft de grote aan van deze form voor het te openen form
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }

        private void gbox_BarBestelling_Enter(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["BestellingConnectionStringSQL"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString); // connectieobject wordt aangemaakt

            conn.Open();   // connectie wordt opengezet 

            SqlCommand command = new SqlCommand("SELECT * FROM Bestelling INNER JOIN BestellingItems ON Bestelling.bestelling_id = BestellingItems.bestelling_id;");
            
            
            SqlDataReader reader = command.ExecuteReader(); // datareaderobject

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                int tafel_id = (int)reader["tafel_id"];
                int ItemId = (int)reader["ItemId"];
                // maak bestellingoverzicht object aan en voeg deze gegevens toe aan het bestellingsoverzicht
            }

            conn.Close(); 
        }
    }
}
