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
        keukenBestellingOverzichtDAO keukenBestellingOverzichtDAO;
        List<keukenOverzichtClass> bestellingslijst = new List<keukenOverzichtClass>();
        public int tafelNr;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        public keukenBestellingOverzicht(keukenBestellingOverzichtDAO keukenBestellingOverzichtDAO)
        {
            InitializeComponent();

            this.keukenBestellingOverzichtDAO = keukenBestellingOverzichtDAO;

            bestellingslijst = keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp();

            List<int> tafelNummers = new List<int>();
            DisplayBestellingen();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestellinglijst wordt geopend voor " + ((Button)sender).Name);

            Button btn = (Button)sender;
            tafelNr = Int32.Parse(btn.Text.Substring(5).Trim());

            // ... moet de parameter tafelNr meegeven aan de Dao zodat een query gemaakt kan worden om deze specifieke tafel op te halen
            bestellingOverzichtKeukenView.Items.Clear();

            List<keukenOverzichtClass> items = keukenBestellingOverzichtDAO.haalBestellingTafel(tafelNr);
            foreach (keukenOverzichtClass keukenOverzicht in items)
            {
                ListViewItem lijstItem = new ListViewItem(keukenOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.naam.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.datum_tijd.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.opmerking.ToString());
                bestellingOverzichtKeukenView.Items.Add(lijstItem);
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
                ListViewItem lijstItem = new ListViewItem(keukenOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.naam.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.datum_tijd.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.opmerking.ToString());
                bestellingOverzichtKeukenView.Items.Add(lijstItem);
            }
            createTafels();
        }

        private void bestellingOverzichtKeukenView_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                ListViewItem lijstItem = new ListViewItem(keukenOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.naam.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.datum_tijd.ToString());
                lijstItem.SubItems.Add(keukenOverzicht.opmerking.ToString());
                bestellingOverzichtKeukenView.Items.Add(lijstItem);
              
            }
        }

      

        private void groep_BestellingKeukenX_Enter(object sender, EventArgs e)
        {
            // bestellingoverzicht moet hier komen en die moet zichtbaar zijn voor alle personeelsleden. En gereedgemeld kunnen worden door bijv. chefkok of barman.
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
                b.AutoSize = false;
                b.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(b);


            }
        }
      



        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


     

    }
}
