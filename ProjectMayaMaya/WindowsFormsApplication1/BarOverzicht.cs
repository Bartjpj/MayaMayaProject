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
        List<BarOverzichtBLL> bestellingslijst = new List<BarOverzichtBLL>();
        ListViewItem lijstItem;
        public int tafelNr;
        public int bestellings_id;
       
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

        }

        private void button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Bestellinglijst wordt geopend voor " + ((Button)sender).Name);

            Button btn = (Button)sender;
            tafelNr = Int32.Parse(btn.Text.Substring(5).Trim());

            // ... moet de parameter tafelNr meegeven aan de Dao zodat een query gemaakt kan worden om deze specifieke tafel op te halen
            listView1.Items.Clear();

            List<BarOverzichtBLL> items = BarOverzichtDAO.haalBestellingTafel(tafelNr); // parameter wordt hier meegegeven aan Dao zodat er per tafel de bestellingen opgehaald kunnen worden.
            foreach (BarOverzichtBLL barOverzicht in items)
            {


                voegListViewItemsToe(barOverzicht);

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

            
        private void voegListViewItemsToe(BarOverzichtBLL barOverzicht)
        {
            string opmerking = " ";
                ListViewItem lijstItem = new ListViewItem(barOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(barOverzicht.naam.ToString());
                lijstItem.SubItems.Add(barOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(barOverzicht.datum_tijd.ToString());
            if (barOverzicht.opmerking.Contains("0081") || barOverzicht.opmerking.Contains("0083"))
            {
                opmerking = barOverzicht.opmerking.Substring(4);
            }
            else { opmerking = " "; }
            lijstItem.SubItems.Add(opmerking);
                listView1.Items.Add(lijstItem);
        } // methode om listviewItems toe te voegen 
        private void DisplayBestellingen()
        {
            listView1.Items.Clear();
            foreach (BarOverzichtBLL barOverzicht in this.bestellingslijst)
            {
                voegListViewItemsToe(barOverzicht);

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
            BarOverzichtBLL isGereedmelding = new BarOverzichtBLL();

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();

                }
            }
            BarOverzichtDAO.updateTafelsGereed(tafelNr);
            bestellingslijst = BarOverzichtDAO.haalBarOverzicht_TabelOp();
            DisplayBestellingen();

        } // gereedknop om bestelling gereed te melden en de listview te legen. Indien bestelling gereed.


        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e) // refresh button, hier wordt de hele lijst van openstaande bestellingen voor de bar opgehaald uit de database. Deze worden vervolgens in de listview gezet.
        {
          
            listView1.Items.Clear();

            foreach (BarOverzichtBLL barOverzicht in BarOverzichtDAO.haalBarOverzicht_TabelOp())
            {

                voegListViewItemsToe(barOverzicht);
      
       
        }


        }
 
        private void createTafels() // methode om de tafels in het flowpanel te weergeven.
        {
            List<int> tafelNummers = BarOverzichtDAO.haalTafelNrOp(); // haalt de tafelnr's op uit de database en stopt ze in een list van tafelnummers
            List<int> tafelNummersDistinct = tafelNummers.Distinct().ToList(); // zorgt ervoor dat er geen dubbele tafelnummers in de flowpanel zitten en stopt die weer in een nieuwe lijst
            lopendeBestellingTafels.Controls.Clear(); // cleared eerst de hele flowpanel
            foreach (int tafelNummer in tafelNummersDistinct) 
            {
                // maakt per tafelnummer die is opgehaald in de database een button aan waar op geklikt kan worden.
                Button b = new Button();
                b.Tag = tafelNummer;
                b.Name = "Tafel " + tafelNummer.ToString();
                b.Text = "Tafel " + tafelNummer.ToString();
                b.BackColor = Color.DodgerBlue;
                b.AutoSize = false;
                b.Click += new EventHandler(button_Click);
                lopendeBestellingTafels.Controls.Add(b);
                
              
            }
        }

        private void lopendeBestellingTafels_Paint(object sender, PaintEventArgs e) // flowpanel voor de lopende bestellingen bij tafels die nog niet gereed zijn gemeld.
        {
           
            
        }

        private void btn_dagoverzicht_Click(object sender, EventArgs e) // button om het gehele dagoverzicht van alle bestellingen te zien van de afgelopen 24 uur.
        {

            listView1.Items.Clear();

            foreach (BarOverzichtBLL barOverzicht in BarOverzichtDAO.haalDagBarOverzicht())
            {
                
                voegListViewItemsToe(barOverzicht);
           
            
        }
    }
}
}
