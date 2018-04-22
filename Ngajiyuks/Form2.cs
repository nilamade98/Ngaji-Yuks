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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 lihat = new Form3();
            lihat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""){
                MessageBox.Show("Username kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Password kosong", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((textBox1.Text == "Ernino") && (textBox2.Text == "Ernino"))
                {
                    MessageBox.Show("Login Sukses", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form4 lihat = new Form4();
                    lihat.Show();
                }
                else
                {
                    MessageBox.Show("Username dan Password salah", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
