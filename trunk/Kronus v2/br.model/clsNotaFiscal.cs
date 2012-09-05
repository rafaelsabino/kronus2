using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kronus_v2.br.model
{
    class clsNotaFiscal : br.data.clsDataBaseConnection
    {
        #region atributos

        private int nota;
        private int item;
        private String valorItem;
        private int qtdCompra;
        private String tamanhoItemCompra;
        private String tipoItemCompra;        

        #endregion

        #region propriedades.

        public int NotaFiscal{
            get { return nota; }
            set { nota = value; }
        }

        public int CodItemFk {
            get { return item; }
            set { item = value; }
        }

        public String ValorUnitario {
            get { return valorItem; }
            set { valorItem = value; }
        }

        public int QuantidadeCompra {
            get { return qtdCompra; }
            set { qtdCompra = value; }
        }

        public String TamanhoItem {
            get { return tamanhoItemCompra; }
            set { tamanhoItemCompra = value; }
        }

        public String TipoItem {
            get { return tipoItemCompra; }
            set { tipoItemCompra = value; }
        }
        

        #endregion

        #region sql.

        public System.Data.DataTable searchNota(String value = "1=1") {
            String sql = "select n.nota_fiscal_fk 'Número nota', i.nome_item ' E. P. I. ', i.tipo_item 'Descrição', i.tamanho_item 'Tamanho'," + 
                " n.valor_unitario 'Valor item', n.quantidade_compra 'Quantidade comprada' " +
                "from notaFiscal n inner join Item i on n.cod_item_fk = i.cod_item where " + value;
            System.Data.DataTable dt = retornaDataTable(sql);

            return dt;
        }

        public int editItemNota(int codItem) {
            int result = 0;
            String sql = "update notaFiscal set cod_item_fk = '" + item + "', tipo_item_compra = '" + tipoItemCompra + 
                "', tamanho_item_compra = '" + tamanhoItemCompra + "', valor_unitario = '" + valorItem + "', quantidade_compra = '" +qtdCompra + "'";

            return result;
        }

        public int addItemNota() {
            String sql = "insert into notaFiscal (nota_fiscal_fk, cod_item_fk, valor_unitario, quantidade_compra, tamanho_item_compra, tipo_item_compra)"+
                "values('" + nota + "', '" + item + "', '" + valorItem + "', '" + qtdCompra + "', '" + tamanhoItemCompra + "', '" + tipoItemCompra +"')";
            int result = executaSql(sql);
            return result;
        }

        public int deleteNota() {
            String sql = "delete from notaFiscal where cod_item_fk = '" + item + "' and nota_fiscal_fk = '" + nota + "'";
            int result = executaSql(sql);
            return result;
        }

        #endregion

    }
}
