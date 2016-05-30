using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Timers.Timer;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DinerKaart : Form
    {
        DinerKaartDAO DinerKaartDAO;
        List<DinerKaartClass> DinerKaartLijst = new List<DinerKaartClass>();


        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

 

        public DinerKaart(DinerKaartDAO DinerKaartDAO)
        {
            InitializeComponent();

            this.DinerKaartDAO = DinerKaartDAO; // zet bestellingdao

            DinerKaartLijst = DinerKaartDAO.haalDinerKaart_TabelOp(); // haal de bestelling op



            foreach (DinerKaartClass dinerOverzicht in DinerKaartDAO.haalDinerKaart_TabelOp())
            {
                ListViewItem lijstItem = new ListViewItem(dinerOverzicht.naam.ToString());
                lijstItem.SubItems.Add(dinerOverzicht.prijs.ToString());
                lijstItem.SubItems.Add(dinerOverzicht.voorraad.ToString());
                listview_diner.Items.Add(lijstItem);

            }
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


        private void btn_stuurbestelling_Click(object sender, EventArgs e, TafelOverzicht btn_Tafel1, int tafelgetal, TafelOverzicht lbl_tijdtafel1, keukenBestellingOverzicht btn_gereedkeuken_Click)
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
            //    bool bestelling_gereed = false;

            //    while(btn_gereedkeuken.PerformClick() == false)
            //    if (ms >= 10)
            //    {
            //        sec++;
            //        ms = 0;
            //    }
            //    if (sec >= 60)
            //    {
            //        min++;
            //        sec = 0;
            //        lbl_tijdtafel1.Text = min.ToString();
                    
            //    }
            //    if (min >= 30)
            //    {
            //        btn_Tafel1.BackColor = Color.Maroon;
            //    }

            //}
        }

        private void btn_stuurbestelling_Click(object sender, EventArgs e)
        {

        }
    }
}
