using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BestellingOpnemen : Form
    {
        BestellingOpnemenDAO MenuItemsDAO;
        List<MenuItemsClass> DinerKaartLijst = new List<MenuItemsClass>();



        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }



        public BestellingOpnemen(BestellingOpnemenDAO DinerKaartDAO)
        {
            InitializeComponent();

            this.MenuItemsDAO = DinerKaartDAO; // zet bestellingdao openbaar

            List<MenukaartClass> kaarten = this.MenuItemsDAO.haalKaartenOp();

            foreach (MenukaartClass kaart in kaarten) // maak kaartbuttons aan en zet deze neer in de flowlayout
            {
                Button btn = new Button();
                btn.Text = kaart.naam;
                btn.Tag = kaart;
                btn.Size = new Size(221, 49);
                btn.Click += new System.EventHandler(this.btn_kaartCategorie_Click);
                flow_MenuKaart.Controls.Add(btn);
            }
        }

        private void btn_kaartCategorie_Click(object sender, EventArgs e) // zet alle categoriebuttons neer, wanneer er op geklikt wordt worden de menuitems weergegeven
        {
            Button b = (Button)sender;
            MenukaartClass kaart = (MenukaartClass)b.Tag;

            flow_menuCategorie.Controls.Clear();
            List<MenucategorieClass> categorieen = MenuItemsDAO.haalCategorieOp(kaart.kaart_id);

            foreach (MenucategorieClass categorie in categorieen)
            {
                Button btn = new Button();
                btn.Text = categorie.naam;
                btn.Tag = categorie;
                btn.Size = new Size(150, 49);
                btn.Click += new System.EventHandler(this.btn_categorie_Click);
                flow_menuCategorie.Controls.Add(btn);
            }

        }

        private void btn_categorie_Click(object sender, EventArgs e) // geeft alle menuitems van de menucategorie weer. Hierbij wordt ook gelet op het al bestelde aantal items.
        {
            Button b = (Button)sender;
            MenucategorieClass categorie = (MenucategorieClass)b.Tag;

            listview_diner.Items.Clear();

            List<MenuItemsClass> items = MenuItemsDAO.haalMenuItemsOp(categorie.categorie_id);

            foreach (MenuItemsClass item in items)
            {
                
                ListViewItem isGerechtAlBesteld = listview_huidige_bestelling.FindItemWithText(item.naam);
                if (isGerechtAlBesteld != null) //wanneer er al een gerecht is besteld wordt het aantal van de hoeveelheid besteldeitems van de voorraad die nog over is gehaald
                {
                    BesteldeItemClass besteldeItem = (BesteldeItemClass)isGerechtAlBesteld.Tag;
                    int besteldAantal = besteldeItem.aantal;
                    item.voorraad = item.voorraad - besteldAantal;
                }

                ListViewItem lijstItem = new ListViewItem(item.naam.ToString());
                lijstItem.SubItems.Add(item.prijs.ToString());
                lijstItem.SubItems.Add(item.voorraad.ToString());
                lijstItem.Tag = item;
                listview_diner.Items.Add(lijstItem);

            }
        }


        private void listview_diner_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection SelectieBestellingItems = this.listview_diner.SelectedItems;

            foreach (ListViewItem BestellingItem in SelectieBestellingItems)
            {

                MenuItemsClass GeselecteerdeItem = (MenuItemsClass)BestellingItem.Tag;

                if (GeselecteerdeItem.voorraad < 1)
                {
                    NietOpVoorraadAlert itemNietOpVoorraad = new NietOpVoorraadAlert();
                    itemNietOpVoorraad.Show(this);
                    return;
                }
                GeselecteerdeItem.voorraad--;
                BestellingItem.SubItems[2].Text = (int.Parse(BestellingItem.SubItems[2].Text) - 1).ToString();

                ListViewItem isItemAlEensBesteld = listview_huidige_bestelling.FindItemWithText(GeselecteerdeItem.naam);

                if (isItemAlEensBesteld != null)
                {
                    isItemAlEensBesteld.SubItems[1].Text = (int.Parse(isItemAlEensBesteld.SubItems[1].Text) + 1).ToString();
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
            foreach (TafelOverzichtClass TafelOverzicht in MenuItemsDAO.haalTafelOp())
            {

                ListViewItem TafelId = new ListViewItem(TafelOverzicht.TafelId.ToString());
                ListViewItem tafelbezet = new ListViewItem(TafelOverzicht.Bezet.ToString());
                //lijstitem.SubItems.Add(TafelOverzicht.TafelId.ToString());
                //lijstitem.SubItems.Add(TafelOverzicht.Bezet.ToString());

            }
        }
        private void btn_stuurbestelling_Click_1(object sender, EventArgs e)
        {

        }
 
    }

}


