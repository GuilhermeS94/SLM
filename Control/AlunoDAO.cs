using System;
using Model;
using System.Xml;
using System.Windows.Forms;

namespace Control
{
    public class AlunoDAO
    {
        protected AlunoContext db;
        /// <summary>
        /// Grava um aluno no banco de dados
        /// </summary>
        /// <param name="alNovo">Tipo aluno</param>
        public void GravarNovoAluno(CadAlunoGUILHERME alNovo)
        {
            if (db == null) db = new AlunoContext();
            
            db.CadAlunoGUILHERME.Add(alNovo);
            db.SaveChanges();
        }
        
        /// <summary>
        /// Buscar um aluno Pelo codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public CadAlunoGUILHERME BuscarAluno(int codigo)
        {
            if (db == null) db = new AlunoContext();
            CadAlunoGUILHERME teste = db.CadAlunoGUILHERME.Find(codigo);

            return teste;
        }

        /// <summary>
        /// Importa para o banco de dados
        /// todos alunos registrados no XML
        /// </summary>
        /// <param name="XMLPath"></param>
        public async void ImportaAlunos(string XMLPath)
        {
            XmlReader xmlReader = XmlReader.Create(XMLPath);//abre o XML
            if (db == null) db = new AlunoContext();// instancia o banco
            CadAlunoGUILHERME alNovo;// cria o aluno

            while (xmlReader.Read())//lendo...
            {
                alNovo = new CadAlunoGUILHERME();//novo aluno
                if (xmlReader.HasAttributes)//se tiver atributos
                {
                    while (xmlReader.MoveToNextAttribute())//cada atributo do elemento
                    {
                        switch (xmlReader.Name)
                        {
                            case "codigo":
                                alNovo.Codigo = int.Parse(xmlReader.Value);
                                break;

                            case "nome":
                                alNovo.Nome = xmlReader.Value;
                                break;

                            case "dtNasc":
                                alNovo.DtNasc = DateTime.Parse(xmlReader.Value);
                                break;

                            default:
                                continue;
                        }
                    }
                }
                if (db.CadAlunoGUILHERME.Find(alNovo.Codigo) != null)
                {
                    //salva o que ja foi importado
                    MessageBox.Show(
                        string.Format("Codigo de aluno ja existente: [Codigo: {0} - Nome: {1} - DtNasc: {2}]",
                        alNovo.Codigo, alNovo.Nome, alNovo.DtNasc),
                        "Erro",
                        MessageBoxButtons.OK
                    );
                    continue;
                }
                if (alNovo.Codigo == 0 || alNovo.Nome == null) continue;

                db.CadAlunoGUILHERME.Add(alNovo);//salva no banco
            }
            xmlReader.Close();//fecha arquivo
            await db.SaveChangesAsync();//commit
        }
    }
}
