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
    public partial class Form4 : Form
    {
        MySqlConnection co = new MySqlConnection("Server=localhost;Database = restoran; Uid=root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();
        public Form4()
        {
            InitializeComponent();
            co.Open();
            ReadData();

        }


        public void ReadData()
        {
            try
            {
                mycommand.Connection = co;
                myadapter.SelectCommand = mycommand;
                mycommand.CommandText = "select * from menu";
                DataSet ds = new DataSet();

                if (myadapter.Fill(ds, "dftpesan") > 0)
                {
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "dftpesan";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertData()
        {
            try
            {
                mycommand.Connection = co;
                mycommand.CommandText = "insert into menu values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data berhasil dimasukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void UpdateData()
        {
            try
            {
                mycommand.CommandText = "update menu set kodeMenu='" + textBox1.Text + "',nama='" + textBox2.Text + "',harga='" + textBox3.Text + "',tipe='" + textBox4.Text + "' where kodeMenu ='" + textBox1.Text + "'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadData();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void DeleteData()
        {
            try
            {
                mycommand.CommandText = "delete from menu where kodeMenu = '" + textBox1.Text + "'";
                myadapter.SelectCommand = mycommand;
                if (mycommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 formUtama = new Form3();
            formUtama.Show();
            Hide();
        }
    }
}
