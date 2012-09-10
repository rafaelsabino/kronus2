using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;


namespace Kronus_v2.br.data
{
    class clsDataBaseConnection
    {
        #region Variavel.

        public enum tipoacao { insere, atualiza }
        String strCon = @"Data Source=EDIEL-PC;Initial Catalog=Kronus;Persist Security Info=True;User ID=sa;Password=mandioca";

        #endregion

        #region Conexão com Banco de Dados
        

        public DataTable retornaDataTable(String sqlCommand)
        {
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(sqlCommand, strCon);
            System.Data.DataSet ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0]; ;
        }

        public int executaSql(String sqlCommand)
        {
            int result = 0;
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(strCon);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sqlCommand, conn);
            conn.Open();
            if (sqlCommand.Substring(0, 5) == "insert")
            {
                result = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            conn.Close();

            return result;
        }

             
   
    #endregion 

        #region Validacao.

        public static bool validaEmail(String texto) {



            Regex rx = new Regex("^[a-zA-Z][\\w\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9]*[\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$");

            return rx.IsMatch(texto);
        }

        public static bool validaCaracter(String texto) {
            Regex rx = new Regex("^[\',#,@,$]*$");
            return rx.IsMatch(texto);
        }

        public static bool validaString(String texto) {
            Regex rx = new Regex("^[A-Za-záéíóúçÁÉÍÓÚãõÃÕ, ]*$");
            return rx.IsMatch(texto);
        }

        public static bool validaNumber(String texto) {
            Regex rx = new Regex("^[0-9]*$");
            return rx.IsMatch(texto);
        }

        public static bool validaTamanho(String texto) {
            Regex rx = new Regex("^[a-zA-Z0-9éÉáÁÚúóÓíÍãõÃÕÇ/, ]*$");
            return rx.IsMatch(texto);
        }

        public static bool validaMoney(String texto) {
            Regex rx = new Regex("^[0-9,.]*$");
            return rx.IsMatch(texto);
        }

        
        #endregion
    }
        
}
