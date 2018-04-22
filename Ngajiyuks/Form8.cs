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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 lihat = new Form6();
            lihat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form19 lihat = new Form19();
            lihat.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Permintaan anda sedang di proses", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form18 lihat = new Form18();
            lihat.Show();
        }
    }
}
