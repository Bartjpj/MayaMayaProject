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


        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        public Afrekenen()
        {
            InitializeComponent();


            waardenInvoegen();

        }

        public void waardenInvoegen()
        {
        //string opmerking = txt_Opmerking.Text;
        //int bijFooi = Int32.Parse(txt_fooi.Text); //wanneer er iets nieuws ingetikt wordt bij fooi moet subtotaal een nieuwe waarden krijgen
        //int btwHoog = 0;
        //int btwLaag = 0;
        //int totaalBtw = 0;
        //int subtotaal = 0;

        //ListView.ListViewItemCollection bepaaldeVariabele = listview_rekening.Items;

        //foreach (ListViewItem rij in bepaaldeVariabele)
        //{
        //    if (rij.categorie >= 8)
        //    {
        //        btwLaag += rij.prijs * 0.06;
        //        totaalBtw += btwLaag;
        //    }
        //    else
        //    {
        //        btwHoog += rij.prijs * 0.21;
        //        totaalBtw += btwLaag;
        //    }
        //    subtotaal += rij.prijs;
        //}
        //lbl_btwhooggetal.Text = btwHoog.ToString();
        //lbl_btwlaaggetal.Text = btwLaag.ToString();
        //lbl_totaalBTW.Text = totaalBtw.ToString();
        //lbl_subtotaalgetal.Text = subtotaal.ToString();
        }

        //private void updateWaarden()
        //{
        public int _tafelgetal;
        public int _GetalTafel
        {
            get { return _tafelgetal; }
            set { _tafelgetal = value; }
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
            int tafelnr = tafelOverzicht.tafelgetal;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_printrekening_Click(object sender, EventArgs e)
        {
            listview_rekening.Items.Clear();
        }

        private void Afrekenen_Load(object sender, EventArgs e)
        {

        }
    }
}
//namespace RBS
//{ 
// public partial class Rekening : Form
// {
//  public Tafel tafel;
//  public Bestelling bestelling;
//  public Betaling betaling;
//        public decimal prijs_ex;
//        public decimal prijs_inc;
//        public decimal prijs_btw;
//        public decimal prijs_fooi;
//        public decimal prijs_totaal;
//        public decimal prijs_contant;
//        public decimal prijs_wisselgeld;

//        public Rekening(Tafel tafel)
//        {
//            InitializeComponent();
//            this.tafel = tafel;
//            UpdateWaarden();
//        }

//        private void UpdateWaarden()
//        {
//            prijs_ex = 5; //tijdelijk
//            prijs_inc = 5;
//            prijs_btw = 5;
//            prijs_fooi = decimal.Parse(txt_Fooi.Text);
//            prijs_totaal = prijs_inc + prijs_fooi;
//            prijs_contant = decimal.Parse(txt_Contant.Text);

//            if ((prijs_totaal - prijs_contant) <= 0)
//            {
//                prijs_wisselgeld = prijs_contant - prijs_totaal;
//            }
//            else
//            {
//                prijs_wisselgeld = 0;
//            }

//            this.lbl_Subtotaal.Text = string.Format("{0:0.00}", prijs_ex);
//            this.lbl_BTW.Text = string.Format("{0:0.00}", prijs_btw);
//            this.lbl_Totaal.Text = string.Format("{0:0.00}", prijs_totaal);
//            this.lbl_Wisselgeld.Text = string.Format("{0:0.00}", prijs_wisselgeld);
//        }

//        private void FooiOnUpdate(object sender, EventArgs e)
//  {
//            //check voor geldige invoer door te proberen te parsen, check voor e omdat die wel door de eerste test komt
//            double a;
//            if (!double.TryParse(txt_Fooi.Text, out a) || txt_Fooi.Text.Contains("e"))
//            {
//                txt_Fooi.Text = "0";
//            }

//            //update variabelen
//            UpdateWaarden();
//        }

//        private void ContantOnUpdate(object sender, EventArgs e)
//        {
//            //check voor geldige invoer door te proberen te parsen, check voor e omdat die wel door de eerste test komt
//            double a;
//            if (!double.TryParse(txt_Contant.Text, out a) || txt_Contant.Text.Contains("e"))
//            {
//                txt_Contant.Text = "0";
//            }

//            //update variabelen
//            UpdateWaarden();
//        }

//        private void btn_Betalen_Click(object sender, EventArgs e)
//  {
//   //open alert adhv betaalmethode
//   string message;
//   if (rad_Contant.Checked)
//   {
//    message = string.Format("De klant betaald het bedrag van €{0} met €{1}. Klopt dit?", prijs_totaal, prijs_contant);
//   }
//   else if(rad_PIN.Checked)
//   {
//    message = string.Format("De klant betaald het bedrag van €{0} met pin. Klopt dit?", prijs_totaal);
//   }
//   else
//   {
//    message = string.Format("De klant betaald het bedrag van €{0} met credit card. Klopt dit?", prijs_totaal);
//   }

//   if (MessageBox.Show(message, "Let op", MessageBoxButtons.OKCancel) == DialogResult.OK)
//            {
//    //Betaling afronden en in de database zetten
//    this.Close();
//            }
//  }

//  private void lbl_Terug_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
//  {
//   if (MessageBox.Show("Weet u zeker dat u de betaling wilt afbreken?", "Let op", MessageBoxButtons.OKCancel) == DialogResult.OK)
//   {
//    this.Close();
//   }
//  }

//  private void rad_Contant_CheckedChanged(object sender, EventArgs e)
//  {
//   //laat contantbox alleen zien als dat nodig is
//   if (rad_Contant.Checked)
//   {
//    Box_Contant.Show();
//   }
//   else if (!rad_Contant.Checked)
//   {
//    Box_Contant.Hide();
//   }
//  }
// }
//}