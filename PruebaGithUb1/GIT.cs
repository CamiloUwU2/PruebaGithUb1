using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGithUb1
{
    public partial class GIT : Form
    {
        public GIT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escribiste el NO: " + textBox1.Text);
        }
    }
}
