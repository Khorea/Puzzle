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
    public partial class inputForm : Form
    {
        public inputForm()
        {
            InitializeComponent();
        }

        puzzleForm pf = new puzzleForm();

        public string path = "";

        string nume = "";

        public void GetName(string nm)
        {
            nume = nm;
        }

        private void alegeButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                alegeButton.Text = openFileDialog1.SafeFileName;
                path = openFileDialog1.FileName;
                startButton.Enabled = true;
            }
        }

        private void inputForm_Load(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            openFileDialog1.Filter = "Imagine(.jpg)|*.jpg|Imagine (.png)|*.png";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory.Replace (@"\bin\Debug", @"\Resurse");
            comboBox1.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(pf.IsDisposed)
            {
                pf = new puzzleForm();
                pf.GetPath(path);
                pf.GetPatrate(Convert.ToInt32(comboBox1.Text));
                pf.GetName(nume);
                pf.Show();
                this.Hide();
            }
            else
            {
                pf.GetPath(path);
                pf.GetPatrate(Convert.ToInt32(comboBox1.Text));
                pf.GetName(nume);
                pf.Show();
                this.Hide();
            }                
        }
    }
}
