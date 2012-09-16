using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronus_v2.Gui
{
    public partial class wfFuncionario : Form
    {
        public wfFuncionario()
        {
            InitializeComponent();
        }

        private void wfFuncionario_Load(object sender, EventArgs e)
        {
            inicial();
        }

        public void inicial() {
            txtnome.CausesValidation = false;
            lbCodFunc.Visible = true;
            txtCodigo.Visible = true;
            txtCodigo.Text = String.Empty;
            txtCodigo.Enabled = false;
            txtnome.Text = String.Empty;
            txtnome.Enabled = false;
            txtConsulta.Enabled = true;
            txtConsulta.Text = String.Empty;
            btConsulta.Enabled = true;
            rbAtivo.Checked = true;
            rbAtivo.Enabled = false;
            rbAfastado.Enabled = false;
            rbDemitido.Enabled = false;
            errorProvider1.SetError(this.txtnome, String.Empty);
            cargaGrid();
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            txtnome.CausesValidation = true;
            txtConsulta.Select();
        }

        public void cadastrar() {
            inicial();
            lbCodFunc.Visible = false;
            txtCodigo.Visible = false;
            txtnome.Enabled = true;
            txtnome.Text = String.Empty;
            rbAfastado.Enabled = true;
            rbAtivo.Enabled = true;
            rbDemitido.Enabled = true;
            txtConsulta.Enabled = false;
            btConsulta.Enabled = false;
            btCancelar.Enabled = true;
            txtnome.Select();
        }

        public void cargaGrid() {
            br.model.clsFuncionario f = new br.model.clsFuncionario();
            try
            {
                dgFuncionario.DataSource = f.searchFuncionario();
                dgFuncionario.Columns["Código"].Visible = false;
                dgFuncionario.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                throw;
            }
            
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cadastrar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            inicial();
        }

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(txtnome.Text) || !br.data.clsDataBaseConnection.validaString(txtnome.Text))
            {
                errorProvider1.SetError(this.txtnome, "Informe o nome do funcionário.\nEste não deve conter números ou caracteres especiais.");
                txtnome.Text = String.Empty;
                txtnome.Select();
            }
            else {
                    errorProvider1.SetError(this.txtnome, String.Empty);
                    btSalvar.Enabled = true;
                    btSalvar.Select();                             
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String status = String.Empty;
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                br.model.clsFuncionario f = new br.model.clsFuncionario();
                System.Data.DataTable dt = f.searchFuncionario("nome_funcionario = '" + txtnome.Text + "'");
                int linha = dt.Rows.Count;
                if (linha > 0)
                {
                    inicial();
                    MessageBox.Show("Esse funcionário já está cadastrado!\nA operação foi cancelada.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    try
                    {
                        f.nomeFuncionario = txtnome.Text;
                        if (rbAtivo.Checked)
                        {
                            status = "ATIVO";
                        }
                        else
                        {
                            if (rbAfastado.Checked)
                            {
                                status = "AFASTADO";
                            }
                            else
                            {
                                status = "DEMITIDO";
                            }
                        }
                        f.statusFuncionario = status;
                        f.addFuncionario();
                        MessageBox.Show("Funcionário adicionado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else {
                try
                {
                    br.model.clsFuncionario f = new br.model.clsFuncionario(txtCodigo.Text);
                    f.codigoFuncionario = Convert.ToInt32(txtCodigo.Text);
                    f.nomeFuncionario = txtnome.Text;
                    if (rbAtivo.Checked)
                    {
                        status = "ATIVO";
                    }
                    else
                    {
                        if (rbAfastado.Checked)
                        {
                            status = "AFASTADO";
                        }
                        else
                        {
                            status = "DEMITIDO";
                        }
                    }
                    f.statusFuncionario = status;
                    f.addFuncionario();
                    MessageBox.Show("Funcionário atualizado com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            inicial();
        }

        private void dgFuncionario_DoubleClick(object sender, EventArgs e)
        {
            carregaObjeto();            
            btCancelar.Enabled = true;
            errorProvider1.SetError(this.txtnome, String.Empty);           
            txtConsulta.Text = String.Empty;
            txtnome.Focus();
            cargaGrid();
        }

        public void carregaObjeto() {
            lbCodFunc.Visible = true;
            txtCodigo.Visible = true;
            txtnome.Enabled = true;
            rbAtivo.Enabled = true;
            rbAfastado.Enabled = true;
            rbDemitido.Enabled = true;
            txtConsulta.Enabled = false;
            btConsulta.Enabled = false;
            
            try
            {
                br.model.clsFuncionario f = new br.model.clsFuncionario();
                String ativo = "ATIVO";
                String afastado = "AFASTADO";
                String demitido = "DEMITIDO";
                String status = dgFuncionario.Rows[dgFuncionario.CurrentRow.Index].Cells[2].Value.ToString();
                txtCodigo.Text = dgFuncionario.Rows[dgFuncionario.CurrentRow.Index].Cells[0].Value.ToString();
                txtnome.Text = dgFuncionario.Rows[dgFuncionario.CurrentRow.Index].Cells[1].Value.ToString();

                if (String.Compare(ativo, status, true) == 0 )
                {
                    rbAtivo.Checked = true;
                }
                else {
                    if (String.Compare(afastado, status, true) == 0)
                    {
                        rbAfastado.Checked = true;
                    }
                    else {
                        if(String.Compare(demitido, status, true) == 0)
                        {
                            rbDemitido.Checked = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConsulta.Text))
            {
                MessageBox.Show("Informe o nome do funcionário para consulta!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsulta.Select();
            }
            else {
                br.model.clsFuncionario f = new br.model.clsFuncionario();
                dgFuncionario.DataSource = f.searchFuncionario("nome_funcionario like '%" + txtConsulta.Text + "%'");
                dgFuncionario.Columns["Código"].Visible = false;
                txtConsulta.Text = String.Empty;
                dgFuncionario.Refresh();
            }
        }

       
        

        
    }
}
