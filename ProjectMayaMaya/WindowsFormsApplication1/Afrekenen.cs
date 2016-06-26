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
            double totaalbtwHoog = 0;
            double totaalbtwLaag = 0;
            double totaalBtw = 0;
            double subtotaal = 0;

            listview_rekening.Items.Clear();
            List<AfrekenenBLL> geheleLijst = AfrekeningDAO.haalMenuItemsOp(3);
            foreach (AfrekenenBLL afrekeningOverzicht in geheleLijst)
            {

                ListViewItem lijstItem = new ListViewItem(afrekeningOverzicht.Menuitem.ToString());
                lijstItem.SubItems.Add(afrekeningOverzicht.Aantal.ToString());
                lijstItem.SubItems.Add(afrekeningOverzicht.prijs.ToString("0.00"));
                listview_rekening.Items.Add(lijstItem);
                lijstItem.Tag = afrekeningOverzicht;

                

                if ((afrekeningOverzicht.categorie_id >= 8) && (afrekeningOverzicht.categorie_id <= 10))
                {
                    btwLaag = afrekeningOverzicht.prijs * 0.21 * afrekeningOverzicht.Aantal;
                    totaalbtwLaag += btwLaag;
                    totaalBtw += btwLaag;
                }
                else
                {
                    btwHoog = afrekeningOverzicht.prijs * 0.06 * afrekeningOverzicht.Aantal;
                    totaalbtwHoog += btwHoog;
                    totaalBtw += btwHoog;
                }
                subtotaal += afrekeningOverzicht.prijs * afrekeningOverzicht.Aantal;
            }

            lbl_btwhooggetal.Text = totaalbtwHoog.ToString("0.00");
            lbl_btwlaaggetal.Text = totaalbtwLaag.ToString("0.00");
            lbl_totaalBTW.Text = totaalBtw.ToString("0.00");
            lbl_subtotaalgetal.Text = subtotaal.ToString("0.00");
            lbl_GhostSubtotaal.Text = subtotaal.ToString("0.00");
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double fooinummer = 0;
            double laatsteGetal = 0;
            bool isGelukt = double.TryParse(txt_fooi.Text, out fooinummer);
            if (isGelukt)
            {
                double subtotaal = double.Parse(lbl_GhostSubtotaal.Text);
                double NieuwSubtotaal = fooinummer + subtotaal;
                lbl_subtotaalgetal.Text = NieuwSubtotaal.ToString();
                laatsteGetal = double.Parse(txt_fooi.Text);
                
            }
            else
            {

                lbl_subtotaalgetal.Text = (double.Parse(lbl_GhostSubtotaal.Text) - laatsteGetal).ToString("0.00");
            }
        }


        private void btn_printrekening_Click(object sender, EventArgs e)
        {
            //dit is nutteloos, net te laat.
            string opmerking = "";
            opmerking =  "'" + txt_Opmerking.Text + "'";
            List<int> Rekening_IDs = AfrekeningDAO.haalRekeningIdOp();
            int hoogsteRekeningID = Rekening_IDs.Max();
            int NieuweRekeningID = hoogsteRekeningID + 1;
            List<int> bestellingID = AfrekeningDAO.haalBestellingIDsOp(3);
            int hoogsteBestellingID = bestellingID.Max();
            int nieuweBestellingID = hoogsteBestellingID + 1;
            DateTime actueleTijd = DateTime.Now;
            

            double prijs = Double.Parse(lbl_subtotaalgetal.Text);
            AfrekeningDAO.VerstuurBestellingBar(NieuweRekeningID, nieuweBestellingID, actueleTijd, prijs, opmerking);


            
            listview_rekening.Items.Clear();
            this.Close();
        }

        }
    }
