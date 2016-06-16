using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class keukenBestellingOverzicht : Form
    {
        keukenBestellingOverzichtDAO keukenBestellingOverzichtDAO; // initialisatie van het DAO object voor keukenoverzicht die in deze klasse wordt gebruikt.
        List<keukenOverzichtClass> bestellingslijst = new List<keukenOverzichtClass>(); // initialisatie van een lijst van bestellingen, deze wordt later in de klas gebruikt
        public int tafelNr; // initialisatie van de variable tafelNr

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        public keukenBestellingOverzicht(keukenBestellingOverzichtDAO keukenBestellingOverzichtDAO) // geeft een keukenbestellingdao mee als parameter in de constructor
        {
            InitializeComponent();

            this.keukenBestellingOverzichtDAO = keukenBestellingOverzichtDAO; // zet keukenBestellingOverzichtDAO gelijk aan de keukenBestellingOverzichtDAO object in de class 

            bestellingslijst = keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp();  // haal de bestelling op

            DisplayBestellingen(); // methode die de bestellingen displayed in the listview
        }

        private void button_Click(object sender, EventArgs e)
        {
           

            Button btn = (Button)sender; // 
            tafelNr = Int32.Parse(btn.Text.Substring(5).Trim()); // button in flowpanel wordt getrimmed de tekst tafel wordt eraf gehaald en je houdt een nummer over die wordt in de variabele tafelNr gestopt

            // ... moet de parameter tafelNr meegeven aan de Dao zodat een query gemaakt kan worden om deze specifieke tafel op te halen
            bestellingOverzichtKeukenView.Items.Clear();

            List<keukenOverzichtClass> items = keukenBestellingOverzichtDAO.haalBestellingTafel(tafelNr);
            foreach (keukenOverzichtClass keukenOverzicht in items)
            {

                voegListViewItemsToe(keukenOverzicht); // het keukenOverzicht object wordt hier aan de methode voegListVietItemsToe meegegeven zodat de items in de listview kunnen komen.
                
            }

        }

        private void btn_KeukenNaarHoofdmenu_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left;
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }

        private void DisplayBestellingen()
        {
            bestellingOverzichtKeukenView.Items.Clear();
            foreach (keukenOverzichtClass keukenOverzicht in this.bestellingslijst)
            {

                voegListViewItemsToe(keukenOverzicht);

            }
            createTafels();
        }

        private void bestellingOverzichtKeukenView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void voegListViewItemsToe(keukenOverzichtClass keukenOverzicht)
        {
            string opmerking = " ";
            ListViewItem lijstItem = new ListViewItem(keukenOverzicht.bestelling_id.ToString());
            lijstItem.SubItems.Add(keukenOverzicht.tafel_id.ToString());
            lijstItem.SubItems.Add(keukenOverzicht.aantal.ToString());
            lijstItem.SubItems.Add(keukenOverzicht.naam.ToString());
            lijstItem.SubItems.Add(keukenOverzicht.datum_tijd.ToString());
            if (keukenOverzicht.opmerking.Contains("1") || keukenOverzicht.opmerking.Contains("2"))
            {
                opmerking = keukenOverzicht.opmerking.Substring(1);
            }
            else { opmerking = " "; }
            lijstItem.SubItems.Add(opmerking);
            bestellingOverzichtKeukenView.Items.Add(lijstItem);
        }

        private void btn_gereed_keuken_Click(object sender, EventArgs e)
        {
            keukenOverzichtClass isGereedmelding = new keukenOverzichtClass();

            for (int i = bestellingOverzichtKeukenView.Items.Count - 1; i >= 0; i--)
            {
                if (bestellingOverzichtKeukenView.Items[i].Selected)
                {
                    bestellingOverzichtKeukenView.Items[i].Remove();

                }
            }
            keukenBestellingOverzichtDAO.updateTafelsGereed(tafelNr);
            bestellingslijst = keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp();
            DisplayBestellingen();
        }

        private void bestellingOverzichtKeukenView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_keukenOverzicht_Click(object sender, EventArgs e)
        {
            bestellingOverzichtKeukenView.Items.Clear();

            foreach (keukenOverzichtClass keukenOverzicht in keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp())
            {
                voegListViewItemsToe(keukenOverzicht);

            }
        }

      

        private void groep_BestellingKeukenX_Enter(object sender, EventArgs e)
        {
            
        }

        

 

        private void createTafels()
        {
            List<int> tafelNummers = keukenBestellingOverzichtDAO.haalTafelNrOp();
            List<int> tafelNummersDistinct = tafelNummers.Distinct().ToList();
            flowLayoutPanel1.Controls.Clear();

            foreach (int tafelNummer in tafelNummersDistinct)
            {

                Button b = new Button();
                b.Tag = tafelNummer;
                b.Name = "Tafel " + tafelNummer.ToString();
                b.Text = "Tafel " + tafelNummer.ToString();
                b.BackColor = Color.DodgerBlue;
                b.AutoSize = false;
                b.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(b);


            }
        }
      



        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bestellingOverzichtKeukenView.Items.Clear();
            foreach (keukenOverzichtClass keukenOverzicht in keukenBestellingOverzichtDAO.haalDagKeukenBestelling())
            {
                

                voegListViewItemsToe(keukenOverzicht);

               

            }

        }

        private void lbl_OpenstaandeBestellingenKeuken_Click(object sender, EventArgs e)
        {

        }


     

    }
}
