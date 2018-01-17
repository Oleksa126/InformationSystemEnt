using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystemEnt
{
    public partial class dwgView : Form
    {

        public dwgView()
        {
            InitializeComponent();
            showClient();

        }
        private void showClient()
        {
            DBClient dBClient = new DBClient();
            comboBox1.DataSource = dBClient.getAllClient();
            comboBox1.DisplayMember = "firstName";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLinq_Click(object sender, EventArgs e)
        {
            DBClient dBClient = new DBClient();
            dataGridView1.DataSource = dBClient.linq();
        }

        private void getInfo_Click(object sender, EventArgs e)
        {
            Client client = (Client)comboBox1.SelectedItem;
            DBClient dBClient = new DBClient();
            dataGridView1.DataSource = dBClient.procedure(client.idClient);
        }
    }
}
