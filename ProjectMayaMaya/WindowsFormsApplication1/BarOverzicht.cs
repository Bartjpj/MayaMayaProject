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
        public int tafelNr;
       
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

            // bepaal aan welke tafels er een bestelling loopt
            // ...  
            List<int> tafelNummers = new List<int>();



           DisplayBestellingen();

           // Button btn2 = new Button();
           // btn2.Name = "btn2";
           // btn2.Text = "Tafel 2";
           // btn2.Click += new EventHandler(button_Click);
           //this.flowLayoutPanel1.Controls.Add(btn2);

           //lb_Baroverzicht.Items.Add(bestellingslijst);
           //lb_Baroverzicht.DataSource = bestellingslijst.ToString();


           //dataGridView1.DataSource = bestellingslijst; // zet de opgehaalde bestelling in de datagridview

        //   for (int i = 0; i < bestellingslijst.Count; i++ )
        //       lb_Baroverzicht.DisplayMember = bestellingslijst[i].ToString();
           

        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestellinglijst wordt geopend voor " + ((Button)sender).Name);

            Button btn = (Button)sender;
            tafelNr = Int32.Parse(btn.Text.Substring(5).Trim());

            // ... moet de parameter tafelNr meegeven aan de Dao zodat een query gemaakt kan worden om deze specifieke tafel op te halen
            listView1.Items.Clear();

            List<BarOverzichtClass> items = BarOverzichtDAO.haalBestellingTafel(tafelNr); // parameter wordt hier meegegeven aan Dao zodat er per tafel de bestellingen opgehaald kunnen worden.
            foreach (BarOverzichtClass barOverzicht in items)
            {
                ListViewItem lijstItem = new ListViewItem(barOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(barOverzicht.naam.ToString());
                lijstItem.SubItems.Add(barOverzicht.datum_tijd.ToString());
                listView1.Items.Add(lijstItem);

                //for (int i = listView1.Items.Count - 1; i >= 0; i--)
                //{

                //    if (listView1.Items[i].Selected)
                //    {
                //        //item = listView1.SelectedItems[i];

                //        listView1.Items[i].Remove();

                //    }
                //}

            }
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

            

        private void DisplayBestellingen()
        {
            listView1.Items.Clear();
            foreach (BarOverzichtClass barOverzicht in this.bestellingslijst)
            {
                //for (int i = listView1.Items.Count - 1; i >= 0; i--)
                //{
                //    //ListViewItem get = new ListViewItem
                //    listView1.Items[i].Remove();
                //}
                ListViewItem lijstItem = new ListViewItem(barOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(barOverzicht.naam.ToString());
                lijstItem.SubItems.Add(barOverzicht.datum_tijd.ToString());
                listView1.Items.Add(lijstItem);
            }
            createTafels();
        }

        private void gbox_bestelling3_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

            

        private void btn_BestellingGereed_Click(object sender, EventArgs e)
        {
            BarOverzichtClass isGereedmelding = new BarOverzichtClass();
            ////var item = listView1.SelectedItems[0];
            //bool isGereed = true;
    //        foreach (BarOverzichtClass barOverzicht in BarOverzichtDAO.haalBarOverzicht_TabelOp())
            {

                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {

                    if (listView1.Items[i].Selected)
                    {
                        //item = listView1.SelectedItems[i];
                        
                        listView1.Items[i].Remove();

                    }
                }
                BarOverzichtDAO.updateTafelsGereed(tafelNr);
                }
              
            
            // ...
           // isGereedmelding.bestellingGereed(tafelNr);

            // refresh het hele scherm
            bestellingslijst = BarOverzichtDAO.haalBarOverzicht_TabelOp(); // haal de bestelling op
            DisplayBestellingen();
        }



        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
     
            listView1.Items.Clear();

            foreach (BarOverzichtClass barOverzicht in BarOverzichtDAO.haalBarOverzicht_TabelOp())
            {
                //for (int i = listView1.Items.Count - 1; i >= 0; i--)
                //{
                //    //ListViewItem get = new ListViewItem
                //    listView1.Items[i].Remove();
                //}
                ListViewItem lijstItem = new ListViewItem(barOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(barOverzicht.naam.ToString());
                listView1.Items.Add(lijstItem);


            }
            this.Focus();
       
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
 
        private void createTafels()
        {
            List<int> tafelNummers = BarOverzichtDAO.haalTafelNrOp();
            List<int> tafelNummersDistinct = tafelNummers.Distinct().ToList();
            flowLayoutPanel1.Controls.Clear();
            foreach (int tafelNummer in tafelNummersDistinct) 
            {
                
                Button b = new Button();
                b.Tag = tafelNummer;
                b.Name = "Tafel " + tafelNummer.ToString();
                b.Text = "Tafel " + tafelNummer.ToString();
                b.AutoSize = false;
                b.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(b);
                
              
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
    }
}
