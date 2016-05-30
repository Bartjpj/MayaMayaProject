﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers.Timer;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DinerKaart : Form
    {

        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        
        public DinerKaart()
        {
            InitializeComponent();
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

        private void btn_stuurbestelling_Click(object sender, EventArgs e, TafelOverzicht tm_tafel1, TafelOverzicht btn_Tafel1, TafelOverzicht tafelgetal)
        {
            //int min, sec, ms = 0;
            
            //if (tafelgetal >= 1)
            //{
            //    Timer t1 = new Timer();
            //    tm_tafel1.Enabled = true;
            //    tm_tafel1.Start();
            //    if (ms >= 10)
            //    {
            //        sec++;
            //        ms = 0;
            //    }
            //    if (sec >= 60)
            //    {
            //        min++;
            //        sec = 0;
            //    }
            //    if (min >= 30)
            //    {
            //        btn_Tafel1.BackColor = Color.Maroon;
            //    }

            //}
        }
    }
}
