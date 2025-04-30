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
    public partial class Diectory : Form
    {
        public Diectory()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Degree_Selection f2 = new Degree_Selection();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Schedual f2 = new Schedual();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Degree_comparison f2 = new Degree_comparison();
            f2.ShowDialog();
        }
    }
}
