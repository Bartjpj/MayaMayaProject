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

            bool bestelling_gereed = false;
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
            bool bestelling_gereed = true;
            foreach (keukenBestellingOverzichtClass KeukenOverzicht in keukenBestellingOverzichtDAO.haalKeukenBestelling_TabelOp())
            {

                ListViewItem lijstItem = new ListViewItem(KeukenOverzicht.bestelling_id.ToString());
                lijstItem.SubItems.Add(KeukenOverzicht.tafel_id.ToString());
                lijstItem.SubItems.Add(KeukenOverzicht.aantal.ToString());
                lijstItem.SubItems.Add(KeukenOverzicht.naam.ToString());
                bestellingOverzichtKeuken.Items.Add(lijstItem);

            }
            
        }
    }
}
