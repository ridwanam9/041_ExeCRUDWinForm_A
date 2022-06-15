using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_crud_041
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ridwan" && textBox2.Text == "1234")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
