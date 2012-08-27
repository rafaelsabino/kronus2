using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Kronus_v2.br.model
{
    class clsUsuário : br.data.clsDataBaseConnection
    {
        #region atributos.

        private int codUsuario;
        private String nomeUsuario;
        private int tipoAcesso;
        private String senhaUsuario;
        private String loginUsuario;
        private tipoacao acao;

        #endregion  

        #region proproedades.

        public int CodigoUsuario {
            get { return codUsuario; }
            set { codUsuario = value; }
        }

        public String NomeUsuario {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public int TipoAcesso {
            get { return tipoAcesso; }
            set { tipoAcesso = value; }
        }

        public String SenhaUsuario {
            get { return senhaUsuario; }
            set { senhaUsuario = value; }
        }

        public String Loginusuario {
            get { return loginUsuario; }
            set { loginUsuario = value; }
        }

        //Construtor
        public clsUsuário(String codigo = ""){
            if (String.IsNullOrEmpty(codigo))
            {
                acao = tipoacao.insere;
            }
            else {
                acao = tipoacao.atualiza;
                codUsuario = Convert.ToInt32(codigo);
                SearchUsuario();
            }
        }

        #endregion

        #region sql.

        //método de consulta de usuário
        public DataTable SearchUsuario(String value  = "1=1") {
            String sql = "select cod_user 'Código', nome_user 'Nome usuário', login_user 'Login usuário', senha_user 'Senha', tipo_user 'Tipo acesso' from Usuario where " + value;
            DataTable dt =  retornaDataTable(sql) ;
            return dt;
        }

        //método para adicionar e atualizar usuario
        public int addUser() {
            String sql = null;
            int result = 0;
            if (acao == tipoacao.insere)
            {
                sql = "insert into Usuario (nome_user, login_user, senha_user, tipo_user) values ('" + nomeUsuario + "', '" +
                     loginUsuario + "', '" + senhaUsuario + "', '" + tipoAcesso + "')";
            }
            else {
                sql = "update Usuario set nome_user = '" + nomeUsuario + "', login_user = '" + loginUsuario + "', senha_user = '"
                    + senhaUsuario + "', tipo_user = '" + tipoAcesso + "' where cod_user = '" + codUsuario + "'";
            }

            return result = executaSql(sql);
        }

        public int deleteUser() { 
            String sql ="delete from Usuario where cod_user = '" + codUsuario + "'";
            int result = executaSql(sql);
            return result;
        }

        #endregion

    }
}
