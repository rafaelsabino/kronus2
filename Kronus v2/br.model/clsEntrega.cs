using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronus_v2.br.model
{
    class clsEntrega : br.data.clsDataBaseConnection
    {
        #region atributos.

        private int codEntrega;
        private DateTime dataEntrega;
        private int qtdEntrega;
        private int funcionario;
        private int item;
        private tipoacao acao;

        #endregion

        #region propriedades.

        //construtor
        public clsEntrega(String codigo = "") {
            if (String.IsNullOrEmpty(codigo))
            {
                acao = tipoacao.insere;
            }
            else {
                acao = tipoacao.atualiza;
            }
        }

        //gets e sets
        public int CodigoEntrega {
            get { return codEntrega; }
            set { codEntrega = value; }
        }

        public DateTime DataEntrega {
            get { return dataEntrega; }
            set { dataEntrega = value; }        
        }

        public int QuantidadeEntrega {
            get { return qtdEntrega; }
            set { qtdEntrega = value; }
        }

        public int CodFuncionario {
            get { return funcionario; }
            set { funcionario = value; }
        }

        public int codItem {
            get { return item; }
            set { item = value; }
        }

        #endregion

        #region sql.

        public System.Data.DataTable searchEntrega(String value = "1=1") {
            String sql = "select  e.cod_entrega 'Código', f.nome_funcionario 'Funcionário', e.data_entrega 'Data'," + 
                " e.qtd_entrega 'Quantidade', i.nome_item 'E. P. I', i.tamanho_item 'Tamanho' from Entrega e inner join Funcionario f" +
                " on e.cod_funcionario_fk = f.cod_funcionario inner join Item i on e.cod_item_fk = i.cod_item where " + value;
            System.Data.DataTable dt = retornaDataTable(sql);
            return dt;
        }

        public int addEntrega() {
            String sql;
            int result;
            if (acao == tipoacao.insere)
            {
                sql = "Insert into Entrega (data_entrega, qtd_entrega, cod_funcionario_fk, cod_item_fk)" +
                    "values ('" + dataEntrega + "', '" + qtdEntrega + "', '" + funcionario + "', '" + item + "')";
            }
            else {
                sql = "Update Entrega set data_entrega = '" + dataEntrega + "', qtd_entrega ='" + qtdEntrega + "', cod_funcionario_fk ='" +
                    funcionario + "', cod_item_fk = '" + item + "' where cod_entrega = '" + codEntrega.ToString() + "'";
            }
            return result = executaSql(sql);
            
        }

        public int deleteEntrega() {
            int result;
            String sql = "delete from Entrega where cod_entrega = '" + codEntrega + "'";
            return result = executaSql(sql);
        }

        #endregion



    }
}
