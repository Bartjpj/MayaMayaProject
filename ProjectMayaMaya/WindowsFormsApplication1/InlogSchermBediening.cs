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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
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
            TerugNaarHoofdmenu.Left = this.Left;
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }

        private int txt_PersoneelsID_TextChanged(object sender, EventArgs e)
        {
            int inlogCode = Convert.ToInt32(txt_PersoneelsID.Text); // invoer inlogcode voor een personeelslid 
            return inlogCode; //geef inlogcode terug aan inlogbutton. Vanuit de button wordt de authenticatie geregeld.
        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {
            int inlogCode = txt_PersoneelsID_TextChanged(sender, e); //grijp de inlogcode van de inlogcode tekstbox
            Authenticatie authenticatie = new Authenticatie(); // run authenticatie die gaat kijken of het ingevoerde nummer in de database voorkomt
            bool juisteCode = authenticatie.bedieningAuthenticatie(inlogCode); // juistecode neemt boolwaarde van authenticatie aan (false is verkeerd, true is goed)
            if (juisteCode) // ga naar tafeloverzicht als het true is, geef een alert als het false.
            {
                TafelOverzicht inloggen = new TafelOverzicht();
                inloggen.Show();
                this.Hide();
            }
            else
            {
                inlogFoutAlert inlogFout = new inlogFoutAlert();
                inlogFout.StartPosition = FormStartPosition.CenterParent;
                inlogFout.ShowDialog(this);
            }
        }
    }
}
