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
        DinerKaartDAO DinerKaartDAO;
        List<DinerKaartClass> DinerKaartLijst = new List<DinerKaartClass>();
        DinerKaartClass dinerKaartClass = new DinerKaartClass(0,0,"",0,0);
        List<int> TotalebestellingLijst = new List<int>();
        int i = 0;
        



        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

 

        public DinerKaart(DinerKaartDAO DinerKaartDAO)
        {
            InitializeComponent();

            this.DinerKaartDAO = DinerKaartDAO; // zet bestellingdao openbaar

            foreach (DinerKaartClass dinerOverzicht in DinerKaartDAO.haalDinerKaart_TabelOp()) //Alle informatie die in de list staat wordt in de listview geschreven
            {

                ListViewItem lijstItem = new ListViewItem(dinerOverzicht.naam.ToString());
                lijstItem.SubItems.Add(dinerOverzicht.prijs.ToString());
                lijstItem.SubItems.Add(dinerOverzicht.voorraad.ToString());
                listview_diner.Items.Add(lijstItem);
            }
        }

        //listview_diner_SelectedIndexChanged
        private void listview_diner_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            ListView.SelectedListViewItemCollection SelectieBestellingItems = this.listview_diner.SelectedItems;

            foreach (ListViewItem BestellingItem in SelectieBestellingItems)
            {
                
                DinerKaartClass GeselecteerdeItem = (DinerKaartClass)BestellingItem.Tag;

                if (GeselecteerdeItem.voorraad < 1) //error
                {
                    NietOpVoorraadAlert itemNietOpVoorraad = new NietOpVoorraadAlert();
                    itemNietOpVoorraad.Show(this);
                    return;
                }
                GeselecteerdeItem.voorraad--;
                int aantalBesteldeItems = int.Parse(BestellingItem.SubItems[2].Text);
                aantalBesteldeItems--;
                BestellingItem.SubItems[2].Text = string.Format("{0:00}", aantalBesteldeItems);

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

















//                foreach (listviewitem kaartitem in listview_diner.selecteditems)
//            {
//                    // voeg een item toe aan de bestelling, wanneer dit item er al in zit moet er 1 bij aantal worden opgeteld.
//                    //wanneer het item er niet in zit wordt deze nieuw aangemaakt en met 1 toegevoegd.
////                    listviewitem aangepastitem = (listviewitem)item.clone(); //clone item die geselecteerd is
//                    int meerderekerenbesteld = 1;
//                    if (listview_huidige_bestelling.finditemwithtext(kaartitem.text).text == listview_diner.selecteditems.tostring()) 
//                    {
//                        listviewitem updateaantal = listview_diner.selecteditems[0];
//                        updateaantal.subitems[0].text = meerderekerenbesteld++.tostring();


//                    } else {
//                    listviewitem bestelitem = new listviewitem(kaartitem.text); 
//                    bestelitem.subitems.add(meerderekerenbesteld.tostring());
//                    listview_huidige_bestelling.items.add(bestelitem);  //voegt het geselecteerde item toe aan de list van totalebestelling
//                    }
                    
//            }
            
        }

        private void btn_verwijderGerecht_Click(object sender, EventArgs e)
        {
        //    for (int i = listbox_added_items.selectedindices.count - 1; i >= 0; i--)
        //    {
        //        listbox_added_items.items.removeat(listbox_added_items.selectedindices[i]);

        //            foreach (dinerkaartclass dineroverzicht in dinerkaartdao.haaldinerkaart_tabelop())
        //            {
        //                if (listbox_added_items.tostring() == dineroverzicht.naam.tostring())
        //                 {
        //                         totalebestellinglijst.remove(dineroverzicht.menu_id); //slaat alle menu_id's op in een lijst, deze kan de bar makkelijk snappen.

        //                 }

        //            }

        //    }

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


