using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
//using System.Timers.Timer;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DinerKaart : Form
    {
        MenuItemsDAO MenuItemsDAO;
        List<MenuItemsClass> DinerKaartLijst = new List<MenuItemsClass>();
        MenuItemsClass dinerKaartClass = new MenuItemsClass(0,0,"",0,0);
        
        int i = 0;
        



        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

 

        public DinerKaart(MenuItemsDAO DinerKaartDAO)
        {
            InitializeComponent();

            this.MenuItemsDAO = DinerKaartDAO; // zet bestellingdao openbaar
            

            foreach (MenuItemsClass dinerItem in DinerKaartDAO.haalDinerKaartOp(4,7)) //Alle informatie die in de list staat wordt in de listview geschreven
            {

                ListViewItem lijstItem = new ListViewItem(dinerItem.naam.ToString());
                lijstItem.SubItems.Add(dinerItem.prijs.ToString());
                lijstItem.SubItems.Add(dinerItem.voorraad.ToString());
                lijstItem.Tag = dinerItem;
                listview_diner.Items.Add(lijstItem);
            }
        }

        //listview_diner_SelectedIndexChanged
        private void listview_diner_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void listview_huidige_bestelling_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_verwijderGerecht_Click(object sender, EventArgs e)
        {
            //listview_huidige_bestelling.Items.Clear();
        }

        private void btn_LUNCHnaarDRANKEN_Click(object sender, EventArgs e)
        {
            DrankenKaart openDrankenkaart = new DrankenKaart();
            openDrankenkaart.Show(this);
            this.Hide();
        }

        private void btn_DINERnaarBESTELLING_Click(object sender, EventArgs e)
        {
            BestellingMenu openBestellingMenu = new BestellingMenu();
            openBestellingMenu.Show(this);
            this.Hide();
        }

            


        private void btn_stuurbestelling_Click(object sender, EventArgs e)
        {

        }
        // DIT IS DE TIMER, MOET NOG 1 DING FIXEN MET DE BUTTON
        private void btn_stuurbestelling_Click(object sender, EventArgs e, TafelOverzicht btn_Tafel1, int tafelgetal, TafelOverzicht lbl_tijdtafel1, bool bestelling_gereed)
        {
            //int min = 0;
            //int sec = 0;
            //int ms = 0;
            //int tafelnr = tafelgetal;

            //if (tafelgetal == 1)
            //{
            //    Timer t1 = new Timer();
            //    t1.Enabled = true;
            //    t1.Start();

            //    while (bestelling_gereed == false)
            //    {
            //        if (ms >= 10)
            //        {
            //            sec++;
            //            ms = 0;
            //        }
            //        if (sec >= 1)
            //        {
            //            min++;
            //            sec = 0;
            //            lbl_tijdtafel1.Text = min.ToString();

            //        }
            //        if (min >= 5)
            //        {
            //            btn_Tafel1.BackColor = Color.Maroon;
            //        }
            //    }
            //}


    }
}
}


