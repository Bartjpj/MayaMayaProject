using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TafelOverzicht : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing voor de grootte van de form, niets veranderen AUB
        {
            //base.OnLoad(e);
            //this.Location = Owner.Location;
            //this.Size = Owner.Size;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (TafelOverzichtClass TafelOverzicht in TafelOverzichtDAO.haalTafelOverzicht_TabelOp())
            {

                ListViewItem TafelId = new ListViewItem(TafelOverzicht.TafelId.ToString());
                ListViewItem tafelbezet = new ListViewItem(TafelOverzicht.Bezet.ToString());
                //lijstitem.SubItems.Add(TafelOverzicht.TafelId.ToString());
                //lijstitem.SubItems.Add(TafelOverzicht.Bezet.ToString());
            }
        }
        private void rbtn_BestellingOpnemen_CheckedChanged(object sender, EventArgs e)
        {

        }
        //-----------------TAFELS--------------------------------:
        // BestellingMenu bestellingmenuActiveren = new BestellingMenu();
        int tafelgetal;




        //1
        public void btn_Tafel1_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname1 = new KiesOpname();
            openKiesopname1.Show(this);

            tafelgetal = 1;
            updateTafelID();

            maakTimer1();

        }
        public void maakTimer1() // maken timer 1
        {
            System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            t1.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t1.Tick += new EventHandler(t1_Tick);
            t1.Enabled = true;

        }
        int min;
        private void t1_Tick(object sender, EventArgs e)
        {

            btn_Tafel1.BackColor = Color.LightSkyBlue;

            min++;
            lbl_test1.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel1.BackColor = Color.IndianRed;
                btn_Tafel1.ForeColor = Color.White;
            }

        }






        //2
        public void btn_Tafel2_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //3
        public void btn_Tafel3_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //4
        public void btn_Tafel4_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //5
        public void btn_Tafel5_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //6
        public void btn_Tafel6_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //7
        public void btn_Tafel7_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //8
        public void btn_Tafel8_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //9
        public void btn_Tafel9_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //10
        public void btn_Tafel10_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }
        //---------------TIMERS-------------------------:
        //zetten van int voor de timer


        public void lbl_tijdtafel1_Click(object sender, EventArgs e)
        {
        }
        public void updateTafelID()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Table SET TafelId = " + tafelgetal, conn);
        }


    }
}
