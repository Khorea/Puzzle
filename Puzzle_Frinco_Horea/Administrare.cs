using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Frinco_Horea
{
    public partial class administrareForm : Form
    {
        public administrareForm()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editareClasamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editareForm ef = new editareForm();
            ef.Show();
            this.Close();
        }
    }
}
