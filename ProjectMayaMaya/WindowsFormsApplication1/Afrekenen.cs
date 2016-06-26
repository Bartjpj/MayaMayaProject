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
        List<AfrekenenBLL> afrekenLijst = new List<AfrekenenBLL>();
        AfrekenenDAO AfrekeningDAO;

        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
     
        public Afrekenen(AfrekenenDAO AfrekeningDAO)
        {
            InitializeComponent();
            this.AfrekeningDAO = AfrekeningDAO;

            afrekenLijst = AfrekeningDAO.haalMenuItemsOp(3);

            DisplayBestellingen();
        }

 

        private void BTN_AFREKENENnaarTAFELOVERZICHT_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesOpname = new KiesOpname();
            openKiesOpname.Show(this);
            this.Hide();
        }
        public int tafelgetal;
        //public int GetalTafel
        //{
         //   get { return tafelgetal; }
        //    set { tafelgetal = value; }
       // }
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
            int tafelNr = tafelOverzicht.tafelgetal;
            //lbl_klaargemeld.Text = tafelnr.ToString();

        }
        public bool klaarmelden = false;

        public void btn_cbutton_Click(object sender, EventArgs e)
        {
            int tafelnr = tafelOverzicht.tafelgetal;
            if (tafelnr == 1)
                klaarmelden = true;

        }

        private void listview_rekening_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBestellingen()
        {
            double btwHoog = 0;
            double btwLaag = 0;
            double totaalBtw = 0;
            double subtotaal = 0;

            listview_rekening.Items.Clear();
            List<AfrekenenBLL> geheleLijst = AfrekeningDAO.haalMenuItemsOp(3);
            foreach (AfrekenenBLL afrekeningOverzicht in geheleLijst)
            {

                ListViewItem lijstItem = new ListViewItem(afrekeningOverzicht.Menuitem.ToString());
                lijstItem.SubItems.Add(afrekeningOverzicht.Aantal.ToString());
                lijstItem.SubItems.Add(afrekeningOverzicht.prijs.ToString());
                listview_rekening.Items.Add(lijstItem);
                lijstItem.Tag = afrekeningOverzicht;

                

                if ((afrekeningOverzicht.categorie_id >= 8) && (afrekeningOverzicht.categorie_id <= 10))
                {
                    btwLaag += afrekeningOverzicht.prijs * 0.06;
                    totaalBtw = totaalBtw + btwLaag;
                }
                else
                {
                    btwHoog += afrekeningOverzicht.prijs * 0.21;
                    totaalBtw = totaalBtw + btwHoog;
                }
                subtotaal += afrekeningOverzicht.prijs;
            }

            lbl_btwhooggetal.Text = btwHoog.ToString();
            lbl_btwlaaggetal.Text = btwLaag.ToString();
            lbl_totaalBTW.Text = totaalBtw.ToString();
            lbl_subtotaalgetal.Text = subtotaal.ToString();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_printrekening_Click(object sender, EventArgs e)
        {
            //dit is nutteloos, net te laat.
            string opmerking = txt_Opmerking.Text;
            List<int> Rekening_IDs = AfrekeningDAO.haalRekeningIdOp();
            int hoogsteRekeningID = Rekening_IDs.Max();
            int NieuweRekeningID = hoogsteRekeningID + 1;
            List<int> bestellingID = AfrekeningDAO.haalBestellingIDsOp(3);
            DateTime actueleTijd = DateTime.Now;

            List<int> rekening_id = new List<int>();
            List<int> bestelling_id = new List<int>();
            List<int> prijs = new List<int>();

            ListView.ListViewItemCollection bepaaldeVariabele = listview_rekening.Items;

            foreach (ListViewItem rij in bepaaldeVariabele)
            {
                AfrekenenBLL rekeningItem = (AfrekenenBLL)rij.Tag;
            }


            listview_rekening.Items.Clear();
        }

        }
    }
