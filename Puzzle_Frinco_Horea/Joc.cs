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
    public partial class jocForm : Form
    {
        public jocForm()
        {
            InitializeComponent();
        }

        inputForm iForm = new inputForm();
        clasamentForm cf = new clasamentForm();

        private void jocNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(numeTextBox.Text == "")
            {
                MessageBox.Show("Alege un nume", "Alege");
            }
            else
            {
                iForm.GetName(numeTextBox.Text);
                iForm.Show();
                this.Close();
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clasamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cf.IsDisposed)
            {
                cf = new clasamentForm();
                cf.Show();
            }
            else if(!cf.Visible)
            {
                cf.Show();
            }
        }
    }
}
