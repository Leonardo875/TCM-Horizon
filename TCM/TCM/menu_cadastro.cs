using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCM
{
    public partial class menu_cadastro : Form
    {
        public menu_cadastro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu_cadastro_ciente mncliente = new menu_cadastro_ciente();
            mncliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fm4 = new Form4();
            fm4.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menu_cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
