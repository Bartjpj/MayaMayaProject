using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BestellingMenu : Form
    {
        int tafelgetal = 0;

        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        public BestellingMenu()
        {
            InitializeComponent();
        }
        private void cbox_selecteerkaart_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cbox_selecteerkaart.Items.Add("Dranken");
            cbox_selecteerkaart.Items.Add("Lunch");
            cbox_selecteerkaart.Items.Add("Diner");*/
        }

        private void btn_BestellingMENUnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left; // geeft de grote aan van deze form voor het te openen form
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }

        private void BestellingMenu_Load(object sender, EventArgs e)
        {

        }


        private void btn_BestellingMENUnaarTAFELOVERZICHT_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesOpname = new KiesOpname();
            openKiesOpname.Show(this);
            this.Hide();

        }


        private void btn_Lunchkaart_Click(object sender, EventArgs e)
        {
            LunchKaart openLunchKaart = new LunchKaart();
            openLunchKaart.Show(this);
            this.Hide();
        }

        private void btn_drankmenu_Click(object sender, EventArgs e)
        {
            DrankenKaart opendrankenkaart = new DrankenKaart();
            opendrankenkaart.Show(this);
            this.Hide();
        }

        private void btn_dinerkaart_Click(object sender, EventArgs e)
        {
            DinerKaartDAO dinerkaart = new DinerKaartDAO();
            DinerKaart openDinerkaart = new DinerKaart(dinerkaart);
            openDinerkaart.Show(this);
            this.Hide();
        }
    }

}
