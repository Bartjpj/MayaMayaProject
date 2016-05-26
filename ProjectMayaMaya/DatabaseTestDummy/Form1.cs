using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseTestDummy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection connectie = new SqlConnection("Data Source=194.171.20.12; Initial Catalog = RBS1516_db16; USER ID=RBS1516_grp16; Password = Gs2N2JAZ6z");
           // connectie.Open(); // zet connectie open
          //  MessageBox.Show(connectie.State.ToString());
            //connectie.Close();

            SqlDataAdapter zendData = new SqlDataAdapter();
            zendData.InsertCommand = new SqlCommand("INSERT INTO Bestelling VALUES( @bestelling_id, @tafel_id) ", connectie);
            zendData.InsertCommand.Parameters.Add("@bestelling_id", SqlDbType.Int).Value = Int32.Parse(this.textBox1.Text);
            zendData.InsertCommand.Parameters.Add("@tafel_id", SqlDbType.Int).Value = Int32.Parse(this.tafel_idBox.Text);
            connectie.Open();
            zendData.InsertCommand.ExecuteNonQuery();
            connectie.Close();
        }

        private void tafel_idBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
