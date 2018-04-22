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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 lihat = new Form9();
            lihat.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 lihat = new Form6();
            lihat.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Permintaan anda sedang di proses", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form17 lihat = new Form17();
            lihat.Show();
        }
    }
}
