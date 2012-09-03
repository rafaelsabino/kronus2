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
    public partial class wfEntrega : Form
    {
        public wfEntrega()
        {
            InitializeComponent();
        }

        private void wfEntrega_Load(object sender, EventArgs e)
        {
            limpaCampos();
            inicial();
            cargaGrid();
           
        }

        public void cargaComboFunc() {
            br.model.clsFuncionario f = new br.model.clsFuncionario();
            try
            {
                cbFuncionario.DataSource = f.carregarCombo();
                cbFuncionario.DisplayMember = ("nome_funcionario");
                cbFuncionario.ValueMember = ("cod_funcionario");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
           
        }

        public void cargaGrid() {
            br.model.clslogEntrega le = new br.model.clslogEntrega();
            try
            {
                dgLogEntrega.DataSource = le.searchLogEntrega();
                dgLogEntrega.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        public void limpaCampos() {
            if (tcEntrega.SelectedIndex == 0)
            {
                txtCodigo.Text = String.Empty;
                txtData.Text = String.Empty; ;
                txtQuantidade.Text = String.Empty;
                cbDescricao.Text = String.Empty;
                cbFuncionario.Text = String.Empty;
                cbItem.Text = String.Empty;
                cbTamanho.Text = String.Empty;
            }
            else { 
                if(tcEntrega.SelectedIndex == 1){
                    txtConsultaVenc.Text = String.Empty;
                }
            }
        }

        public void cargaComboItem() {
            br.model.clsItem i = new br.model.clsItem();
            try
            {
                cbItem.DataSource = i.retornaItemComboCompra();
                cbItem.DisplayMember=("nome_item");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void cargaComboDescricao() {
            br.model.clsItem i = new br.model.clsItem();
            try
            {
                cbDescricao.DataSource = i.retornaDescricaoCompra("nome_item = '" + cbItem.Text + "'");
                cbDescricao.DisplayMember=("tipo_item");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void cargaComboTamanho() {
            br.model.clsItem i = new br.model.clsItem();

            try
            {
                cbTamanho.DataSource= i.retornaTamanhoCompra("tipo_item = '" + cbDescricao.Text + "'");
                cbTamanho.DisplayMember = ("tamanho_item");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void inicial() {
            if (tcEntrega.SelectedIndex == 0)
            {
                cargaComboFunc();
                cargaComboItem();
                
                cargaComboTamanho();
                lbCodigo.Visible = true;
                lbData.Visible = true;
                lbDescricao.Visible = true;
                lbEpi.Visible = true;
                lbFunc.Visible = true;
                lbQtd.Visible = true;
                lbTamanho.Visible = true;
                txtCodigo.Visible = true;
                txtData.Visible = true;
                txtQuantidade.Visible = true;
                cbItem.Visible = true;
                cbDescricao.Visible = true;
                cbTamanho.Visible = true;
                cbFuncionario.Visible = true;
                btDeletar.Visible = false;
                limpaCampos();
                btSalvar.Enabled = false;
                btDeletar.Enabled = false;
                btCancelar.Enabled = false;
                btConsultar.Enabled = true;
                lbCodigo.Visible = true;
                txtCodigo.Visible = true;
                txtCodigo.Enabled = false;
                txtData.Enabled = false;
                txtQuantidade.Enabled = false;
                cbDescricao.Enabled = false;
                cbFuncionario.Enabled = false;
                cbItem.Enabled = false;
                cbTamanho.Enabled = false;
                txtData.CausesValidation = false;
                txtQuantidade.CausesValidation = false;
                cbDescricao.CausesValidation = false;
                cbFuncionario.CausesValidation = false;
                cbItem.CausesValidation = false;
                cbTamanho.CausesValidation = false;
                errorProvider1.SetError(txtData, String.Empty);
                errorProvider1.SetError(txtQuantidade, String.Empty);
                errorProvider1.SetError(cbDescricao, String.Empty);
                errorProvider1.SetError(cbFuncionario, String.Empty);
                errorProvider1.SetError(cbItem, String.Empty);
                errorProvider1.SetError(cbTamanho, String.Empty);
                lbConsultaFuncEnt.Visible = false;
                txtConsultaFuncEnt.Visible = false;
                btConsultaFuncEnt.Visible = false;
            }
            else {
                btSalvar.Enabled = false;
                btDeletar.Enabled = false;
                btCancelar.Enabled = false;
                btConsultar.Enabled = false;
                btNovo.Enabled = false;
            }
            
        }

        private void tcEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicial();
            limpaCampos();
        }

        private void tcEntrega_Click(object sender, EventArgs e)
        {
            if(tcEntrega.SelectedIndex == 0){
                btNovo.Enabled = true;
                btConsultar.Enabled = true;
            }
           
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            inicial();
            cadastrar();
        }

        public void cadastrar() {            
            lbCodigo.Visible = false;
            txtCodigo.Visible = false;
            txtData.Enabled = true;
            txtData.Text = DateTime.Today.ToShortDateString();
            txtData.Focus();
            txtQuantidade.Enabled = true;
            cbItem.Text = "Selecione o E. P. I";
            cbItem.Enabled = true;
            cbDescricao.Text = "Descrição do E. P. I";
            cbDescricao.Enabled = true;
            cbTamanho.Text = "Tamanho";
            cbTamanho.Enabled = true;
            cbFuncionario.Text = "          Selecione o funcionário   ";
            cbFuncionario.Enabled = true;
            txtData.CausesValidation = true;
            txtQuantidade.CausesValidation = true;
            cbDescricao.CausesValidation = true;
            cbFuncionario.CausesValidation = true;
            cbItem.CausesValidation = true;
            cbTamanho.CausesValidation = true;
            btCancelar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            inicial();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            lbCodigo.Visible = false;
            lbData.Visible = false;
            lbDescricao.Visible = false;
            lbEpi.Visible = false;
            lbFunc.Visible = false;
            lbQtd.Visible = false;
            lbTamanho.Visible = false;
            txtCodigo.Visible = false;
            txtData.Visible = false;
            txtQuantidade.Visible = false;
            cbItem.Visible = false;
            cbDescricao.Visible = false;
            cbTamanho.Visible = false;
            cbFuncionario.Visible = false;
            lbConsultaFuncEnt.Visible = true;
            txtConsultaFuncEnt.Visible = true;
            btConsultaFuncEnt.Visible = true;
            txtConsultaFuncEnt.Select();
            btCancelar.Enabled = true;
            btConsultar.Enabled = false;
        }

        private void cbItem_Validating(object sender, CancelEventArgs e)
        {
            if (cbItem.Text == "Selecione o E. P. I")
            {
                errorProvider1.SetError(cbItem, "Selecione o E. P. I para realizar a entrega");
                cbItem.Focus();
            }
            else {
                errorProvider1.SetError(cbItem, String.Empty);
                cargaComboDescricao();
                cbDescricao.Text = "Descrição do E. P. I";
            }
        }

        private void cbDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (cbDescricao.Text == "Descrição do E. P. I")
            {
                errorProvider1.SetError(cbDescricao, "Selecione a descrição do E. P. I.");
                cbDescricao.Focus();
            }
            else {
                errorProvider1.SetError(cbDescricao, String.Empty);
                cargaComboTamanho();
                cbTamanho.Text = "Tamanho";
            }
        }

        private void cbFuncionario_Validating(object sender, CancelEventArgs e)
        {
            if (cbFuncionario.Text == "          Selecione o funcionário   ")
            {
                errorProvider1.SetError(cbFuncionario, "Selecione o funcionáio.");
                cbFuncionario.Focus();
            }
            else {
                errorProvider1.SetError(cbFuncionario, String.Empty);
                
            }
        }

        private void cbTamanho_Validating(object sender, CancelEventArgs e)
        {
            if (cbTamanho.Text == "Tamanho")
            {
                errorProvider1.SetError(cbTamanho, "Informe o tamanho do E. P. I.");
                cbTamanho.Focus();
            }
            else {
                errorProvider1.SetError(cbTamanho, String.Empty);
                txtQuantidade.Select();
            }
        }

        private void txtData_Validating(object sender, CancelEventArgs e)
        {
            if(){}
        }

                             

        
    }
}
