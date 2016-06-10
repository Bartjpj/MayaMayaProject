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
using System.Threading;
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
        public int tafelgetal;



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

        //-----------------TAFELS--------------------------------:
        // BestellingMenu bestellingmenuActiveren = new BestellingMenu();
        public int tafelgetal;
        //1
        public void btn_Tafel1_Click(object sender, EventArgs e)
        {
            tafelgetal = 1;
            KiesOpname openKiesopname1 = new KiesOpname();
            openKiesopname1.Show(this);
            openKiesopname1.GetalTafel = tafelgetal;
        }
        public string Label1Text
        {
            get { return lbl_test1.Text; }
            set { lbl_test1.Text = value; }
        }

        //2
        public void btn_Tafel2_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

            tafelgetal = 2;
            openKiesopname.GetalTafel = tafelgetal;
        }
        public string Label2Text
        {
            get { return lnl_tijdtafel2.Text; }
            set { lnl_tijdtafel2.Text = value; }
        }

        //3
        public void btn_Tafel3_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 3;

            //updateTafelID();

        }
        public string Label3Text
        {
            get { return lbl_tijdtafel3.Text; }
            set { lbl_tijdtafel3.Text = value; }
        }

        //4
        public void btn_Tafel4_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 4;

            //updateTafelID();

        }
        public string Label4Text
        {
            get { return lbl_tijdtafel4.Text; }
            set { lbl_tijdtafel4.Text = value; }
        }

        //5
        public void btn_Tafel5_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 5;

            //updateTafelID();

        }
        public string Label5Text
        {
            get { return lbl_tijdtafel5.Text; }
            set { lbl_tijdtafel5.Text = value; }
        }
        //6
        public void btn_Tafel6_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 6;

            //updateTafelID();

        }
        public string Label6Text
        {
            get { return lbl_tijdtafel6.Text; }
            set { lbl_tijdtafel6.Text = value; }
        }

        //7
        public void btn_Tafel7_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 7;

            //updateTafelID();

        }
        public string Label7Text
        {
            get { return lbl_tijdtafel7.Text; }
            set { lbl_tijdtafel7.Text = value; }
        }
        //8
        public void btn_Tafel8_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 8;

            //updateTafelID();

        }
        public string Label8Text
        {
            get { return lbl_tijdtafel8.Text; }
            set { lbl_tijdtafel8.Text = value; }
        }
        //9
        public void btn_Tafel9_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 9;

            //updateTafelID();

        }
        public string Label9Text
        {
            get { return lbl_tijdtafel9.Text; }
            set { lbl_tijdtafel9.Text = value; }
        }
        //10
        public void btn_Tafel10_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            this.tafelgetal = 10;

            //updateTafelID();

        }
        public string Label10Text
        {
            get { return lbl_tijdtafel10.Text; }
            set { lbl_tijdtafel10.Text = value; }
        }

        public void lbl_tijdtafel1_Click(object sender, EventArgs e)
        {

        }

        //---------------TIMERS EN MAKEN VAN METHODES-------------------------:
        int min;
        BestellingOpnemen bestellingOpnemen;


        //---------------------------------UPDATEN VAN DE TAFELID NAAR DE DATABASE-------------------
        //public void updateTafelID()
        //{
        //    string connString = ConfigurationManager
        //    .ConnectionStrings["BestellingConnectionStringSQL"]
        //    .ConnectionString;
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();

        //    SqlCommand command = new SqlCommand("UPDATE Table SET TafelId = " + tafelgetal, conn);
        //}

        //---------------------------------SAFE NEERZETTEN VAN TEXT--------------------------
        delegate void SetTextCallback(string text);
        public void SetText1(string text)
        {
            if (this.lbl_test1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText1);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lbl_test1.Text = text;
            }
        }
        private void SetText2(string text)
        {
            if (tafelgetal == 2)
            {
                if (this.lnl_tijdtafel2.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText2);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.lnl_tijdtafel2.Text = text;
                }
            }
        }
        
        private void SetText3(string text)
        {
            if (tafelgetal == 3)
            {
                if (this.lbl_tijdtafel3.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText3);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.lbl_tijdtafel3.Text = text;
                }
            }
        }

        private void SetText4(string text)
        {
            if (tafelgetal == 4)
            {
                if (this.lbl_tijdtafel4.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText4);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    this.lbl_tijdtafel4.Text = text;
                }
            }
        }

        public void lbl_test1_Click(object sender, EventArgs e)
        {

        }
    }
}