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
    public partial class wfFornecedor : Form
    {
        public wfFornecedor()
        {
            InitializeComponent();
        }

        private void wfFornecedor_Load(object sender, EventArgs e)
        {
            inicial();
           
        }

        public void limpaCampos() {
            txtCodfornec.Text = "";
            txtNomeFornec.Text = "";
            mtTelFornec.Text = "";
            txtemailFornec.Text = "";
        }

        public void cargaGrid() {

            clsFornecedor obj = new clsFornecedor();
            try
            {
                dgFornec.DataSource = obj.searchFornecedor();
                dgFornec.Columns["Código"].Visible = false;
                dgFornec.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                      
                   
        }

        public void inicial() {
            limpaCampos();
            txtNomeFornec.CausesValidation = false;
            txtemailFornec.CausesValidation = false;
            lbCodfornec.Visible = true;
            txtCodfornec.Visible = true;
            txtCodfornec.Enabled = false;
            txtNomeFornec.Enabled = false;
            mtTelFornec.Enabled = false;
            txtemailFornec.Enabled = false;            
            txtConsultaFornec.Enabled = true;
            txtConsultaFornec.Text = "";
            btConsultar.Enabled = true;
            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
            errorProvider1.SetError(this.txtNomeFornec, String.Empty);
            errorProvider1.SetError(this.txtemailFornec, String.Empty);
            cargaGrid();
            txtNomeFornec.CausesValidation = true; ;
            txtemailFornec.CausesValidation = true; ;
            txtConsultaFornec.Select();

        }

        public void cadastrar() {
            lbCodfornec.Visible = false;
            txtCodfornec.Visible = false;
            txtConsultaFornec.Enabled = false;
            btConsultar.Enabled = false;
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
            txtNomeFornec.Enabled = true;
            mtTelFornec.Enabled = true;
            txtemailFornec.Enabled = true;
            btExcluir.Enabled = true;
            txtNomeFornec.Select();
            cargaGrid();
           
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            inicial();
            cadastrar();                         
            txtNomeFornec.Select();
                       
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtCodfornec.Text))
            {
                inicial();

            }
            else
            {
                clsFornecedor f = new clsFornecedor();
                f.codigo = Convert.ToInt32(txtCodfornec.Text);
                if (MessageBox.Show("Tem certeza que deseja excluir o fornecedor selecionado?", "Kronus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        f.deleteFornecedor();
                        MessageBox.Show("Fornecedor excuido com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicial();
                        limpaCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inicial();
                    }
                }
                              
                
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodfornec.Text))
            {
                try
                {
                    clsFornecedor f = new clsFornecedor();

                    f.nome = txtNomeFornec.Text;
                    f.telefone = mtTelFornec.Text;
                    f.email = txtemailFornec.Text;

                    f.addFornecedor();
                    MessageBox.Show("Fornecedor adicionado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                try
                {
                    clsFornecedor f = new clsFornecedor(txtCodfornec.Text);

                    f.codigo = Convert.ToInt32(txtCodfornec.Text);
                    f.nome = txtNomeFornec.Text;
                    f.telefone = mtTelFornec.Text;
                    f.email = txtemailFornec.Text;

                    f.addFornecedor();

                    MessageBox.Show("Fornecedor atualizado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inicial();
                }
                
            }
            limpaCampos();
            inicial();
            
        }

        public void carregaObjeto() {
            lbCodfornec.Visible = true;
            txtCodfornec.Visible = true;
            txtCodfornec.ReadOnly = true;
            txtNomeFornec.Enabled = true;
            txtemailFornec.Enabled=true;
            mtTelFornec.Enabled=true;
            txtConsultaFornec.Enabled = false;            

            txtCodfornec.Text = dgFornec.Rows[dgFornec.CurrentRow.Index].Cells[0].Value.ToString();
            txtNomeFornec.Text = dgFornec.Rows[dgFornec.CurrentRow.Index].Cells[1].Value.ToString();
            mtTelFornec.Text = dgFornec.Rows[dgFornec.CurrentRow.Index].Cells[3].Value.ToString();
            txtemailFornec.Text = dgFornec.Rows[dgFornec.CurrentRow.Index].Cells[2].Value.ToString();
        }

        private void dgFornec_DoubleClick(object sender, EventArgs e)
        {
            carregaObjeto();
            cargaGrid();
            errorProvider1.SetError(this.txtNomeFornec, String.Empty);
            errorProvider1.SetError(this.txtemailFornec, String.Empty);
            btNovo.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = true;

        }

        
        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConsultaFornec.Text))
            {
                MessageBox.Show("Informe o nome do fornecedor para consulta.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                txtConsultaFornec.Select();
            }
            else {

                clsFornecedor f = new clsFornecedor();

                try
                {
                    dgFornec.DataSource = f.searchFornecedor("nome_fornecedor like '%" + txtConsultaFornec.Text + "%'");
                    dgFornec.Columns["Código"].Visible = false;
                    DataTable dt = f.searchFornecedor("nome_fornecedor like '%" + txtConsultaFornec.Text + "%'");
                    int linhas = dt.Rows.Count;
                    txtConsultaFornec.Text = "";
                    if(linhas < 1){
                        cargaGrid();
                        MessageBox.Show("O fornecedor não foi encontrado!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtConsultaFornec.Select();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inicial();
                }
                dgFornec.Refresh();
                
            }
        }

        private void txtNomeFornec_Validating(object sender, CancelEventArgs e)
        {
            if (txtNomeFornec.Text.Length == 0 || !clsFornecedor.validaString(txtNomeFornec.Text))
            {
                errorProvider1.SetError(txtNomeFornec, "Informe o nome do fornecedor, não deve conter números\nou caracteres especiais como: ', #, @, $ etc.");
                txtNomeFornec.Text = String.Empty;
                txtNomeFornec.Select();
            }
            else {
                clsFornecedor f = new clsFornecedor();
                DataTable dt = f.searchFornecedor("nome_fornecedor = '" + txtNomeFornec.Text + "'");
                int linha = dt.Rows.Count;
                dgFornec.DataSource = dt;

                if (linha > 0)
                {
                    inicial();
                    MessageBox.Show("O fornecedor já está cadastrado.\nOperação cancelada.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                                    
                }
                else {
                    if (clsFornecedor.validaCaracter(txtNomeFornec.Text))
                    {
                        errorProvider1.SetError(txtNomeFornec, "O nome do fornecedor não pode conter caracteres como: ', #, @, $ ");
                        txtNomeFornec.Text = String.Empty;
                        txtNomeFornec.Select();
                    }
                    else
                    {
                        errorProvider1.SetError(this.txtNomeFornec, String.Empty);
                    }
                    cargaGrid();
                }
                
            }
        }      
        
                
        private void txtemailFornec_Validating(object sender, CancelEventArgs e)
        {
            if (txtemailFornec.Text.Length == 0)
            {
                errorProvider1.SetError(txtemailFornec, "Informe o email do Fornecedor.");
                txtemailFornec.Select();
            }
            else
            {
                if (!clsFornecedor.validaEmail(txtemailFornec.Text))
                {
                    errorProvider1.SetError(txtemailFornec, "Formato de email inválido!");
                    txtemailFornec.Text = String.Empty;
                    txtemailFornec.Select();

                }
                else
                {
                    errorProvider1.SetError(this.txtemailFornec, String.Empty);
                    btSalvar.Enabled = true;
                    btExcluir.Enabled = true;
                }
            }
        }

       
    }
}
