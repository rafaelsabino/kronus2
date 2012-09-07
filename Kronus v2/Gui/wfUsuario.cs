using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronus_v2.Gui
{
    public partial class wfUsuario : Form
    {
        public wfUsuario()
        {
            InitializeComponent();
        }

        private void wfUsuario_Load(object sender, EventArgs e)
        {
            inicial();
            cargaGrid();
        }

        public void inicial() {
            limpaCampos();
            errorProvider1.SetError(txtNome, String.Empty);
            errorProvider1.SetError(txtLogin, String.Empty);
            errorProvider1.SetError(txtSenha, String.Empty);
            errorProvider1.SetError(txtConfirma, String.Empty);            
            txtNome.CausesValidation = false;
            txtLogin.CausesValidation = false;
            txtSenha.CausesValidation = false;
            txtConfirma.CausesValidation = false;
            lbCodUsuario.Visible = true;
            txtCodigo.Visible = true;
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirma.Enabled = false;
            txtConsulta.Enabled = true;
            btConsultar.Enabled = true;
            txtConsulta.Select();
            chbAcesso.Checked = true;
            chbAcesso.Enabled = false;
            cargaGrid();
            txtNome.CausesValidation = true;
            txtLogin.CausesValidation = true;            
            txtConfirma.CausesValidation = true;
            txtSenha.CausesValidation = true;
            txtConsulta.Select();
        }

        public void cargaGrid() {
            br.model.clsUsuário u = new br.model.clsUsuário();
            try
            {
                dgUsuário.DataSource = u.SearchUsuario();
                dgUsuário.Columns["Senha"].Visible = false;                
                dgUsuário.Columns["Tipo acesso"].Visible = false;
                dgUsuário.Columns["Senha"].ReadOnly = true;
                dgUsuário.Columns["Tipo acesso"].ReadOnly = true;
                dgUsuário.Columns["Código"].Visible = false;
               
                dgUsuário.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            

        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            limpaCampos();
            inicial();
            cadastrar();
            txtNome.Select();
        }

        public void cadastrar() {
            limpaCampos();
            txtCodigo.Visible = false;
            lbCodUsuario.Visible = false;
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtNome.ReadOnly = false;
            txtLogin.ReadOnly = false;
            txtSenha.Enabled = true;
            txtConfirma.Enabled = true;
            chbAcesso.Enabled = true;
            txtConsulta.Enabled = false;
            btConsultar.Enabled = false;
            btExcluir.Enabled = true;
            txtNome.Select();


        }

        public void limpaCampos() {
            txtCodigo.Text = String.Empty;
            txtConfirma.Text = String.Empty;
            txtConsulta.Text = String.Empty;
            txtLogin.Text = String.Empty;
            txtNome.Text = String.Empty;
            txtSenha.Text = String.Empty;
        
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {                
                inicial();
            }
            else {
                br.model.clsUsuário u = new br.model.clsUsuário();
                u.CodigoUsuario = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    if(MessageBox.Show("Tem certeza que deseja excluir o usuário selecionado?", "Kronus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes){
                        u.deleteUser();
                        MessageBox.Show("Usuário excluido com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                limpaCampos();
                inicial();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            int tAcesso = 1;
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                br.model.clsUsuário u = new br.model.clsUsuário();                
                
                try
                {                  
                    if (chbAcesso.Checked){
                        tAcesso = 0;
                    }        
                    u.NomeUsuario = txtNome.Text;
                    u.Loginusuario = txtLogin.Text;
                    u.SenhaUsuario = txtSenha.Text;
                    u.TipoAcesso = tAcesso;
                    u.addUser();
                    MessageBox.Show("Usuário adicionado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                
            }
            else {
                br.model.clsUsuário u = new br.model.clsUsuário(txtCodigo.Text);
                try
                {
                    if (chbAcesso.Checked)
                    {
                        tAcesso = 0;
                    }
                    u.CodigoUsuario = Convert.ToInt32(txtCodigo.Text);
                    u.NomeUsuario = txtNome.Text;
                    u.Loginusuario = txtLogin.Text;
                    u.SenhaUsuario = txtSenha.Text;
                    u.TipoAcesso = tAcesso;
                    u.addUser();
                    MessageBox.Show("Usuario atualizado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {   
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                
            }
            limpaCampos();
            inicial();

        }

        private void dgUsuário_DoubleClick(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNome, String.Empty);
            errorProvider1.SetError(txtLogin, String.Empty);
            errorProvider1.SetError(txtSenha, String.Empty);
            errorProvider1.SetError(txtConfirma, String.Empty);        
            carregaObjeto();            
            txtSenha.Focus();
            txtSenha.SelectAll();
            btNovo.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = true;
            cargaGrid();
        }

        public void carregaObjeto() {
            lbCodUsuario.Visible = true;
            txtCodigo.Visible = true;
            txtNome.Enabled = true;
            txtNome.CausesValidation = false;
            txtNome.ReadOnly = true;
            txtLogin.Enabled = true;
            txtLogin.ReadOnly = true;
            txtSenha.Enabled = true;
            txtConfirma.Enabled = true;            
            chbAcesso.Enabled = true;
            txtConsulta.Enabled = false;
            btConsultar.Enabled = false;

            br.model.clsUsuário u = new br.model.clsUsuário();

            txtCodigo.Text = dgUsuário.Rows[dgUsuário.CurrentRow.Index].Cells[0].Value.ToString();
            txtNome.Text = dgUsuário.Rows[dgUsuário.CurrentRow.Index].Cells[1].Value.ToString();
            txtLogin.Text = dgUsuário.Rows[dgUsuário.CurrentRow.Index].Cells[2].Value.ToString();
            txtSenha.Text = dgUsuário.Rows[dgUsuário.CurrentRow.Index].Cells[3].Value.ToString();
            txtConfirma.Text = dgUsuário.Rows[dgUsuário.CurrentRow.Index].Cells[3].Value.ToString();

            if (Convert.ToInt32(dgUsuário.Rows[dgUsuário.CurrentRow.Index].Cells[4].Value) == 0)
            {
                chbAcesso.Checked = true;
            }
            else {
                chbAcesso.Checked = false;
            }
            
                       
        }

       

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (!br.model.clsUsuário.validaString(txtNome.Text) || String.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(this.txtNome, "Informe o nome do usuário, não deve conter \nnúmeros ou caracteres especiais.");
                txtNome.Text = String.Empty;
                txtNome.Select();
            }
            else {
                br.model.clsUsuário u = new br.model.clsUsuário();
                DataTable dt = u.SearchUsuario("nome_user = '" + txtNome.Text + "'");
                int linha = dt.Rows.Count;
                if (linha > 0)
                {
                    inicial();
                    MessageBox.Show("Esse usuário já está cadastrado!\nA operação foi cancelada.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    if (br.model.clsUsuário.validaCaracter(txtNome.Text))
                    {
                        errorProvider1.SetError(this.txtNome, "O nome do usuário não pode conter caracteres como: ', #, @, $ etc. ");
                        txtNome.Text = String.Empty;
                        txtNome.Select();
                    }
                    else
                    {
                        errorProvider1.SetError(this.txtNome, String.Empty);
                    }
                }
                
                    
              }                
            }
        

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtLogin.Text))
            {
                errorProvider1.SetError(this.txtLogin, "Informe um nome para autenticar-se no sistema.");
                txtLogin.Select();
            }
            else {
                if(br.model.clsUsuário.validaCaracter(txtLogin.Text)){
                        errorProvider1.SetError(this.txtLogin,"O nome de autenticação não pode conter caracteres especiais como: ', #, @, $ etc.");
                        txtLogin.Text = String.Empty;
                        txtLogin.Select();
                }else
                    {
                        errorProvider1.SetError(this.txtLogin, String.Empty);
                    }
            }
            br.model.clsUsuário u = new br.model.clsUsuário();
            DataTable dt = u.SearchUsuario("login_user = '" + txtLogin.Text + "'");
            int linha = dt.Rows.Count;
            if (linha > 0)
            {
                MessageBox.Show("Esse nome de autenticação já se encontra em uso.\nEscolha outro nome para autenticar-se!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = String.Empty;
                errorProvider1.SetError(this.txtLogin, String.Empty);
                txtLogin.Select();
            }            
                    
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtSenha.Text))
            {
                errorProvider1.SetError(this.txtSenha, "É necessário cadastrar uma senha para acessar o sistema!");
                txtSenha.Select();
            }
            else {
                if (!br.model.clsUsuário.validaTamanho(txtSenha.Text))
                {
                    errorProvider1.SetError(this.txtSenha, "A senha deve conter apenas letras e números.");
                    txtSenha.Text = String.Empty;
                    txtSenha.Select();
                }else{
                    if (txtSenha.Text.Length < 4)
                    {
                        errorProvider1.SetError(this.txtSenha, "A senha deve conter no mínimo 4 caracteres.");
                        txtSenha.Text = String.Empty;
                        txtSenha.Select();
                    }
                    else {
                        errorProvider1.SetError(this.txtSenha, String.Empty);
                    }            
                }                
            }
        }

        private void txtConfirma_Validating(object sender, CancelEventArgs e)
        {
            if (String.Compare(txtSenha.Text, txtConfirma.Text, false) != 0)
            {
                MessageBox.Show("As senhas digitadas não conferem.\nDigite novamente.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirma.Text = String.Empty;
                txtSenha.Text = String.Empty;
                txtSenha.Select();
            }
            else {
                btSalvar.Enabled = true;
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConsulta.Text))
            {
                MessageBox.Show("Informe o nome do usuário para consulta.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsulta.Select();
            }
            else {
                br.model.clsUsuário u = new br.model.clsUsuário();

                dgUsuário.DataSource = u.SearchUsuario("nome_user like '%" + txtConsulta.Text + "%'");
                txtConsulta.Text = String.Empty;
                dgUsuário.Columns["Código"].Visible = false;
                txtConsulta.Select();
            }
        }               

    }
 }

       

       
   
