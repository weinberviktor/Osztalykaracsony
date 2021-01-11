using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Osztalykaracsony
{
    public partial class FrmOsztaly : Form
    {
        SqlConnection conn;
        public FrmOsztaly(string connectionstring)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void talloz_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            tallozas_helye.Text = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        private void adatbazis_add_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(tallozas_helye.Text);

            conn.Open();

            SqlCommand cmd = new SqlCommand();

            conn.Close();
        }

        private void tallozas_helye_TextChanged(object sender, EventArgs e)
        {
             osztaly_neve.Enabled = true;
            adatbazis_add.Enabled = true;
        }
    }
}
