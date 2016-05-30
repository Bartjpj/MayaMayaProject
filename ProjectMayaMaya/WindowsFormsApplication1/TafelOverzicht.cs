using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TafelOverzicht : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing voor de grootte van de form, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        TafelOverzichtDAO TafelOverzichtDAO;
        List<TafelOverzichtClass> tafellijst = new List<TafelOverzichtClass>();
       
        public TafelOverzicht()
        {
            InitializeComponent();
        }

        private void btn_TAFELnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left;
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }

        private void rbtn_BestellingOpnemen_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void button1_Click(object sender, EventArgs e)
        {
            foreach (TafelOverzichtClass TafelOverzicht in TafelOverzichtDAO.haalTafelOverzicht_TabelOp())
            {

                ListViewItem lijstitem = new ListViewItem(TafelOverzicht.TafelId.ToString());
                lijstitem.SubItems.Add(TafelOverzicht.TafelId.ToString());
                lijstitem.SubItems.Add(TafelOverzicht.Bezet.ToString());
                lstbox_tafeloverzicht.Items.Add(lijstitem);

            }
        }

        //-----------------TAFELS--------------------------------:
        int tafelgetal;
       // BestellingMenu bestellingmenuActiveren = new BestellingMenu();


        //1
        public void btn_Tafel1_Click(object sender, EventArgs e)
        {
            tafelgetal = 1;
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();

        }
        //2
        public void btn_Tafel2_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //3
        public void btn_Tafel3_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //4
        public void btn_Tafel4_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //5
        public void btn_Tafel5_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //6
        public void btn_Tafel6_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //7
        public void btn_Tafel7_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //8
        public void btn_Tafel8_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //9
        public void btn_Tafel9_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //10
        public void btn_Tafel10_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.Hide();
        }

        //---------------TIMERS-------------------------:
        //zetten van int voor de timer
        int hour, min, sec, ms = 0;

        //1
        public void tm_tafel1_Tick(object sender, EventArgs e)
        {
            //lbl_tijdtafel1.Text = min + ": Min";
            //ms++;
            //if (ms > 10)
            //{
            //    sec++;
            //    ms = 0;
            //}
            //else
            //    ms++;

            //if (sec > 60)
            //{
            //    min++;
            //    sec = 0;
            //}

            //if (min >= 30)
            //{
            //    btn_Tafel1.BackColor = Color.Maroon;
            //}
            //if (min > 60)
            //{
            //    hour++;
            //    min = 0;
            //}
        }

        public void lbl_tijdtafel1_Click(object sender, EventArgs e)
        {
        }



    }
}
