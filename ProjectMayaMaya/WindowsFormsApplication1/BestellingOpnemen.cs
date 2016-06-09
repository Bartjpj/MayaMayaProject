﻿using System;
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
                    BesteldeItemClass besteldItem = (BesteldeItemClass)isItemAlEensBesteld.Tag;
                    besteldItem.aantal++;
                    isItemAlEensBesteld.Tag = besteldItem;
                }
                else
                {
                    isItemAlEensBesteld = new ListViewItem(GeselecteerdeItem.naam);
                    isItemAlEensBesteld.SubItems.Add("1");
                    isItemAlEensBesteld.Tag = new BesteldeItemClass(GeselecteerdeItem.menu_id, GeselecteerdeItem.categorie_id, GeselecteerdeItem.naam, GeselecteerdeItem.prijs, GeselecteerdeItem.voorraad, 1, "");
                    listview_huidige_bestelling.Items.Add(isItemAlEensBesteld);
                }
            }
        }


        private void listview_huidige_bestelling_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection regels = this.listview_huidige_bestelling.SelectedItems;

            foreach (ListViewItem regel in regels)
            {
                BesteldeItemClass itemUitRegel = (BesteldeItemClass)regel.Tag;
                ListViewItem isRegelNogZichtbaar = listview_diner.FindItemWithText(itemUitRegel.naam);

                if (isRegelNogZichtbaar != null) //wanneer in de forms een andere pagina open is dan pakt hij een andere manier van verwijderen.
                {
                    if (itemUitRegel.aantal < 2)
                    {
                        ListViewItem menuRegel = listview_diner.FindItemWithText(itemUitRegel.naam);
                        MenuItemsClass itemUitMenu = (MenuItemsClass)menuRegel.Tag;
                        itemUitMenu.voorraad++;
                        menuRegel.Tag = itemUitMenu;
                        menuRegel.SubItems[2].Text = (int.Parse(menuRegel.SubItems[2].Text) + 1).ToString();
                        listview_huidige_bestelling.Items.Remove(regel);
                    }
                    else
                    {
                        ListViewItem menuRegel = listview_diner.FindItemWithText(itemUitRegel.naam);
                        MenuItemsClass itemUitMenu = (MenuItemsClass)menuRegel.Tag;
                        itemUitMenu.voorraad++;
                        menuRegel.Tag = itemUitMenu;
                        menuRegel.SubItems[2].Text = (int.Parse(menuRegel.SubItems[2].Text) + 1).ToString();
                        regel.SubItems[1].Text = (int.Parse(regel.SubItems[1].Text) - 1).ToString();
                        itemUitRegel.aantal--;
                        regel.Tag = itemUitRegel;
                    }
                }
                else
                {
                    if (itemUitRegel.aantal < 2)
                    {
                        listview_huidige_bestelling.Items.Remove(regel);
                    }
                    else
                    {
                        BesteldeItemClass isItemAlBesteld = (BesteldeItemClass)regel.Tag;
                        isItemAlBesteld.aantal--;
                        regel.Tag = isItemAlBesteld;
                        regel.SubItems[1].Text = (int.Parse(regel.SubItems[1].Text) - 1).ToString();
                    }
                }

                    
            }


        }

        private void btn_verwijderGerecht_Click(object sender, EventArgs e)
        {
            listview_huidige_bestelling.Items.Clear();
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

        bool start = false;
        
        public void startenTimer()
        {
            start = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            startenTimer();
        }
 
    }

}

