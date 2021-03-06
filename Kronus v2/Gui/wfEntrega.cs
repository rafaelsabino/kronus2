﻿using System;
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
           
            inicial();
            cargaGrid();
            limpaCampos();
        }

        public void cargaComboFunc() {
            br.model.clsFuncionario f = new br.model.clsFuncionario();
            try
            {
                cbFuncionario.DataSource = f.carregarCombo("status_funcionario = 'ATIVO'");
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
                dgLogEntrega.Columns["Código"].Visible = false;
                dgLogEntrega.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }

        public void limpaCampos() {
            if (tcEntrega.SelectedIndex == 0)
            {
                txtCodigo.Text = String.Empty;
                dtpDataEntrega.Value = Convert.ToDateTime(DateTime.Today.ToShortDateString());
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
               
            }
        }

        public void inicial() {
            if (tcEntrega.SelectedIndex == 0)
            {
                cargaComboFunc();
                cargaComboItem();
                cargaGrid();
                cargaComboTamanho();
                lbCodigo.Visible = true;
                lbData.Visible = true;
                lbDescricao.Visible = true;
                lbEpi.Visible = true;
                lbFunc.Visible = true;
                lbQtd.Visible = true;
                lbTamanho.Visible = true;
                txtCodigo.Visible = true;
                dtpDataEntrega.Visible = true;
                txtQuantidade.Visible = true;
                cbItem.Visible = true;
                cbDescricao.Visible = true;
                cbTamanho.Visible = true;
                cbFuncionario.Visible = true;
                btDeletar.Visible = false;
                btSalvar.Enabled = false;
                btDeletar.Enabled = false;
                btCancelar.Enabled = false;
                btConsultar.Enabled = true;
                lbCodigo.Visible = true;
                txtCodigo.Visible = true;
                txtCodigo.Enabled = false;
                dtpDataEntrega.Enabled = false;
                txtQuantidade.Enabled = false;
                cbDescricao.Enabled = false;
                cbFuncionario.Enabled = false;
                cbItem.Enabled = false;
                cbTamanho.Enabled = false;
                dtpDataEntrega.CausesValidation = false;
                txtQuantidade.CausesValidation = false;
                cbDescricao.CausesValidation = false;
                cbFuncionario.CausesValidation = false;
                cbItem.CausesValidation = false;
                cbTamanho.CausesValidation = false;
                errorProvider1.SetError(dtpDataEntrega, String.Empty);
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
                if (tcEntrega.SelectedIndex == 1)
                {
                    cargaGridEntVenc();
                    btSalvar.Enabled = false;
                    btDeletar.Enabled = false;
                    btCancelar.Enabled = true; ;
                    btConsultar.Enabled = false;
                    btNovo.Enabled = false;
                }
                else { 
                    if(tcEntrega.SelectedIndex == 2){
                    btSalvar.Enabled = false;
                    btDeletar.Enabled = false;
                    btCancelar.Enabled = false;
                    btConsultar.Enabled = false;
                    btNovo.Enabled = false;
                    }
                }                
            }
            
        }

        private void tcEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            inicial();           
        }

        private void tcEntrega_Click(object sender, EventArgs e)
        {
            if (tcEntrega.SelectedIndex == 0)
            {
                inicial();
                btNovo.Enabled = true;
                btConsultar.Enabled = true;                
                limpaCampos();
            }
            else {
                if (tcEntrega.SelectedIndex == 1)
                {
                    inicial();
                    txtConsultaVenc.Select();
                    cargaGridEntVenc();
                }
                else { 
                    if(tcEntrega.SelectedIndex == 2){
                        inicial();
                        cargaGridEstoque();
                    }
                }
            }
           
        }

        public void cargaGridEstoque() {
            br.model.clsItem i = new br.model.clsItem();

            dgVisaoEstoque.DataSource = i.searchItem("quantidade_estoque <= estoque_min");
            dgVisaoEstoque.Columns["Mínimo em estoque"].Visible = false;
            dgVisaoEstoque.Columns["Código"].Visible = false;
        }

        public void cargaGridEntVenc() {
            br.model.clsEntrega ent = new br.model.clsEntrega();
            try
            {
                dgEntregaVenc.DataSource = ent.searchEntrega("nome_item like '%CREME%'  and data_entrega <= getdate() - 30" +
               "or nome_item like '%PROTETOR%' and data_entrega <= getdate() - 120 ");
                dgEntregaVenc.Columns["Código"].Visible = false;
                dgEntregaVenc.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            dtpDataEntrega.Enabled = true;
            dtpDataEntrega.MaxDate = DateTime.Today;
            limpaCampos();
            dtpDataEntrega.Focus();
            txtQuantidade.Enabled = true;
            cbItem.Text = "Selecione o E. P. I";
            cbItem.Enabled = true;
            cbDescricao.Text = "Descrição do E. P. I";
            cbDescricao.Enabled = true;
            cbTamanho.Text = "Tamanho";
            cbTamanho.Enabled = true;
            cbFuncionario.Text = "          Selecione o funcionário   ";
            cbFuncionario.Enabled = true;
            dtpDataEntrega.CausesValidation = true;
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
            limpaCampos();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (tcEntrega.SelectedIndex == 0)
            {
                lbCodigo.Visible = false;
                lbData.Visible = false;
                lbDescricao.Visible = false;
                lbEpi.Visible = false;
                lbFunc.Visible = false;
                lbQtd.Visible = false;
                lbTamanho.Visible = false;
                txtCodigo.Visible = false;
                dtpDataEntrega.Visible = false;
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
                btCancelar.Enabled = true;
                
            }
                       
        }

        private void cbItem_Validating(object sender, CancelEventArgs e)
        {
            if (cbItem.Text == "Selecione o E. P. I")
            {
                errorProvider1.SetError(cbItem, "Selecione o E. P. I para realizar a entrega");
                cbItem.Focus();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(cbItem, String.Empty);
                cargaComboDescricao();
                cbDescricao.Text = "Descrição do E. P. I";
                cbDescricao.Focus();
            }
        }

        private void cbDescricao_Validating(object sender, CancelEventArgs e)
        {
            if (cbDescricao.Text == "Descrição do E. P. I")
            {
                errorProvider1.SetError(cbDescricao, "Selecione a descrição do E. P. I.");
                cbDescricao.Focus();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(cbDescricao, String.Empty);
                cargaComboTamanho();
                cbTamanho.Text = "Tamanho";
                cbTamanho.Focus();
            }
        }

        private void cbFuncionario_Validating(object sender, CancelEventArgs e)
        {
            if (cbFuncionario.Text == "          Selecione o funcionário   ")
            {
                errorProvider1.SetError(cbFuncionario, "Selecione o funcionáio.");
                cbFuncionario.Focus();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(cbFuncionario, String.Empty);
                cbItem.Focus();
                
            }
        }

        private void cbTamanho_Validating(object sender, CancelEventArgs e)
        {
            if (cbTamanho.Text == "Tamanho")
            {
                errorProvider1.SetError(cbTamanho, "Informe o tamanho do E. P. I.");
                cbTamanho.Focus();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(cbTamanho, String.Empty);
                txtQuantidade.Focus();
            }
        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (!br.model.clsEntrega.validaNumber(txtQuantidade.Text) || String.IsNullOrEmpty(txtQuantidade.Text))
            {
                errorProvider1.SetError(txtQuantidade, "Informe a quantidade a ser entregue.\nEssa deve ser apenas números.");
                txtQuantidade.Text = String.Empty;
                txtQuantidade.Select();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(txtQuantidade, String.Empty);
                btSalvar.Enabled = true;
                btSalvar.Select();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {          
            br.data.clsDataBaseConnection bd = new br.data.clsDataBaseConnection();
            System.Data.DataTable dt = bd.retornaDataTable("select cod_item, quantidade_estoque from Item where nome_item = '" +
                cbItem.Text + "' and tipo_item = '" + cbDescricao.Text + "' and tamanho_item = '" + cbTamanho.Text + "'");
            int codItem = Convert.ToInt32(dt.Rows[0]["cod_item"]);
            int qtd = Convert.ToInt32(dt.Rows[0]["quantidade_estoque"]);
            if (qtd == 0)
            {
                MessageBox.Show("E. P. I selecionado em falta no estoque.\nImpossível realizar a entrega", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inicial();
            }
            else {
                if (qtd < Convert.ToInt32(txtQuantidade.Text))
                {
                    MessageBox.Show("Você posui do E. P. I selecionado apenas " + qtd + " em estoque.",
                        "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inicial();
                }
                else {
                    if (String.IsNullOrEmpty(txtCodigo.Text))
                    {
                        System.Data.DataTable dt2 = bd.retornaDataTable("select cod_entrega from Entrega where cod_item_fk = '" + codItem +
                            "' and cod_funcionario_fk = '" + cbFuncionario.SelectedValue + "'");
                        if (dt2.Rows.Count > 0)
                        { //Existe entrega 
                            int codEnt = Convert.ToInt32(dt2.Rows[0]["cod_entrega"]);
                            br.model.clsEntrega ent = new br.model.clsEntrega(codEnt.ToString());
                            br.model.clslogEntrega log = new br.model.clslogEntrega();
                            try
                            {
                                ent.CodigoEntrega = codEnt;
                                ent.DataEntrega = Convert.ToDateTime(this.dtpDataEntrega.Value.ToShortDateString());
                                ent.codItem = codItem;
                                ent.CodFuncionario = Convert.ToInt32(this.cbFuncionario.SelectedValue);
                                ent.QuantidadeEntrega = Convert.ToInt32(this.txtQuantidade.Text);
                                log.DataLogEntrega = Convert.ToDateTime(this.dtpDataEntrega.Value.ToShortDateString());
                                log.FuncionarioLogEntrega = Convert.ToInt32(this.cbFuncionario.SelectedValue);
                                log.ItemLogEntrega = codItem;
                                log.QuantidadeLogEntrega = Convert.ToInt32(this.txtQuantidade.Text);
                                ent.addEntrega();
                                log.addLogEntrega();
                                cargaGrid();
                                inicial();
                                MessageBox.Show("Entrega realizada com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            br.model.clsEntrega ent = new br.model.clsEntrega();
                            br.model.clslogEntrega log = new br.model.clslogEntrega();
                            try
                            {
                                ent.DataEntrega = Convert.ToDateTime(this.dtpDataEntrega.Value.ToShortDateString());
                                ent.codItem = codItem;
                                ent.CodFuncionario = Convert.ToInt32(this.cbFuncionario.SelectedValue);
                                ent.QuantidadeEntrega = Convert.ToInt32(this.txtQuantidade.Text);
                                log.DataLogEntrega = Convert.ToDateTime(this.dtpDataEntrega.Value.ToShortDateString());
                                log.FuncionarioLogEntrega = Convert.ToInt32(this.cbFuncionario.SelectedValue);
                                log.ItemLogEntrega = codItem;
                                log.QuantidadeLogEntrega = Convert.ToInt32(this.txtQuantidade.Text);
                                ent.addEntrega();
                                log.addLogEntrega();
                                cargaGrid();
                                inicial();
                                MessageBox.Show("Entrega realizada com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        System.Data.DataTable dt2 = bd.retornaDataTable("select cod_entrega from Entrega where cod_item_fk = '" + codItem +
                           "' and cod_funcionario_fk = '" + cbFuncionario.SelectedValue + "'");
                        int codEnt = Convert.ToInt32(dt2.Rows[0]["cod_entrega"]);
                        br.model.clsEntrega ent = new br.model.clsEntrega(codEnt.ToString());
                        br.model.clslogEntrega log = new br.model.clslogEntrega();
                        try
                        {
                            ent.CodigoEntrega = codEnt;
                            ent.DataEntrega = Convert.ToDateTime(this.dtpDataEntrega.Value.ToShortDateString());
                            ent.codItem = codItem;
                            ent.CodFuncionario = Convert.ToInt32(this.cbFuncionario.SelectedValue);
                            ent.QuantidadeEntrega = Convert.ToInt32(this.txtQuantidade.Text);
                            log.DataLogEntrega = Convert.ToDateTime(this.dtpDataEntrega.Value.ToShortDateString());
                            log.FuncionarioLogEntrega = Convert.ToInt32(this.cbFuncionario.SelectedValue);
                            log.ItemLogEntrega = codItem;
                            log.QuantidadeLogEntrega = Convert.ToInt32(txtQuantidade.Text);
                            ent.addEntrega();
                            log.addLogEntrega();
                            cargaGrid();
                            inicial();
                            MessageBox.Show("Entrega realizada com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                limpaCampos();
                cargaGridEntVenc();
            }
        }
                

        private void btConsultaFuncEnt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConsultaFuncEnt.Text))
            {
                MessageBox.Show("Informe o nome do funcionário para consulta.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultaFuncEnt.Focus();
            }
            else
            {
                br.model.clslogEntrega log = new br.model.clslogEntrega();
                
                try
                {                    
                    dgLogEntrega.DataSource = log.searchLogEntrega("nome_funcionario like '%" + txtConsultaFuncEnt.Text + "%'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtConsultaFuncEnt.Text = String.Empty;
                dgLogEntrega.Refresh();
            }
        }

        private void dgLogEntrega_DoubleClick(object sender, EventArgs e)
        {            
            carregaObjeto();
            
        }

        public void carregaObjeto() {
            errorProvider1.SetError(dtpDataEntrega, String.Empty);
            errorProvider1.SetError(txtQuantidade, String.Empty);
            errorProvider1.SetError(cbDescricao, String.Empty);
            errorProvider1.SetError(cbFuncionario, String.Empty);
            errorProvider1.SetError(cbItem, String.Empty);
            errorProvider1.SetError(cbTamanho, String.Empty);
            cargaComboFunc();
            cargaComboItem();
            cargaComboDescricao();
            cargaComboTamanho();
            btSalvar.Enabled = false;
            btDeletar.Visible = true;
            btDeletar.Enabled = true;
            btCancelar.Enabled = true;
            btConsultar.Enabled = true;
            lbCodigo.Visible = true;
            txtCodigo.Visible = true;
            txtCodigo.Enabled = false;
            dtpDataEntrega.Enabled = false;
            txtQuantidade.Enabled = false;
            cbDescricao.Enabled = false;
            cbFuncionario.Enabled = false;
            cbItem.Enabled = false;
            cbTamanho.Enabled = false;
            lbCodigo.Visible = true;
            lbData.Visible = true;
            lbDescricao.Visible = true;
            lbEpi.Visible = true;
            lbFunc.Visible = true;
            lbQtd.Visible = true;
            lbTamanho.Visible = true;
            txtCodigo.Visible = true;
            dtpDataEntrega.Visible = true;
            txtQuantidade.Visible = true;
            cbItem.Visible = true;
            cbDescricao.Visible = true;
            cbTamanho.Visible = true;
            cbFuncionario.Visible = true;
            lbConsultaFuncEnt.Visible = false;
            txtConsultaFuncEnt.Visible = false;
            btConsultaFuncEnt.Visible = false;
            limpaCampos();
            txtCodigo.Text = dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[0].Value.ToString();
            dtpDataEntrega.Value = Convert.ToDateTime(dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[1].Value);
            cbFuncionario.Text = dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[2].Value.ToString();
            cbItem.Text = dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[3].Value.ToString();
            cbDescricao.Text = dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[4].Value.ToString();
            cbTamanho.Text = dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[5].Value.ToString();
            txtQuantidade.Text = dgLogEntrega.Rows[dgLogEntrega.CurrentRow.Index].Cells[6].Value.ToString();
            cargaGrid();
                    
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            br.model.clslogEntrega log = new br.model.clslogEntrega();
            log.CodLogEntrega = Convert.ToInt32(txtCodigo.Text);
            if(MessageBox.Show("Tem certeza que deseja excluir a entrega selecionada?", "Kronus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes){
                try
                {
                    log.deleteLogEntrega();
                    cargaGrid();                    
                    inicial();
                    limpaCampos();
                    MessageBox.Show("Entrega excluida com sucesso!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpaCampos();
                }
                
            }
            
        }

        private void btConsultaEntregaVenc_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtConsultaVenc.Text))
            {
                MessageBox.Show("Informe o nome do funcionário para consulta.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConsultaVenc.Text = String.Empty;
                txtConsultaVenc.Select();
            }
            else {
                if (MessageBox.Show("Deseja exibir apenas as entregas vencidas?", "Kronus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    br.model.clsEntrega en = new br.model.clsEntrega();
                    dgEntregaVenc.DataSource = en.searchEntrega("nome_item like '%CREME%' and data_entrega < getDate() - 30  or nome_item like '%PROTETOR%' and data_entrega < getdate() - 120 and nome_funcionario like '%" + txtConsultaVenc.Text + "%'");
                    dgEntregaVenc.Columns["Código"].Visible = false;
                    dgEntregaVenc.Refresh();
                    txtConsultaVenc.Text = String.Empty;
                }
                else {
                    br.model.clsEntrega en = new br.model.clsEntrega();
                    dgEntregaVenc.DataSource = en.searchEntrega("nome_item like '%CREME%' or nome_item like '%PROTETOR%' and nome_funcionario like '%" + txtConsultaVenc.Text + "%'");
                    dgEntregaVenc.Columns["Código"].Visible = false;
                    dgEntregaVenc.Refresh();
                    txtConsultaVenc.Text = String.Empty;
                }
                
            }
           
        }

        private void dgEntregaVenc_DoubleClick(object sender, EventArgs e)
        {
            carregaObjetoVencido();
        }


        public void carregaObjetoVencido() {           
            tcEntrega.SelectedIndex = 0;
            txtCodigo.Text = dgEntregaVenc.Rows[dgEntregaVenc.CurrentRow.Index].Cells[0].Value.ToString();
            dtpDataEntrega.Value = Convert.ToDateTime(DateTime.Today);
            cbFuncionario.Text = dgEntregaVenc.Rows[dgEntregaVenc.CurrentRow.Index].Cells[1].Value.ToString();
            cbItem.Text = dgEntregaVenc.Rows[dgEntregaVenc.CurrentRow.Index].Cells[4].Value.ToString();
            cbDescricao.Text = dgEntregaVenc.Rows[dgEntregaVenc.CurrentRow.Index].Cells[5].Value.ToString();
            cbTamanho.Text = dgEntregaVenc.Rows[dgEntregaVenc.CurrentRow.Index].Cells[6].Value.ToString();
            txtQuantidade.Text = dgEntregaVenc.Rows[dgEntregaVenc.CurrentRow.Index].Cells[3].Value.ToString();
            btNovo.Enabled = true;
            btConsultar.Enabled = true;
            btCancelar.Enabled = true;
            btSalvar.Enabled = true;
            cbDescricao.Enabled = true;
            cbTamanho.Enabled = true;
            cargaComboDescricao();
            cargaComboTamanho();
        }

        private void dtpDataEntrega_Validating(object sender, CancelEventArgs e)
        {
            cbFuncionario.Focus();
        }
            

                             

        
    }
}
