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
            TafelOverzicht TerugNaarTafelOverzicht = new TafelOverzicht();
            TerugNaarTafelOverzicht.Show();
            TerugNaarTafelOverzicht.Left = this.Left; // geeft de grote aan van deze form voor het te openen form
            TerugNaarTafelOverzicht.Top = this.Top;
            TerugNaarTafelOverzicht.Size = this.Size;
            this.Hide();
        }


        private void btn_Lunchkaart_Click(object sender, EventArgs e)
        {
            LunchKaart openLunchKaart = new LunchKaart();
            openLunchKaart.Show(this);
            this.Hide();
        }

        private void txtbox_fooi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_drankmenu_Click(object sender, EventArgs e)
        {
            DrankenKaart opendrankenkaart = new DrankenKaart();
            opendrankenkaart.Show(this);
            this.Hide();
        }

        public void tafelgetalWijzigen(int tafelGetal)
        {
            tafelgetal = tafelGetal;
        }
        
        
        Stopwatch s1 = new Stopwatch();

        //Ben de timer aan het testen of ik hem hier kan enabelen en dan de tijd doorgeven op het tafeloverzicht form.
        public void btn_stuurbestelling_Click(object sender, EventArgs e, TafelOverzicht tm_tafel1, TafelOverzicht btn_Tafel1)
        {

            //int min, sec, ms = 0;
            //int tafelnr = tafelgetal;

            //if (tafelnr == 1)
            //{
            //    tm_tafel1.Enabled = true;
            //    tm_tafel1.Start();
            //    if (ms >= 10)
            //    {
            //        sec++;
            //        ms = 0;
            //    }
            //    if (sec >= 60)
            //    {
            //        min++;
            //        sec = 0;
            //    }
            //    if (min >= 30)
            //    {
            //        btn_Tafel1.BackColor = Color.Maroon;
            //    }

                //}

            }
        //even een testje, doet atm geen kwaad
        private void btn_KlaarBestelling_Click(object sender, EventArgs e, TafelOverzicht tm_tafel1)
        {
            //tm_tafel1.Stop();
        }
    }

}
