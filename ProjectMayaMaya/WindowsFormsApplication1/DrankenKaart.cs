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
    public partial class DrankenKaart : Form
    {

        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        public DrankenKaart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DRANKENnaarBESTELMENU_Click(object sender, EventArgs e)
        {
            BestellingMenu openBestellingmenu = new BestellingMenu();
            openBestellingmenu.Show(this);
            this.Hide();
        }
    }
}
