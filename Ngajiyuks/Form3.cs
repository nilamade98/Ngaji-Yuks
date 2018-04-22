using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngajiyuks
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Email belum diisi", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Username belum diisi", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Kata Sandi belum diisi", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Alamat belum diisi", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("No. HP belum diisi", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Daftar Sukses", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form4 lihat = new Form4();
                lihat.Show();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
