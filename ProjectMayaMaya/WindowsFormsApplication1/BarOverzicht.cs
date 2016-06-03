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
        BarOverzichtDAO BarOverzichtDAO;
        List<BarOverzichtClass> bestellingslijst = new List<BarOverzichtClass>();
       
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
     
        public BarOverzicht(BarOverzichtDAO BarOverzichtDAO) // geef een bestellingDAO als constructor mee.
        {
           InitializeComponent();

           this.BarOverzichtDAO = BarOverzichtDAO; // zet bestellingdao

           bestellingslijst = BarOverzichtDAO.haalBarOverzicht_TabelOp(); // haal de bestelling op

           //lb_Baroverzicht.Items.Add(bestellingslijst);
           //lb_Baroverzicht.DataSource = bestellingslijst.ToString();


           //dataGridView1.DataSource = bestellingslijst; // zet de opgehaalde bestelling in de datagridview

        //   for (int i = 0; i < bestellingslijst.Count; i++ )
        //       lb_Baroverzicht.DisplayMember = bestellingslijst[i].ToString();
           

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
            BarOverzichtClass isGereedmelding = new BarOverzichtClass();
            var item = listView1.SelectedItems[0];
            bool isGereed = true;
            foreach (BarOverzichtClass barOverzicht in BarOverzichtDAO.haalBarOverzicht_TabelOp())
            {

                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {

                    if (listView1.Items[i].Selected)
                    {
                        item = listView1.SelectedItems[i];
                        
                        listView1.Items[i].Remove();

                    }
                }
              
            }
            isGereedmelding.bestellingGereed(isGereed);

        }
        
        public void StartenTimer(bool isGereed, TafelOverzicht tm_Tafel1)
        {
            if (isGereed == true)
            {
                tm_Tafel1.Enabled = false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            foreach (BarOverzichtClass barOverzicht in BarOverzichtDAO.haalBarOverzicht_TabelOp())
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    //ListViewItem get = new ListViewItem
                    listView1.Items[i].Remove();
                }
                ListViewItem lijstItem = new ListViewItem(barOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(barOverzicht.naam.ToString());
                listView1.Items.Add(lijstItem);

            }
        }
    }
}
