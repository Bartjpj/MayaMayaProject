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

        private int txt_PersoneelsID_TextChanged(object sender, EventArgs e)
        {
            int inlogCode = Convert.ToInt32(this.txt_PersoneelsID); // invoer inlogcode voor een personeelslid 
            return inlogCode; //geef inlogcode terug aan inlogbutton. Vanuit de button wordt de authenticatie geregeld.
        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {
            int inlogCode = txt_PersoneelsID_TextChanged(sender, e);
            Authenticatie authenticatie = new Authenticatie();
            bool juisteCode = authenticatie.bedieningAuthenticatie(inlogCode);
            if (juisteCode)
            {
                TafelOverzicht inloggen = new TafelOverzicht();
                inloggen.Show();
                this.Hide();
            }
            else
            {
                inlogFoutAlert inlogFout = new inlogFoutAlert();
                inlogFout.Show();
            }
        }
    }
}
