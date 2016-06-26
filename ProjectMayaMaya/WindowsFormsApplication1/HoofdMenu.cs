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
            DatabaseConnectie database = new DatabaseConnectie();
            //Bestelling bestelling1 = new Bestelling(1, 2, 1, 22, 300, 2, 1, 2);
        

        }


        private void btn_HMnaarBar_Click(object sender, EventArgs e)
        {
            BestellingenDAO bestellingenDAO = new BestellingenDAO();
            BarKeukenOverzicht barWindowOpenen = new BarKeukenOverzicht(bestellingenDAO, true);
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

        private void btn_HMnaarKEUKEN_Click(object sender, EventArgs e)
        {
            BestellingenDAO bestellingenDAO = new BestellingenDAO();
            BarKeukenOverzicht keukenWindowOpenen = new BarKeukenOverzicht(bestellingenDAO, false);
            keukenWindowOpenen.Show(this);
            this.Hide();
        }

        private void HoofdMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#115740");
        }
    }
}
