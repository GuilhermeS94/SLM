using System;

namespace Control
{
    public class Utilitarios
    {
        /// <summary>
        /// Converter a data do Masked TextBox
        /// para o formato SqlDate
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string ConverteDataParaSqlDate(string data)
        {
            DateTime dtSql = DateTime.Parse(data);

            return dtSql.Date.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Converter SqlDate para
        /// Data convencional
        /// </summary>
        /// <param name="sqlDate"></param>
        /// <returns></returns>
        public string ConverteSqlDateParaData(string sqlDate)
        {
            string[] data = sqlDate.Split('-');

            return string.Format("{0}/{1}/{2}", data[2], data[1], data[0]);
        }

        /// <summary>
        /// Calcular idade com DateTime
        /// </summary>
        /// <param name="dtNasc"></param>
        /// <returns>byte idade</returns>
        public static byte CalcularIdade(DateTime dtNasc)
        {
            DateTime hoje = DateTime.Now;

            byte idade = (byte)(hoje.Year - dtNasc.Year);
            
            if (hoje.Month < dtNasc.Month || (hoje.Month == dtNasc.Month && hoje.Day < dtNasc.Day))
                idade--;
            return idade;
        }

        /// <summary>
        /// Calcular idade com string SqlDate
        /// </summary>
        /// <param name="dtNasci"></param>
        /// <returns>byte idade</returns>
        public static byte CalcularIdade(string dtNasci)
        {
            DateTime dtNasc = DateTime.Parse(dtNasci);
            DateTime hoje = DateTime.Now;

            byte idade = (byte)(hoje.Year - dtNasc.Year);
            
            if (hoje.Month < dtNasc.Month || (hoje.Month == dtNasc.Month && hoje.Day < dtNasc.Day))
                idade--;
            return idade;
        }
    }
}
