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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 lihat = new Form4();
            lihat.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
