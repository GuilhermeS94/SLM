namespace CadastroAlunos
{
    partial class frmListarAlunos
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
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.aVALIACAODataSet = new CadastroAlunos.AVALIACAODataSet();
            this.cadAlunoGUILHERMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadAlunoGUILHERMETableAdapter = new CadastroAlunos.AVALIACAODataSetTableAdapters.CadAlunoGUILHERMETableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVALIACAODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadAlunoGUILHERMEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AllowUserToResizeRows = false;
            this.dgvAlunos.AutoGenerateColumns = false;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dtNascDataGridViewTextBoxColumn,
            this.Idade});
            this.dgvAlunos.DataSource = this.cadAlunoGUILHERMEBindingSource;
            this.dgvAlunos.Location = new System.Drawing.Point(13, 13);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(450, 300);
            this.dgvAlunos.TabIndex = 0;
            // 
            // aVALIACAODataSet
            // 
            this.aVALIACAODataSet.DataSetName = "AVALIACAODataSet";
            this.aVALIACAODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadAlunoGUILHERMEBindingSource
            // 
            this.cadAlunoGUILHERMEBindingSource.DataMember = "CadAlunoGUILHERME";
            this.cadAlunoGUILHERMEBindingSource.DataSource = this.aVALIACAODataSet;
            // 
            // cadAlunoGUILHERMETableAdapter
            // 
            this.cadAlunoGUILHERMETableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dtNascDataGridViewTextBoxColumn
            // 
            this.dtNascDataGridViewTextBoxColumn.DataPropertyName = "DtNasc";
            this.dtNascDataGridViewTextBoxColumn.HeaderText = "Data de Nacimento";
            this.dtNascDataGridViewTextBoxColumn.Name = "dtNascDataGridViewTextBoxColumn";
            this.dtNascDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtNascDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtNascDataGridViewTextBoxColumn.Width = 70;
            // 
            // Idade
            // 
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Idade.Width = 50;
            // 
            // frmListarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.dgvAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListarAlunos";
            this.Text = "Lista de Alunos";
            this.Load += new System.EventHandler(this.frmListarAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aVALIACAODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadAlunoGUILHERMEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private AVALIACAODataSet aVALIACAODataSet;
        private System.Windows.Forms.BindingSource cadAlunoGUILHERMEBindingSource;
        private AVALIACAODataSetTableAdapters.CadAlunoGUILHERMETableAdapter cadAlunoGUILHERMETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
    }
}