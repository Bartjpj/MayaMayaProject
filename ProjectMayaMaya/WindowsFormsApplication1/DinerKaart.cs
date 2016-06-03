using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
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
        MenuItemsClass dinerKaartClass = new MenuItemsClass(0, 0, "", 0, 0);

        bool starttimer = false;
        TafelOverzicht tm_tafel1;

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


            foreach (MenuItemsClass dinerItem in DinerKaartDAO.haalDinerKaartOp(4, 7)) //Alle informatie die in de list staat wordt in de listview geschreven
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
            ListView.SelectedListViewItemCollection SelectieBestellingItems = this.listview_diner.SelectedItems;

            foreach (ListViewItem BestellingItem in SelectieBestellingItems)
            {

                MenuItemsClass GeselecteerdeItem = (MenuItemsClass)BestellingItem.Tag;

                if (GeselecteerdeItem.voorraad < 1) //error
                {
                    NietOpVoorraadAlert itemNietOpVoorraad = new NietOpVoorraadAlert();
                    itemNietOpVoorraad.Show(this);
                    return;
                }
                GeselecteerdeItem.voorraad--;
                int aantalBesteldeItems = int.Parse(BestellingItem.SubItems[2].Text);
                aantalBesteldeItems--;
                BestellingItem.SubItems[2].Text = aantalBesteldeItems.ToString();

                ListViewItem locatie = listview_huidige_bestelling.FindItemWithText(GeselecteerdeItem.naam);

                if (locatie != null)
                {
                    locatie.SubItems[1].Text = (int.Parse(locatie.SubItems[1].Text) + 1).ToString();
                    ListViewItem selecteerbareRegel = listview_diner.FindItemWithText(GeselecteerdeItem.naam);
                }
                else
                {
                    ListViewItem bestelItem = new ListViewItem(GeselecteerdeItem.naam);
                    bestelItem.SubItems.Add("1");
                    listview_huidige_bestelling.Items.Add(bestelItem);

                }
            }
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

        public void button1_Click(object sender, EventArgs e)
        {
            starttimer = true;
            StartenTimer(starttimer);
        }
        
        public void StartenTimer(bool starttimer)
        {
            if (starttimer == true)
            {
                //tm_tafel1.Enabled = true;
            }
        }


        // DIT IS DE TIMER, MOET NOG 1 DING FIXEN MET DE BUTTON

    }

}


