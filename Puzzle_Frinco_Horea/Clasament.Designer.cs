namespace Puzzle_Frinco_Horea
{
    partial class clasamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clasamentDataSet = new Puzzle_Frinco_Horea.ClasamentDataSet();
            this.clasamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clasamentTableAdapter = new Puzzle_Frinco_Horea.ClasamentDataSetTableAdapters.ClasamentTableAdapter();
            this.tableAdapterManager = new Puzzle_Frinco_Horea.ClasamentDataSetTableAdapters.TableAdapterManager();
            this.clasamentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clasamentDataSet
            // 
            this.clasamentDataSet.DataSetName = "ClasamentDataSet";
            this.clasamentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clasamentBindingSource
            // 
            this.clasamentBindingSource.DataMember = "Clasament";
            this.clasamentBindingSource.DataSource = this.clasamentDataSet;
            // 
            // clasamentTableAdapter
            // 
            this.clasamentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasamentTableAdapter = this.clasamentTableAdapter;
            this.tableAdapterManager.UpdateOrder = Puzzle_Frinco_Horea.ClasamentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clasamentDataGridView
            // 
            this.clasamentDataGridView.AllowUserToAddRows = false;
            this.clasamentDataGridView.AutoGenerateColumns = false;
            this.clasamentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clasamentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clasamentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clasamentDataGridView.DataSource = this.clasamentBindingSource;
            this.clasamentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clasamentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clasamentDataGridView.Name = "clasamentDataGridView";
            this.clasamentDataGridView.Size = new System.Drawing.Size(677, 484);
            this.clasamentDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "#";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Timp";
            this.dataGridViewTextBoxColumn5.HeaderText = "Timp";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numar de patratele";
            this.dataGridViewTextBoxColumn6.HeaderText = "Numar de patratele";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // clasamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 484);
            this.Controls.Add(this.clasamentDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "clasamentForm";
            this.Text = "Clasament";
            this.Load += new System.EventHandler(this.clasamentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clasamentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ClasamentDataSet clasamentDataSet;
        private System.Windows.Forms.BindingSource clasamentBindingSource;
        private ClasamentDataSetTableAdapters.ClasamentTableAdapter clasamentTableAdapter;
        private ClasamentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clasamentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}