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
    public partial class BestellingMenu : TafelOverzicht
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

        public void btn_stuurbestelling_Click(object sender, EventArgs e)
        {
            int hour, min, sec, ms = 0;
            int tafelnr = tafelgetal;

            //if (tafelnr == 1)
            //{
            //    TafelOverzicht.tm_tafel1.Start();
            //    TafelOverzicht.btn_Tafel1.BackColor = Color.Red;
            //        Timer t1;
            //        t1 = new Timer();
            //        t1.Start();

            //        if (t1.Tick() += 60 = true)
            //        {
            //            min++;
            //            t1.Stop();
            //            t1.Start();
            //        }
                //s1.Start();

                //for (int i = 0; i < 1000; i++)
                //{
                //    System.Threading.Thread.Sleep(10);
                //}
                //s1.Stop();
                //lbl_tijdtafel1.Text = "{:mm}"; s1.Elapsed();
            }

        }
    }
