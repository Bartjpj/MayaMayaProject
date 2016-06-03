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
        List<keukenBestellingOverzichtClass> bestellinglijstKeuken = new List<keukenBestellingOverzichtClass>();
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

            bestellinglijstKeuken = keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp();

            //bool bestelling_gereed = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bestellinglijst wordt geopend voor " + ((Button)sender).Name);

            Button btn = (Button)sender;
            tafelNr = Int32.Parse(btn.Text.Substring(5).Trim());

            // ... moet de parameter tafelNr meegeven aan de Dao zodat een query gemaakt kan worden om deze specifieke tafel op te halen
            bestellingOverzichtKeukenView.Items.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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

        private void groep_BestellingKeukenX_Enter(object sender, EventArgs e)
        {
            // bestellingoverzicht moet hier komen en die moet zichtbaar zijn voor alle personeelsleden. En gereedgemeld kunnen worden door bijv. chefkok of barman.
        }

        private void btn_gereedKeuken_Click(object sender, EventArgs e)
        {
            foreach (keukenBestellingOverzichtClass KeukenOverzicht in keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp())
            {

                ListViewItem lijstItem = new ListViewItem(KeukenOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(KeukenOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(KeukenOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(KeukenOverzicht.naam.ToString());
                bestellingOverzichtKeukenView.Items.Add(lijstItem);

            }
        }

    }
}
