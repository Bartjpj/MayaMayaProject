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
        BestellingDAO bestellingDAO;
        List<Bestelling> bestellingslijst = new List<Bestelling>();
       
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
     
        public BarOverzicht(BestellingDAO bestellingDAO) // geef een bestellingDAO als constructor mee.
        {
           InitializeComponent();

           this.bestellingDAO = bestellingDAO; // zet bestellingdao
          
           bestellingslijst = bestellingDAO.haalBestellingOp(); // haal de bestelling op
           lb_Baroverzicht.DataSource = bestellingslijst;
           //lb_Baroverzicht.Items.Add(bestellingslijst);



           for (int i = 0; i < bestellingslijst.Count; i++ )
               lb_Baroverzicht.DisplayMember = bestellingslijst[i].ToString();
           

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
            
        }

        private void BarOverzicht_Load(object sender, EventArgs e)
        {

        }

        private void gbox_bestelling3_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_BestellingGereed_Click(object sender, EventArgs e)
        {
            
        }
    }
}
