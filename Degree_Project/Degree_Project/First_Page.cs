using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degree_Project
{
    public partial class First_Page : Form
    {
        public First_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diectory f2 = new Diectory();
            f2.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Degree_Selection f2 = new Degree_Selection();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up f2 = new Sign_Up(); 
            f2.ShowDialog();
            this.Hide();
        }
    }
}
