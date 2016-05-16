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
    public partial class InlogSchermBediening : Form
    {
        public InlogSchermBediening()
        {
            InitializeComponent();
        }

        private void lbl_wachtwoord_Click(object sender, EventArgs e)
        {

        }

        private void btn_INLOGGENnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            this.Hide();
        }

        private void txt_PersoneelsID_TextChanged(object sender, EventArgs e)
        {
            string inlogCode = this.txt_PersoneelsID.ToString(); // invoer inlogcode voor een personeelslid 
            
        }

        private void txt_Wachtwoord_TextChanged(object sender, EventArgs e)
        {
            string wachtWoord = this.txt_Wachtwoord.ToString(); // invoer wachtwoord voor een personeelslid
        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {

        }
    }
}
