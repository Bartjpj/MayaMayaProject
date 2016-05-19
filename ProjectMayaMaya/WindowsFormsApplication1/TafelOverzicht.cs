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
    public partial class TafelOverzicht : Form
    {
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
            this.Hide();
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            BestellingMenu BestellingMenuOpenen = new BestellingMenu();
            BestellingMenuOpenen.Show(this); // verwijst naar winform in grote van parent window (zie OnLoad in te openen form)
            this.Hide();
            
            btn_Tafel1.BackColor = Color.Red;
        }
    }
}
