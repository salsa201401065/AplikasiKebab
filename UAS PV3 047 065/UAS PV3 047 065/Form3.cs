using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace UAS_PV3_047_065
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void menuMakananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formMenu = new Form4();
            formMenu.Show();
            Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formLogin = new Form2();
            formLogin.Show();
            Close();

        }

        private void gambarMakananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 formGambar = new Form5();
            formGambar.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
