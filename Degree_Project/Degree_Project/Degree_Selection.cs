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
    public partial class Degree_Selection : Form
    {
        public Degree_Selection()
        {
            InitializeComponent();
        }

        private void Degree_Selection_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            ShowDialog();
        }
    }
}
