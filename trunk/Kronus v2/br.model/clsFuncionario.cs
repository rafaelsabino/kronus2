using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronus_v2.br.model
{
    class clsFuncionario : br.data.clsDataBaseConnection
    {
        #region atributos.

            private int codFunc;
            private String nomeFunc;
            private String statusFunc;
            private tipoacao acao;
        
        #endregion

        #region propriedades.

            public int codigoFuncionario {
                get { return codFunc; }
                set { codFunc = value; }
            }

            public String nomeFuncionario {
                get { return nomeFunc; }
                set { nomeFunc = value; }
            }

            public String statusFuncionario {
                get { return statusFunc; }
                set { statusFunc = value; }
            }

            public clsFuncionario(String codigo = "") {
                if (String.IsNullOrEmpty(codigo))
                {
                    acao = tipoacao.insere;
                }
                else {
                    acao = tipoacao.atualiza;
                    codFunc = Convert.ToInt32(codigo);
                    searchFuncionario();
                }
            }

        #endregion

        #region sql.
            //método para consultar funcionario
            public System.Data.DataTable searchFuncionario(String value = "1=1") {
                System.Data.DataTable dt = new System.Data.DataTable();
                String sql = "select cod_funcionario 'Código', nome_funcionario 'Nome funcionário', status_funcionario 'Status funcionário' from Funcionario where " + value;
                return dt = retornaDataTable(sql);
            }
            //método para adicionar ou atualizar funcionario
            public int addFuncionario() {
                int result = 0;
                String sql = null;

                if (acao == tipoacao.insere)
                {
                    sql = "insert into Funcionario(nome_funcionario, status_funcionario) values('" + nomeFunc + "', '" + statusFunc + "')";
                }
                else {
                    sql = "update Funcionario set nome_funcionario = '" + nomeFunc + "', status_funcionario = '" + statusFunc + "' where cod_funcionario = '" + codFunc.ToString() + "'";
                }
                return result = executaSql(sql);
            }
            //método para excluir funcionario
            public int deleteFuncionario() {
                int result = 0;
                String sql = "delete from funcionario where cod_funcionario = '" + codFunc.ToString() + "'";
                return result = executaSql(sql);
            }
            //método para carregar combo funcionarios
            public System.Data.DataTable carregarCombo() {
                System.Data.DataTable dt = new System.Data.DataTable();
                String sql = "select *from funcionario";
                return dt = retornaDataTable(sql);
            
            }

        #endregion

    }
}
