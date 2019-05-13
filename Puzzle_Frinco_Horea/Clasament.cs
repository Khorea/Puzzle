using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Puzzle_Frinco_Horea
{
    public partial class clasamentForm : Form
    {
        public clasamentForm()
        {
            InitializeComponent();
        }

        private void clasamentForm_Load(object sender, EventArgs e)
        {
            clasamentTableAdapter.Connection = new SqlConnection(Services.connectionString);
            tableAdapterManager.Connection = new SqlConnection(Services.connectionString);

            this.clasamentTableAdapter.Fill(this.clasamentDataSet.Clasament);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clasamentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clasamentDataSet);
        }
    }
}
