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
            BestellingMenu openBestellingmenu = new BestellingMenu();
            openBestellingmenu.Show(this);
            this.Hide();
        }

        private void btn_afrekenen_Click(object sender, EventArgs e)
        {
            Afrekenen openAfrekenscherm = new Afrekenen();
            openAfrekenscherm.Show(this);
            this.Hide();
        }

        private void btn_KIESOPNnaarTAFELOVERZICHT_Click(object sender, EventArgs e)
        {
            TafelOverzicht openTafeloverzicht = new TafelOverzicht();
            openTafeloverzicht.Show(this);
            this.Hide();
        }
    }
}
