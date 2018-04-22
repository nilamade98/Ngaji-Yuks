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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 lihat = new Form5();
            lihat.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 lihat = new Form11();
            lihat.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 lihat = new Form12();
            lihat.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 lihat = new Form10();
            lihat.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form13 lihat = new Form13();
            lihat.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form15 lihat = new Form15();
            lihat.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form14 lihat = new Form14();
            lihat.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Yakin ingin keluar", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MessageBox.Show("Yakin ingin keluar", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
            else { }
        }


        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 lihat = new Form5();
            lihat.Show();
        }
    }
}
