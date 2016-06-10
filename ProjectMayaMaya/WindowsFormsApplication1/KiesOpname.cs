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
    public partial class KiesOpname : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        
        public KiesOpname()
        {
            InitializeComponent();
        }

        private void btn_BestellingOpnemen_Click(object sender, EventArgs e)
        {
            BestellingOpnemenDAO dinerkaart = new BestellingOpnemenDAO();
            BestellingOpnemen openDinerkaart = new BestellingOpnemen(dinerkaart);
            openDinerkaart.GetalTafel = tafelgetal;
            openDinerkaart.Show(this);
            this.Hide();
        }
        public int tafelgetal;
        public int GetalTafel
        {
            get { return tafelgetal; }
            set { tafelgetal = value; }
        }
        private void btn_afrekenen_Click(object sender, EventArgs e)
        {
            Afrekenen openAfrekenscherm = new Afrekenen();
            openAfrekenscherm.Show(this);
            //openAfrekenscherm.TafelLabel = tafelgetal;
            this.Hide();
        }

        private void btn_KIESOPNnaarTAFELOVERZICHT_Click(object sender, EventArgs e)
        {
            //TafelOverzicht openTafeloverzicht = new TafelOverzicht();
            //this.Hide();
            //openTafeloverzicht.ShowDialog(this);
            //this.Show();
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }
        TafelOverzicht tafelOverzicht;
        public void btn_BezetMelden_Click(object sender, EventArgs e)
        {
            int tafelnr = tafelOverzicht.tafelgetal;
            if (tafelnr == 1)
            {
                //tafelOverzicht.btn_Tafel1.BackColor = Color.LightSkyBlue;
            }
        }
    }
}
