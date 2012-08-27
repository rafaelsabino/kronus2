using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Kronus_v2
{
    class clsFornecedor : br.data.clsDataBaseConnection
    {
        #region atributos.

        private int codigoFornec;
        private String nomeFornec;
        private String emailFornec;
        private String telFornec;
        private tipoacao acao;
        

        #endregion

        #region propriedades. 
    
            // Construtor

        public clsFornecedor(String codFornec = "") {
            if (String.IsNullOrEmpty(codFornec))
            {
                acao = tipoacao.insere;
            }
            else {
                acao = tipoacao.atualiza;
                codigoFornec = Convert.ToInt32(codFornec);
                searchFornecedor();
            }
        }
       
        // Gets e Sets Fornecedor

        public int codigo {
            get {return codigoFornec; }
            set { codigoFornec = value; }
        }

        public String nome {
            get { return nomeFornec; }
            set { nomeFornec = value; }
        }

        public String email {
            get { return emailFornec; }
            set { emailFornec = value; }
        }

        public String telefone{
            get { return telFornec; }
            set { telFornec = value; }
        }

       #endregion

        #region Sql.

        // método para listar e realizar consultas de Fornecedores

        public DataTable  searchFornecedor(String value = "1=1") {
            String sql = "select f.cod_fornecedor 'Código', f.nome_fornecedor 'Nome' , f.email_fornecedor 'E-mail', f.tel_fornecedor 'Telefone' from Fornecedor f where " + value; 
            DataTable dt = retornaDataTable(sql);

            return dt;
                       
        }

        // método para salvar e editar Fornecedor

        public int addFornecedor() {

            String sql = null;
            int result = 0;
            if (acao == tipoacao.insere)
            {
                sql = "insert into Fornecedor (nome_fornecedor, email_fornecedor, tel_fornecedor) values ('" + nomeFornec + "', '" 
                    + emailFornec + "', '" + telFornec + "')";
            }
            else {
                sql = "update Fornecedor set nome_fornecedor = '" + nomeFornec + "', email_fornecedor = '" + 
                    emailFornec + "', tel_fornecedor = '" + telFornec + "' where cod_fornecedor = '" + codigoFornec + "'";
            }
            result = executaSql(sql);
            return result;
        }

        // método para excluir fornecedor

        public int deleteFornecedor() { 
            String sql = "delete from Fornecedor where cod_fornecedor = '" + codigoFornec + "'" ;
            int result=executaSql(sql);

            return result;
        }

        // método para carregar combobox de fornecedores

        public DataTable cargaComboFornecedor(String value = "1=1") {
            String sql = "select * from Fornecedor where " + value;
            DataTable dt = retornaDataTable(sql);

            return dt;
        }

        #endregion

    }
}