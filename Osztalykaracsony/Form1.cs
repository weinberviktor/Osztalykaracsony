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
using System.IO;

namespace Osztalykaracsony
{
    public partial class FrmMain : Form
    {
        string connectionstring= @"Server=(localdb)\MSSQLLocalDB;AttachDbFileName=|DataDirectory|\Resources\mikulas.mdf;Trusted_Connection=True;";

        SqlConnection conn;
        public FrmMain()
        {
            
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
             
        }

        private void kilep_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void osztbetolt_Click(object sender, EventArgs e)
        {
            
            FrmOsztaly fo = new FrmOsztaly(connectionstring);
            fo.ShowDialog();
        }

        private void sors_Click(object sender, EventArgs e)
        {
            
            FrmSorsolas fs = new FrmSorsolas(connectionstring);
            fs.ShowDialog();
        }

        private void csomi_Click(object sender, EventArgs e)
        {
            
            Frmcsomagepito fcs = new Frmcsomagepito(connectionstring);
            fcs.ShowDialog();
        }
    }
}
