using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class InlogSchermBediening : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;//vragen aan ivo
            this.Size = Owner.Size;
        }
        public InlogSchermBediening()
        {
            InitializeComponent();
        }


        private void btn_INLOGGENnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left; // geeft de grote aan van deze form voor het te openen form
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }

        private int txt_PersoneelsID_TextChanged(object sender, EventArgs e)
        {
                int inlogCode = Convert.ToInt32(txt_PersoneelsID.Text); // invoer inlogcode voor een personeelslid 
                return inlogCode; //geef inlogcode terug aan inlogbutton. Vanuit de button wordt de authenticatie geregeld.
        }

        private void txt_PersoneelsID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // zorgt ervoor dat bij een keypress er geen letters worden getolereerd.
        }

        private void btn_inloggen_Click(object sender, EventArgs e)
        {
            PersoneelsLidDAO personeelDatabaseActies = new PersoneelsLidDAO(); // maakt nieuwe instantie van personeelslidDAO aan.
            int inlogCode = txt_PersoneelsID_TextChanged(sender, e); //grijp de inlogcode van de inlogcode tekstbox
            List<InlogSchermClass> inlogGegevens = personeelDatabaseActies.haalPersoneelslid_IDTabelOp(); // juistecode neemt boolwaarde van authenticatie aan (false is verkeerd, true is goed)
            bool juisteCode = false;
            string naamGebruiker = "";
            string functieGebruiker = "";

            foreach (InlogSchermClass gebruiker in inlogGegevens)
            {
                if (gebruiker.code == inlogCode)
                {
                    juisteCode = true;
                    naamGebruiker = gebruiker.naam;
                    functieGebruiker = gebruiker.functie;
                }
                else
                {
                    
                }
            }
            



            //PersoneelsLidDAO personeelsTabel = new PersoneelsLidDAO(); //maak een instantie van constructor zodat we daar de lijst vandaan kunnen halen.
            //lbl_personeelsleden.Text = 
            //lbl_personeelsleden.Text = personeelsTabel.ToString();

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

        private void btn_InloggenSkippen_Click(object sender, EventArgs e)
        {
            TafelOverzicht openTafelOverzicht = new TafelOverzicht();
            openTafelOverzicht.ShowDialog(this);
            this.Hide();
        }


    }
}
