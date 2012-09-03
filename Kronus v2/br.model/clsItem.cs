using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Kronus_v2.br.model
{
    class clsItem : br.data.clsDataBaseConnection
    {
        #region Atributos.

        private int codigoItem;
        private int caItem;
        private String nomeItem;
        private String tipoItem;
        private String tamanhoItem;
        private int qtdEstoque;
        private int estoqueMin;
        private tipoacao acao;
        private int fornecedor;

        #endregion


        #region Propriedade.
            //Construtor
        public clsItem(String codigo = "") {

            if (String.IsNullOrEmpty(codigo))
            {
                acao = tipoacao.insere;
            }
            else {
                acao = tipoacao.atualiza;
                codigoItem = Convert.ToInt32(codigo);
                searchItem();
            }
        }

        public int Codigo{
            get { return codigoItem; } 
            set { codigoItem = value; }
        }

        public int CAItem {
            get { return caItem; }
            set { caItem = value; }
        }

        public String NomeItem {
            get { return nomeItem; }
            set { nomeItem = value; }
        }

        public String TipoItem {
            get { return tipoItem; }
            set { tipoItem = value; }
        }

        public String TamanhoItem {
            get { return tamanhoItem; }
            set { tamanhoItem = value; }
        }

        public int QtdEstoque {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }

        public int EstoqueMin {
            get { return estoqueMin; }
            set { estoqueMin = value; }
        }

        public int Fornecedor {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        #endregion

        #region Sql.

        //método para consultar Item
        public DataTable searchItem(String value = "1=1") {
            String sql = "select i.cod_item 'Código', i.nome_item 'E. P. I.', i.tipo_item 'Descrição',i.tamanho_item 'Tamanho', i.ca_item 'Número certificado'," +
                "f.nome_fornecedor 'Fornecedor', i.quantidade_estoque 'Quantidade estoque', estoque_min 'Mínimo em estoque' from Item i inner join Fornecedor f on cod_fornecedor = cod_fornecedor_fk where " + value ;

            DataTable dt = retornaDataTable(sql);

            return dt;
        }

        //método para adicionar ou editar Item
        public int addItem() {

            String sql = null;
            int result = 0;
            if (acao == tipoacao.insere)
            {
                sql = "insert into Item (ca_item, nome_item, tipo_item, tamanho_item, quantidade_estoque, estoque_min, cod_fornecedor_fk)" +
                       "values ('" + caItem + "', '" + nomeItem + "', '" + tipoItem + "', '" +
                       tamanhoItem + "', '" + qtdEstoque + "', '" + estoqueMin + "', '" + fornecedor + "')";
            }
            else {
                sql = "update Item set ca_item = '" + caItem + "', nome_item = '" +
                    nomeItem + "', tipo_item = '" + tipoItem + "', tamanho_item = '" + tamanhoItem + "', quantidade_estoque = '" +
                    qtdEstoque + "', estoque_min = '" + estoqueMin + "', cod_fornecedor_fk = '" + fornecedor + 
                    "' where cod_item = '" + codigoItem + "'";
            }

            return result = executaSql(sql);       
            
        }


        // método para excluir Item
        public int deleteItem() {

            String sql = "delete from Item where cod_item = ' " + codigoItem + "'";
            int result = executaSql(sql);
            return result;
        }

        // método para carregar combobox Item
        public DataTable cargaComboItem(String value = "1=1") {

            String sql = "Select * from Item where " + value;
            DataTable dt = retornaDataTable(sql);
            return dt;
        }
        //metodo para carregar combobox item compra e entrega
        public DataTable retornaItemComboCompra() {
            String sql = "select distinct nome_item from Item";
            DataTable dt = retornaDataTable(sql);
            return dt;
        }
        //metodo para carregar combobox descricao compra e entrega
        public DataTable retornaDescricaoCompra(String value = "1=1")
        {
            String sql = "select distinct tipo_item from Item where " + value;
            DataTable dt = retornaDataTable(sql);
            return dt;
        }
        //metodo para carregar combobox tamanho comra e entrega
        public DataTable retornaTamanhoCompra(String value = "1=1")
        {
            String sql = "select distinct tamanho_item from Item where " + value;
            DataTable dt = retornaDataTable(sql);
            return dt;
        }  
        

        

        #endregion
    }
}
