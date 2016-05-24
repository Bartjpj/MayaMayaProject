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
    public partial class HoofdMenu : Form
    {
        public HoofdMenu()
        {
            InitializeComponent();

        }
        private void btn_HMnaarKeuken_Click(object sender, EventArgs e)
        {
            keukenBestellingOverzicht keukenWindowOpenen = new keukenBestellingOverzicht(); // instantie van class keukenBestelling overzicht
            keukenWindowOpenen.Show(this);  // Opent het form keukenWindowOpenen, het object van KeukenBestellingOverzicht. 
            this.Hide(); // window/form die open stond verbergen
        }

        private void btn_HMnaarBar_Click(object sender, EventArgs e)
        {
            BarOverzicht barWindowOpenen = new BarOverzicht();
            barWindowOpenen.Show(this); // verwijst naar winform in grote van parent window (zie OnLoad in te openen form)
            this.Hide();
        }

        private void btn_HMnaarBediening_Click(object sender, EventArgs e)
        {
            InlogSchermBediening bedieningWindowOpenen = new InlogSchermBediening();
            bedieningWindowOpenen.Show(this); // verwijst naar winform in grote van parent window (zie OnLoad in te openen form)
            this.Hide();
        }

        private void btn_ExitWindows_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
