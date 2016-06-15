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
        //private TafelOverzicht tafelOverzicht;
        List<MenuItemsClass> DinerKaartLijst = new List<MenuItemsClass>();
        //TafelOverzicht tafelOverzicht = new TafelOverzicht();




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
                btn.Size = new Size(120, 49);
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
        //---------------------------TAFELGETAL INITIALIZEREN------------------
        public int tafelgetal;
        public int GetalTafel
        {
            get { return tafelgetal; }
            set { tafelgetal = value; }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            DateTime tijdnu = DateTime.Now;
            TafelOverzicht openen = new TafelOverzicht();
            if (tafelgetal == 1)
            {
                openen.Label1Text = tijdnu.ToString("H:mm");
            }

            openen.Show(this);
        }

        private void btn_stuurbestelling_Click_1(object sender, EventArgs e)
        {
            ListView.ListViewItemCollection besteldeItems = listview_huidige_bestelling.Items;
            List<int> BarMenu_ID = new List<int>();
            List<int> BarAantal = new List<int>();
            List<int> KeukenMenu_ID = new List<int>();
            List<int> KeukenAantal = new List<int>();

            ListViewItem KeukenBestelling = new ListViewItem();

            foreach (ListViewItem regel in besteldeItems)
            {
                BesteldeItemClass besteldItem = (BesteldeItemClass)regel.Tag;
                if (besteldItem.categorie_id >= 8)
                {
                    //alle dranken
                    BarMenu_ID.Add(besteldItem.menu_id);
                    BarAantal.Add(besteldItem.aantal);
                }
                else
                {
                    // alle gerechten
                    KeukenMenu_ID.Add(besteldItem.menu_id);
                    KeukenAantal.Add(besteldItem.aantal);
                }
                MenuItemsDAO.WijzigVoorraad(besteldItem.menu_id, besteldItem.aantal);
            }



            //if (tafel == 1)
            //{
            //    timerenable1 = true;
            //    system.timers.timer t1 = new system.timers.timer();
            //    t1.interval = 1000;
            //    t1.elapsed += new elapsedeventhandler(idontknow.t1_tick);
            //}
            // int tafel = 5;
            string opmerking = txt_opmerking.Text;

            //if (checkbox_keuken.Checked && checkbox_bar.Checked) {
            //        barOpmerking = txt_opmerking.Text;
            //        keukenOpmerking = txt_opmerking.Text;
            //    }
            //    else if (checkbox_keuken.Checked)
            //    {
            //        keukenOpmerking = txt_opmerking.Text;
            //        barOpmerking = txt_opmerking.Text;
            //    }
            //    else if (checkbox_bar.Checked)
            //    {
            //        barOpmerking = txt_opmerking.Text;
            //    }
            //    else
            //    {
            //        keukenOpmerking = "";
            //        barOpmerking = txt_opmerking.Text;
            //}

            if (checkbox_bar.Checked && checkbox_keuken.Checked) //er wordt een code meegegeven aan de query, waardoor het systeem weet of dit voor de keuken, bar of beide bestemd is.
            {
                opmerking = "0083" + opmerking;
            } else if (checkbox_keuken.Checked){
                opmerking = "0082" + opmerking;
            } else if (checkbox_bar.Checked) {
                opmerking = "0081" + opmerking;
            }


            DateTime actueleTijd = DateTime.Now;
            int personeels_id = 1; //wijzigen!!
            int tafel = tafelgetal;

            List<int> bestellingIDs = MenuItemsDAO.haalBestellingIdOp();
            int hoogsteBestellingID = bestellingIDs.Max();
            int barBestellingID = hoogsteBestellingID + 1;
            int keukenBestellingID = barBestellingID + 1;

            MenuItemsDAO.VerstuurBestelling(BarMenu_ID, BarAantal, tafel, barBestellingID, actueleTijd, opmerking, personeels_id);
            MenuItemsDAO.VerstuurBestelling(KeukenMenu_ID, KeukenAantal, tafel, keukenBestellingID, actueleTijd, opmerking, personeels_id);


            //-----------------------------ZETTEN VAN TIJDSTIP VAN GEPLAATSTE BESTELLING------------------------
            DateTime tijdnu = DateTime.Now;
            TafelOverzicht openen = new TafelOverzicht();
            //TafelOverzicht tafeloverzicht;
            //TafelOverzicht.tafeloverzicht.Show(this);
            if (tafelgetal == 1)
            {
                openen.Label1Text = tijdnu.ToString("H:mm");
                openen.ButtonColor1 = Color.LightSkyBlue;
            }

            if (tafelgetal == 2)
            {
                openen.Label2Text = tijdnu.ToString("H:mm");
                openen.ButtonColor2 = Color.LightSkyBlue;
            }

            if (tafelgetal == 3)
            {
                openen.Label3Text = tijdnu.ToString("H:mm");
                openen.ButtonColor3 = Color.LightSkyBlue;
            }

            if (tafelgetal == 4)
            {
                openen.Label4Text = tijdnu.ToString("H:mm");
                openen.ButtonColor4 = Color.LightSkyBlue;
            }

            if (tafelgetal == 5)
            {
                openen.Label5Text = tijdnu.ToString("H:mm");
                openen.ButtonColor5 = Color.LightSkyBlue;
            }

            if (tafelgetal == 6)
            {
                openen.Label6Text = tijdnu.ToString("H:mm");
                openen.ButtonColor6 = Color.LightSkyBlue;
            }

            if (tafelgetal == 7)
            {
                openen.Label7Text = tijdnu.ToString("H:mm");
                openen.ButtonColor7 = Color.LightSkyBlue;
            }

            if (tafelgetal == 8)
            {
                openen.Label8Text = tijdnu.ToString("H:mm");
                openen.ButtonColor8 = Color.LightSkyBlue;
            }

            if (tafelgetal == 9)
            {
                openen.Label9Text = tijdnu.ToString("H:mm");
                openen.ButtonColor9 = Color.LightSkyBlue;
            }

            if (tafelgetal == 10)
            {
                openen.Label10Text = tijdnu.ToString("H:mm");
                openen.ButtonColor10 = Color.LightSkyBlue;
            }


            openen.ShowDialog(this);
            this.Close();
            //private TafelOverzicht TafelOverzicht()
            //{
            //    throw new NotImplementedException();
            //}

            //private TafelOverzicht tafelOverzicht()
            //{
            //    throw new NotImplementedException();
            //}





        }

    }
}



