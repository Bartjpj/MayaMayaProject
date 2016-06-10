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
            KiesOpname openKiesOpname = new KiesOpname();
            openKiesOpname.Show(this);
            this.Hide();
        }
        public int tafelgetal;
        public int GetalTafel
        {
            get { return tafelgetal; }
            set { tafelgetal = value; }
        }
        //public int TafelLabel
        //{
        //    //get{return lbl_klaargemeldetafel.Text;}
        //    //set{lbl_klaargemeldetafel.Text = value.ToString();}

        //}
        private void btn_pinbetalen_Click(object sender, EventArgs e)
        {

        }
        TafelOverzicht tafelOverzicht;

        private void lbl_klaargemeldetafel_Click(object sender, EventArgs e)
        {
            int tafelnr = tafelOverzicht.tafelgetal;
            lbl_klaargemeld.Text = tafelnr.ToString();

        }
        public bool klaarmelden = false;

        public void btn_cbutton_Click(object sender, EventArgs e)
        {
            int tafelnr = tafelOverzicht.tafelgetal;
            if (tafelnr == 1)
                klaarmelden = true;

        }
    }
}
