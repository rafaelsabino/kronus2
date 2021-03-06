﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronus_v2.br.model
{
    class clslogEntrega : br.data.clsDataBaseConnection
    {
        #region atributos.

        private int codLogEntrega;
        private DateTime dataLogEntrega;
        private int qtdLogEntrega;
        private int funcionarioLogEntrega;
        private int itemLogEntrega;

        #endregion

        #region propriedades.

        //gets e sets
        public int CodLogEntrega {
            get { return codLogEntrega; }
            set { codLogEntrega = value; }
        }

        public DateTime DataLogEntrega {
            get { return dataLogEntrega; }
            set { dataLogEntrega = value; }
        }

        public int QuantidadeLogEntrega {
            get { return qtdLogEntrega; }
            set { qtdLogEntrega = value; }
        }

        public int FuncionarioLogEntrega {
            get { return funcionarioLogEntrega; }
            set { funcionarioLogEntrega = value; }
        }

        public int ItemLogEntrega {
            get { return itemLogEntrega; }
            set { itemLogEntrega = value; }
        }

        #endregion

        #region sql.

        public System.Data.DataTable searchLogEntrega(String value = "1=1"){
            System.Data.DataTable dt;
            String sql = "select  l.cod_log_entrega 'Código', l.data_log_entrega 'Data', f.nome_funcionario 'Funcionário', " +
                "  i.nome_item 'E. P. I', i.tipo_item 'Descrição', i.tamanho_item 'Tamanho', l.qtd_log_entrega 'Quantidade' from LogEntrega l inner join Funcionario f" +
                " on l.cod_funcionario_fk = f.cod_funcionario inner join Item i on l.cod_item_fk = i.cod_item where " + value;
            return dt = retornaDataTable(sql);
        }

        public int addLogEntrega() {
            int result;
            String sql = "insert into LogEntrega (data_log_entrega, qtd_log_entrega, cod_funcionario_fk, cod_item_fk)" +
                    "values ('" + dataLogEntrega + "', '" + qtdLogEntrega + "', '" + funcionarioLogEntrega + "', '" + itemLogEntrega + "')";
            return result = executaSql(sql);
        }

        public int deleteLogEntrega() {
            int result;
            String sql = "delete from LogEntrega where cod_log_entrega = '" + codLogEntrega + "'";
            return result = executaSql(sql);
        }

        #endregion

    }
}
