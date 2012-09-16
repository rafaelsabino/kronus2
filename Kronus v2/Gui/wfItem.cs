using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronus_v2
{
    public partial class wfItem : Form
    {
        public wfItem()
        {
            InitializeComponent();
        }

        private void wfItem_Load(object sender, EventArgs e)
        {
            inicial();
            cargaGrid();
        }

        public void inicial() {
            limpaCampos();
            txtCa.CausesValidation = false;
            cbFornecedor.CausesValidation = false;
            txtNomeItem.CausesValidation = false;
            txtTamanho.CausesValidation = false;
            txtEstoqueMin.CausesValidation = false;
            txtDescricao.CausesValidation = false;
            lbCodigo.Visible = true;
            txtCodigo.Visible = true;
            txtCodigo.Enabled = false;
            txtCa.Enabled = false;
            txtDescricao.Enabled = false;
            txtEstoqueMin.Enabled = false;
            txtNomeItem.Enabled = false;
            txtTamanho.Enabled = false;
            txtConsultar.Text = "";
            txtConsultar.Enabled = true;
            btConsultar.Enabled = true;
            cbFornecedor.Text = "                  ";
            cbFornecedor.Enabled = false;
            btDeletar.Enabled = false;
            btSalvar.Enabled = false;
            errorProvider1.SetError(txtCa, String.Empty);
            errorProvider1.SetError(cbFornecedor, String.Empty);
            errorProvider1.SetError(txtCa, String.Empty);
            errorProvider1.SetError(txtDescricao, String.Empty);
            errorProvider1.SetError(txtNomeItem, String.Empty);
            errorProvider1.SetError(txtTamanho, String.Empty);
            errorProvider1.SetError(txtEstoqueMin, String.Empty);
            errorProvider1.SetError(cbFornecedor, String.Empty);
            txtCa.CausesValidation = true;
            cbFornecedor.CausesValidation = true;
            txtNomeItem.CausesValidation = true;
            txtTamanho.CausesValidation = true;
            txtEstoqueMin.CausesValidation = true;
            txtDescricao.CausesValidation = true;

            
        }

        public void cargaGrid() { 
            br.model.clsItem i = new br.model.clsItem();
                try 
	            {	        
		            dgItem.DataSource = i.searchItem();
                    dgItem.Columns["Código"].Visible = false;
                    dgItem.Refresh();
	            }
	            catch (Exception ex)
	            {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
		            throw;
	            }           
                       
        }

        public void carregaCombo() {

            clsFornecedor f = new clsFornecedor();

            
            try
            {
              this.cbFornecedor.DataSource = f.cargaComboFornecedor();
              this.cbFornecedor.ValueMember = ("cod_fornecedor");
              this.cbFornecedor.DisplayMember = ("nome_fornecedor");               
                               
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            inicial();
            cadastrarItem();
            cargaGrid();
            txtCa.Select();
            
        }

        public void cadastrarItem() {
            lbCodigo.Visible = false;
            txtCodigo.Visible = false;
            txtConsultar.Enabled = false;
            txtNomeItem.Enabled = true;
            txtDescricao.Enabled = true;
            txtCa.Enabled = true;
            txtEstoqueMin.Enabled = true;
            txtTamanho.Enabled = true;
            carregaCombo();
            cbFornecedor.Enabled = true;
            btConsultar.Enabled = false;
            limpaCampos();                       
            txtCa.Select();
            btDeletar.Enabled = true;           
                                              

        }

        private void txtCa_Validating(object sender, CancelEventArgs e)
        {
           
            if (!br.data.clsDataBaseConnection.validaNumber(txtCa.Text) || String.IsNullOrEmpty(txtCa.Text))
            {
                errorProvider1.SetError(txtCa, "Informe o certificado de aprovação, deve ser numero.");
                txtCa.Text = String.Empty;
                txtCa.Select();

            }
            else {
                if (br.model.clsItem.validaCaracter(txtCa.Text))
                {
                    errorProvider1.SetError(this.txtCa, "O certificado de aprovação não deve conter caracteres como: ', #, @, $. ");
                    txtCa.Text = String.Empty;
                    txtCa.Select();
                }
                else {
                    errorProvider1.SetError(txtCa, String.Empty);
                    cbFornecedor.Focus();
                }
                
            }
            
        }

        private void txtNomeItem_Validating(object sender, CancelEventArgs e)
        {
            if (!br.model.clsItem.validaString(txtNomeItem.Text) || String.IsNullOrEmpty(txtNomeItem.Text))
            {
                errorProvider1.SetError(txtNomeItem, "Informe o nome do e. p. i., este não deve conter\nnúmeros ou caracteres especiais como: ', #, @, $ etc.");
                txtNomeItem.Text = String.Empty;
                txtNomeItem.Select();
            }
            else
            {

                if (br.model.clsItem.validaCaracter(txtNomeItem.Text))
                {
                    errorProvider1.SetError(txtNomeItem, "O nome do item não pode conter caracteres como: ', #, @, $ ");
                    txtNomeItem.Text = String.Empty;
                    txtNomeItem.Select();
                }
                else
                {
                    errorProvider1.SetError(txtNomeItem, String.Empty);
                    txtTamanho.Focus();
                }
            }
        }

        private void txtTamanho_Validating(object sender, CancelEventArgs e)
        {
            if (!br.model.clsItem.validaTamanho(txtTamanho.Text))
            {
                errorProvider1.SetError(txtTamanho, "Informe o tamanho do item, deve ser apenas números ou letras.");
                txtTamanho.Text = String.Empty;
                txtTamanho.Select();
            }
            else
            {
                if (clsFornecedor.validaCaracter(txtTamanho.Text))
                {
                    errorProvider1.SetError(txtTamanho, "O tamanho do item não pode conter caracteres \ncomo: ', #, @, $ ");
                    txtTamanho.Text = String.Empty;
                    txtTamanho.Select();
                }
                else
                {
                    errorProvider1.SetError(txtTamanho, String.Empty);
                    txtDescricao.Focus();
                }
            }
        }

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (!br.model.clsItem.validaTamanho(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "Informe a descrição do e. p. i.");
                txtDescricao.Text = String.Empty;
                txtDescricao.Select();
            }
            else
            {
                br.model.clsItem i = new br.model.clsItem();                
                DataTable dt = i.searchItem("nome_item ='" + txtNomeItem.Text + "' and tipo_item = '" + txtDescricao.Text + "' and tamanho_item = '" + txtTamanho.Text + "'");
                int linha = dt.Rows.Count;
                if (linha > 0)
                {
                    inicial();
                    MessageBox.Show("Esse e. p. i. já está cadastrado!\nA operação foi cancelada.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {
                    if (clsFornecedor.validaCaracter(txtDescricao.Text))
                    {
                        errorProvider1.SetError(txtDescricao, "A descrição do e. p. i. não pode conter caracteres como: ', #, @, $. ");
                        txtDescricao.Text = String.Empty;
                        txtDescricao.Select();
                    }
                    else
                    {
                        errorProvider1.SetError(txtDescricao, String.Empty);
                        txtEstoqueMin.Focus();
                    }
                }                
            }
        }

        private void txtEstoqueMin_Validating(object sender, CancelEventArgs e)
        {
            if (!br.data.clsDataBaseConnection.validaNumber(txtEstoqueMin.Text))
            {
                errorProvider1.SetError(txtEstoqueMin, "Informe a quantidade mínima em estoque, deve ser apenas numero.");
                txtEstoqueMin.Text = String.Empty; ;
                txtEstoqueMin.Select();

            }else{
                if(br.model.clsItem.validaCaracter(txtEstoqueMin.Text)){
                    errorProvider1.SetError(this.txtEstoqueMin, "A descrição do estoque mínimo de e. p. i. \n não pode conter caracteres como: ', #, @, $. ");
                    txtEstoqueMin.Text = String.Empty;
                    txtEstoqueMin.Select();
                }
                else
                {
                    errorProvider1.SetError(txtEstoqueMin, String.Empty);
                    btSalvar.Enabled = true;
                    btDeletar.Enabled = true;
                    btSalvar.Select();
                }
            }
                        
        }

       

        
        private void cbFornecedor_Validating(object sender, CancelEventArgs e)
        {
            if (cbFornecedor.Text == "           Selecionar  Fornecedor ")
            {
                errorProvider1.SetError(cbFornecedor, "Selecione o Fornecedor");
                cbFornecedor.Select();
            }
            else {
                errorProvider1.SetError(cbFornecedor, String.Empty);
                txtNomeItem.Focus();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                 br.model.clsItem i = new br.model.clsItem();
                try
                {
                    i.CAItem = Convert.ToInt32(txtCa.Text);
                    i.NomeItem = txtNomeItem.Text;
                    i.TipoItem = txtDescricao.Text;
                    i.TamanhoItem = txtTamanho.Text;
                    i.QtdEstoque = 0;
                    i.EstoqueMin = Convert.ToInt32(txtEstoqueMin.Text);
                    i.Fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                    i.addItem();
                   
                     MessageBox.Show("E. p. i. adicionado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                inicial();
            }
            else {
                try
                {
                    br.model.clsItem i = new br.model.clsItem(txtCodigo.Text);

                    i.Codigo = Convert.ToInt32(txtCodigo.Text);
                    i.CAItem = Convert.ToInt32(txtCa.Text);
                    i.NomeItem = txtNomeItem.Text;
                    i.TipoItem = txtDescricao.Text;
                    i.TamanhoItem = txtTamanho.Text;
                    i.EstoqueMin = Convert.ToInt32(txtEstoqueMin.Text);
                    i.Fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                    i.addItem();

                    MessageBox.Show("E. p. i. atualizado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                
            }
            cargaGrid();            
            inicial();
        }

        public void limpaCampos() {

            txtCa.Text = String.Empty;
            txtCodigo.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtNomeItem.Text = String.Empty;
            txtTamanho.Text = String.Empty;
            txtEstoqueMin.Text = String.Empty;
            cbFornecedor.Text = "           Selecionar  Fornecedor ";
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                inicial();
                txtConsultar.Select();
            }
            else {
                br.model.clsItem i = new br.model.clsItem();
                i.Codigo = Convert.ToInt32(txtCodigo.Text);
                if(MessageBox.Show("Tem certeza que deseja excluir o e. p. i. selecionado?", "Kronus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes){
                    try
                    {
                        i.deleteItem();
                        MessageBox.Show("E. p. i. excluido com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicial();
                        cargaGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            cargaGrid();
            
        }

        
        public void carregaObjeto(){
            txtCodigo.Visible = true;
            lbCodigo.Visible = true;
            txtNomeItem.Enabled = true;
            txtDescricao.Enabled = true;
            txtCa.Enabled = true;
            txtTamanho.Enabled = true;
            cbFornecedor.Enabled = true;
            txtEstoqueMin.Enabled = true;

            txtCodigo.Text = dgItem.Rows[dgItem.CurrentRow.Index].Cells[0].Value.ToString();
            txtCa.Text = dgItem.Rows[dgItem.CurrentRow.Index].Cells[4].Value.ToString();
            cbFornecedor.Text=dgItem.Rows[dgItem.CurrentRow.Index].Cells[5].Value.ToString();
            txtNomeItem.Text=dgItem.Rows[dgItem.CurrentRow.Index].Cells[1].Value.ToString();
            txtDescricao.Text = dgItem.Rows[dgItem.CurrentRow.Index].Cells[2].Value.ToString();
            txtTamanho.Text = dgItem.Rows[dgItem.CurrentRow.Index].Cells[3].Value.ToString();
            txtEstoqueMin.Text = dgItem.Rows[dgItem.CurrentRow.Index].Cells[7].Value.ToString();
            txtConsultar.Enabled = false;
            btConsultar.Enabled = false;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            br.model.clsItem i = new br.model.clsItem();
            if (String.IsNullOrEmpty(txtConsultar.Text))
            {
                MessageBox.Show("Informe o nome do e. p. i. para consulta.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultar.Select();
            }
            else {
                try
                {
                    dgItem.DataSource = i.searchItem("nome_item like '%" + txtConsultar.Text + "%'");
                    dgItem.Columns["Código"].Visible = false;
                    txtConsultar.Text = String.Empty; ;                  
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }            
            }
           
        }

        private void dgItem_DoubleClick(object sender, EventArgs e)
        {
            carregaObjeto();
            carregaCombo();
            cargaGrid();
            errorProvider1.SetError(txtCa, String.Empty);
            errorProvider1.SetError(cbFornecedor, String.Empty);
            errorProvider1.SetError(txtNomeItem, String.Empty);
            errorProvider1.SetError(txtDescricao, String.Empty);
            errorProvider1.SetError(txtEstoqueMin, String.Empty);
            errorProvider1.SetError(txtTamanho, String.Empty);
            btDeletar.Enabled = true;
        }

             

       
                        
    }
}
