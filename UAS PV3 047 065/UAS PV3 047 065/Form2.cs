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
    public partial class Form2 : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;database=restoran;uid=root;password=''";
            conn = new MySqlConnection(connStr);
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from pelayan where ID = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", conn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Login Berhasil");
                    Form3 formUtama = new Form3();
                    formUtama.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("username atau password salah");
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show("Gagal masuk");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
