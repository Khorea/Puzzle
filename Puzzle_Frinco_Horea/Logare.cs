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
    public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
        }

        jocForm jf = new jocForm();
        administrareForm af = new administrareForm();

        private void logButton_Click(object sender, EventArgs e)
        {
            if ((numeTextBox.Text == "jucator" && parolaTextBox.Text == "jucator") || (numeTextBox.Text == "1" && parolaTextBox.Text == "1"))
            {
                jf.Show();
                numeTextBox.Clear();
                parolaTextBox.Clear();
                this.Hide();
            }
            else if ((numeTextBox.Text == "administrator" && parolaTextBox.Text == "administrator") || (numeTextBox.Text == "2" && parolaTextBox.Text == "2"))
            {
                af.Show();
                numeTextBox.Clear();
                parolaTextBox.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Eroare autentificare!", "Eroare");
                numeTextBox.Clear();
                parolaTextBox.Clear();
            }
        }

        private void logForm_Load(object sender, EventArgs e)
        {

        }
    }
}
