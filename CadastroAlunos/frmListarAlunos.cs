using System;
using System.Windows.Forms;
using Control;

namespace CadastroAlunos
{
    public partial class frmListarAlunos : Form
    {
        public frmListarAlunos()
        {
            InitializeComponent();
        }

        private void frmListarAlunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aVALIACAODataSet.CadAlunoGUILHERME' table. You can move, or remove it, as needed.
            this.cadAlunoGUILHERMETableAdapter.Fill(this.aVALIACAODataSet.CadAlunoGUILHERME);
            
            foreach (DataGridViewRow linha in dgvAlunos.Rows)
            {
                linha.Cells[3].Value = Utilitarios.CalcularIdade(linha.Cells[2].Value.ToString());
            }
        }
    }
}
