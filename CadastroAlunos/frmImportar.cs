using System;
using System.Windows.Forms;
using Control;

namespace CadastroAlunos
{
    public partial class frmImportar : Form
    {
        public frmImportar()
        {
            InitializeComponent();
        }

        private void btnBusscar_Click(object sender, EventArgs e)
        {
            if (ofdArquivo.ShowDialog() == DialogResult.OK)
            {
                lblArquivo.Text = ofdArquivo.FileName;
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (lblArquivo.Text.Equals("Arquivo...") || lblArquivo.Text.Equals("Importação concluída com sucesso!"))
            {
                MessageBox.Show("Arquivo não selecionado!", "Importação de Alunos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                AlunoDAO nvsAlunos = new AlunoDAO();
                nvsAlunos.ImportaAlunos(lblArquivo.Text);
                lblArquivo.Text = "Importação concluída com sucesso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao importar alunos!\n" + ex.Message, "Importação de Alunos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
