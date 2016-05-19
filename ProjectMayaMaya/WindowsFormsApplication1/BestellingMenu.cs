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
    public partial class BestellingMenu : Form
    {
        public BestellingMenu()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void cbox_selecteerkaart_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbox_selecteerkaart.Items.Add("Dranken");
            cbox_selecteerkaart.Items.Add("Lunch");
            cbox_selecteerkaart.Items.Add("Diner");
        }
    }
}
