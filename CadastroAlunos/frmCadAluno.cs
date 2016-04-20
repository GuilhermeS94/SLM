using System;
using System.Windows.Forms;
using Model;
using Control;
using System.Text.RegularExpressions;

namespace CadastroAlunos
{
    public partial class frmCadAluno : Form
    {
        protected AlunoDAO dao;
        public frmCadAluno()
        {
            InitializeComponent();
        }

        private void mskTxtDtNasc_Leave(object sender, EventArgs e)
        {
            if (mskTxtDtNasc.Text.Length < 10)
                return;

            DateTime dtNasc;
            try
            {
                dtNasc = DateTime.Parse(mskTxtDtNasc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tipo de data incorreto!", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
                        
            try
            {
                txtIdade.Text = Utilitarios.CalcularIdade(dtNasc).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao calcular idade.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = txtNome.Text = mskTxtDtNasc.Text = txtIdade.Text = string.Empty;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0 || txtNome.Text.Length == 0 ||
               mskTxtDtNasc.Text.Length == 0 || txtIdade.Text.Length == 0)
            {
                MessageBox.Show("Há campos em branco!", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DateTime dtNasc;
            CadAlunoGUILHERME novo;
            Regex regex;

            try
            {
                dtNasc = DateTime.Parse(mskTxtDtNasc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tipo de data incorreto!\n" + ex.Message, "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


             regex = new Regex(@"^[1-9]\d*$");//numeros positivos inteiros
            if (regex.IsMatch(txtCodigo.Text) == false)//se nem tudo for numero
            {
                MessageBox.Show("Código inválido!\nDigite apenas números.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dao == null) dao = new AlunoDAO();

            if (dao.BuscarAluno(int.Parse(txtCodigo.Text)) != null)// verifica se aluno existe
            {
                MessageBox.Show("Código de aluno já existe", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            novo = new CadAlunoGUILHERME();
            novo.Codigo = int.Parse(txtCodigo.Text);
            novo.Nome = txtNome.Text;
            novo.DtNasc = dtNasc;
            txtIdade.Text = Utilitarios.CalcularIdade(dtNasc).ToString();

            try
            {
                dao.GravarNovoAluno(novo);
                MessageBox.Show("Aluno novo salvo com sucesso!", "Novo Aluno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao gravar novo aluno.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListarAlunos frmListar = new frmListarAlunos();
            frmListar.ShowDialog();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            frmImportar frmImport = new frmImportar();
            frmImport.ShowDialog();
        }
    }
}
