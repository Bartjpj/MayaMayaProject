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
        public int tafelgetal;




        //1
        public void btn_Tafel1_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname1 = new KiesOpname();
            openKiesopname1.Show(this);

            tafelgetal = 1;

            //updateTafelID();
            maakTimer1();


        }

        //2
        public void btn_Tafel2_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

            tafelgetal = 2;

            //updateTafelID();

            maakTimer2();
        }

        //3
        public void btn_Tafel3_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 3;

            //updateTafelID();

            maakTimer3();

        }

        //4
        public void btn_Tafel4_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 4;

            //updateTafelID();

            maakTimer4();

        }

        //5
        public void btn_Tafel5_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 5;

            //updateTafelID();

            maakTimer5();

        }

        //6
        public void btn_Tafel6_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 6;

            //updateTafelID();

            maakTimer6();

        }

        //7
        public void btn_Tafel7_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 7;

            //updateTafelID();

            maakTimer7();

        }

        //8
        public void btn_Tafel8_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 8;

            //updateTafelID();

            maakTimer8();

        }

        //9
        public void btn_Tafel9_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 9;

            //updateTafelID();

            maakTimer9();

        }

        //10
        public void btn_Tafel10_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            tafelgetal = 10;

            //updateTafelID();

            maakTimer10();

        }

        public void lbl_tijdtafel1_Click(object sender, EventArgs e)
        {

        }

        //---------------TIMERS EN MAKEN VAN METHODES-------------------------:
        int min;
        BestellingOpnemen bestellingOpnemen;
        delegate void SetTextCallback(string text);
        public void maakTimer1() // maken timer 1
        {
            //System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

            System.Timers.Timer t1 = new System.Timers.Timer();
            t1.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t1.Elapsed += new ElapsedEventHandler(t1_Tick);
            t1.Enabled = true;
        }

        public void t1_Tick(object sender, EventArgs e)
        {

            btn_Tafel1.BackColor = Color.LightSkyBlue;

            min++;                  //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN
            this.SetText1(min + " Min");
            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel1.BackColor = Color.IndianRed;
                btn_Tafel1.ForeColor = Color.White;

            }
        }



        //2
        private void maakTimer2() // maken timer 1
        {
            //System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

            System.Timers.Timer t2 = new System.Timers.Timer();
            t2.Interval = 2000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t2.Elapsed += new ElapsedEventHandler(t2_Tick);
            t2.Enabled = true;
        }

        private void t2_Tick(object sender, EventArgs e)
        {

            btn_Tafel1.BackColor = Color.LightSkyBlue;

            min++;                  //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN
            this.SetText2(min + " Min");
            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel2.BackColor = Color.IndianRed;
                btn_Tafel2.ForeColor = Color.White;

            }
        }

        //3
        public void maakTimer3() // maken timer 
        {
            //System.Windows.Forms.Timer t3 = new System.Windows.Forms.Timer();
            //t3.Interval = 1000;                             //1000 (ms) is 1 seconde, als je minuten wilt, zet dan op 10000 ms
            //t3.Tick += new EventHandler(timer3_Tick);
            //t3.Enabled = true;
            System.Threading.Timer t3;
            t3 = new System.Threading.Timer(new TimerCallback(DoSomething3), null, 300, 1300);
            t3.Change(0, 1000); //enable

        }
        private void DoSomething3(object obj)
        {
            //it executes every second            
            btn_Tafel3.BackColor = Color.LightSkyBlue;

            min++;
            this.SetText3(min + " Min");    //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel3.BackColor = Color.IndianRed;
                btn_Tafel3.ForeColor = Color.White;
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {


        }

        //4
        public void maakTimer4() // maken timer 
        {
            //System.Windows.Forms.Timer t4 = new System.Windows.Forms.Timer();
            //t4.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            //t4.Tick += new EventHandler(timer4_Tick);
            //t4.Enabled = true;
            System.Threading.Timer t4;
            t4 = new System.Threading.Timer(new TimerCallback(DoSomething4), null, 400, 1400);
            t4.Change(0, 1000); //enable
        }
        private void DoSomething4(object obj)
        {
            //it executes every second            
            btn_Tafel4.BackColor = Color.LightSkyBlue;

            min++;
            this.SetText4(min + " Min");    //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel4.BackColor = Color.IndianRed;
                btn_Tafel4.ForeColor = Color.White;
            }

        }

        //private void timer4_Tick(object sender, EventArgs e)
        //{

        //    btn_Tafel4.BackColor = Color.LightSkyBlue;

        //    min++;
        //    lbl_tijdtafel4.Text = min + " Min";            //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

        //    if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
        //    {
        //        btn_Tafel4.BackColor = Color.IndianRed;
        //        btn_Tafel4.ForeColor = Color.White;
        //    }

        //}

        //5
        public void maakTimer5() // maken timer 
        {
            System.Windows.Forms.Timer t5 = new System.Windows.Forms.Timer();
            t5.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t5.Tick += new EventHandler(timer5_Tick);
            t5.Enabled = true;

        }
        private void timer5_Tick(object sender, EventArgs e)
        {

            btn_Tafel5.BackColor = Color.LightSkyBlue;

            min++;
            lbl_tijdtafel5.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel5.BackColor = Color.IndianRed;
                btn_Tafel5.ForeColor = Color.White;
            }

        }

        //6
        public void maakTimer6() // maken timer 
        {
            System.Windows.Forms.Timer t6 = new System.Windows.Forms.Timer();
            t6.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t6.Tick += new EventHandler(timer6_Tick);
            t6.Enabled = true;

        }
        private void timer6_Tick(object sender, EventArgs e)
        {

            btn_Tafel6.BackColor = Color.LightSkyBlue;

            min++;
            lbl_tijdtafel6.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel6.BackColor = Color.IndianRed;
                btn_Tafel6.ForeColor = Color.White;
            }

        }

        //7
        public void maakTimer7() // maken timer 
        {
            System.Windows.Forms.Timer t7 = new System.Windows.Forms.Timer();
            t7.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t7.Tick += new EventHandler(timer7_Tick);
            t7.Enabled = true;

        }
        private void timer7_Tick(object sender, EventArgs e)
        {

            btn_Tafel7.BackColor = Color.LightSkyBlue;

            min++;
            lbl_tijdtafel7.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel7.BackColor = Color.IndianRed;
                btn_Tafel7.ForeColor = Color.White;
            }

        }

        //8
        public void maakTimer8() // maken timer 
        {
            System.Windows.Forms.Timer t8 = new System.Windows.Forms.Timer();
            t8.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t8.Tick += new EventHandler(timer8_Tick);
            t8.Enabled = true;

        }
        private void timer8_Tick(object sender, EventArgs e)
        {

            btn_Tafel8.BackColor = Color.LightSkyBlue;

            min++;
            lbl_tijdtafel8.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel8.BackColor = Color.IndianRed;
                btn_Tafel8.ForeColor = Color.White;
            }

        }

        //9
        public void maakTimer9() // maken timer 
        {
            System.Windows.Forms.Timer t9 = new System.Windows.Forms.Timer();
            t9.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t9.Tick += new EventHandler(timer9_Tick);
            t9.Enabled = true;

        }
        private void timer9_Tick(object sender, EventArgs e)
        {

            btn_Tafel9.BackColor = Color.LightSkyBlue;

            min++;
            lbl_tijdtafel9.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel9.BackColor = Color.IndianRed;
                btn_Tafel9.ForeColor = Color.White;
            }

        }

        //10
        public void maakTimer10() // maken timer 
        {
            System.Windows.Forms.Timer t10 = new System.Windows.Forms.Timer();
            t10.Interval = 1000;                             //1000 (ms) is 1 seconde, als je min wilt, zet dan op 10000 ms
            t10.Tick += new EventHandler(timer10_Tick);
            t10.Enabled = true;

        }
        private void timer10_Tick(object sender, EventArgs e)
        {

            btn_Tafel10.BackColor = Color.LightSkyBlue;

            min++;
            lbl_tijdtafel10.Text = min + " Min";       //zetten tijd van de timer, dit is MINUTEN maar interval is gezet op SECONDEN

            if (min >= 10)                          //zetten kleuren van de button als hij 10 min bezig is.
            {
                btn_Tafel10.BackColor = Color.IndianRed;
                btn_Tafel10.ForeColor = Color.White;
            }

        }
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
        private void SetText1(string text)
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
    }
}