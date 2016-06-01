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
    public partial class Afrekenen : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        public Afrekenen()
        {
            InitializeComponent();
        }

        private void BTN_AFREKENENnaarTAFELOVERZICHT_Click(object sender, EventArgs e)
        {
            TafelOverzicht openTafelOverzicht = new TafelOverzicht();
            openTafelOverzicht.Show(this);
            this.Hide();
        }
    }
}
