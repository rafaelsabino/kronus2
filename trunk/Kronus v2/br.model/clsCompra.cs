using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronus_v2.br.model
{
    class clsCompra : br.data.clsDataBaseConnection
    {
        #region atributos.

        private int codCompra;
        private int numNota;
        private DateTime data;
        private String valor;
        private tipoacao acao;

        #endregion

        #region propriedades.

        public int CodigoCompra {
            get { return codCompra; }
            set { codCompra = value; }
        }

        public int NotaFiscal {
            get { return numNota; }
            set { numNota = value; }
        }

        public DateTime DataCompra {
            get { return data; }
            set { data = value; }
        }

        public String ValorNota {
            get { return valor; }
            set { valor = value; }
        }

        public clsCompra(String codigo = "") {
            if (String.IsNullOrEmpty(codigo))
            {
                acao = tipoacao.insere;
            }
            else {
                acao = tipoacao.atualiza;
                codCompra = Convert.ToInt32(codigo);
                searchCompra();
            }
        }

        #endregion

        #region sql.
        //método para consultar compra
        public System.Data.DataTable searchCompra(String value = "1=1") {
            String sql = "Select cod_compra 'Código', data_compra 'Data compra', nota_fiscal 'Número nota', valor_compra 'Valor compra' from Compra where " + value ;
            System.Data.DataTable dt = retornaDataTable(sql);
            return dt;
        }
        //mpetodo para adicionar e atualizar compra
        public int addCompra() {
            int result = 0;
            String sql = null;
            if (acao == tipoacao.insere)
            {
                sql = "insert into Compra(data_compra, nota_fiscal, valor_compra) values ('" +
                    data + "', '" + numNota + "', '" + valor + "')";
            }
            else {
                sql = "update Compra set data_compra = '" + data + "', nota_fiscal = '" + numNota + "', valor_compra = '" + valor
                    + "' where cod_compra = '" + codCompra.ToString() + "'" ;
            }

            return result = executaSql(sql);
        }


        #endregion



    }
}
