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
    public partial class wfCompra : Form
    {
        public wfCompra()
        {
            InitializeComponent();
        }

        private void wfCompra_Load(object sender, EventArgs e)
        {
            inicial();
                    
            
        }

        public void cargaComboItemCompra() {
            br.model.clsItem i = new br.model.clsItem();
            try
            {
                this.cbItemCompra.DataSource = i.retornaItemComboCompra();                                   
                this.cbItemCompra.DisplayMember = ("nome_item");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inicial();
            }
            
        }


        public void inicial() {
            btDelete.Visible = false;
            if (tcCompra.SelectedIndex == 0)
            {
                txtCodigo.Enabled = true;                
                limpaCampos();
                lbCodigo.Visible = true;
                txtCodigo.Visible = true;
                txtValor.Visible = true;
                dtpDataCompra.Visible = true;
                dtpDataCompra.Enabled = true;
                dtpDataCompra.Value = DateTime.Today;
                dtpDataCompra.Enabled = false;
                txtNumero.Visible = true;
                lbData.Visible = true;
                lbNumero.Visible = true;
                lbValor.Visible = true;
                txtCodigo.Enabled = false;
                txtNumero.Enabled = false;
                txtValor.Enabled = false;
                dtpDataCompra.Enabled = false;
                txtNumero.CausesValidation = false;
                txtValor.CausesValidation = false;
                dtpDataCompra.CausesValidation = false;
                lbConsulta.Visible = false;
                dtpInicial.Visible = false;
                dtpFinal.Visible = false;
                btConsultaCompra.Visible = false;
                btCancelar.Enabled = false;
                btEditar.Enabled = false;
                btSalvar.Enabled = false;
                btConsultaGeral.Enabled = true;
                errorProvider1.SetError(this.txtNumero, String.Empty);
                errorProvider1.SetError(this.dtpDataCompra, String.Empty);
                errorProvider1.SetError(this.txtValor, String.Empty);
                cargaGrid();
                cargaGridNota();
            }
            else { 
                if(tcCompra.SelectedIndex == 1){
                    
                    cargaComboItemCompra();
                    cbItemCompra.Text = "                ";
                    cbItemCompra.Enabled = false;                                   
                    cbDescricaoCompra.Text = "                ";
                    cbDescricaoCompra.Enabled = false;                              
                    cbTamanhoItem.Text = "                ";
                    cbTamanhoItem.Enabled = false;                                   
                    cbItemCompra.CausesValidation = false;
                    cbDescricaoCompra.CausesValidation = false;                       
                    cbTamanhoItem.CausesValidation = false;                           
                    txtQtdCompra.CausesValidation = false;
                    txtValorUnitario.CausesValidation = false;
                    errorProvider1.SetError(this.cbItemCompra, String.Empty);
                    errorProvider1.SetError(this.cbDescricaoCompra, String.Empty);
                    errorProvider1.SetError(this.cbTamanhoItem, String.Empty);
                    errorProvider1.SetError(this.txtQtdCompra, String.Empty);
                    errorProvider1.SetError(this.txtValorUnitario, String.Empty);
                    txtQtdCompra.Text = String.Empty;
                    txtQtdCompra.Enabled = false;
                    txtValorUnitario.Text = String.Empty;
                    txtValorUnitario.Enabled = false;
                    btEditar.Enabled = false;
                    cargaGridNota();
                                        
                }            
            }
            
        }



        public void limpaCampos() {
            txtCodigo.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtValor.Text = String.Empty;
        }

        public void cargaGrid() {
            br.model.clsCompra c = new br.model.clsCompra();
            try
            {
                dgCompra.DataSource = c.searchCompra();
                dgCompra.Columns["Valor compra"].DefaultCellStyle.Format = "C2";
                dgCompra.Columns["Código"].Visible = false;
                dgCompra.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inicial();
            }
            
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            inicial();
            cadastrar();

        }

        public void cadastrar() {
            btCancelar.Enabled = true;
            if(tcCompra.SelectedIndex == 0){
                lbCodigo.Visible = false;
                dtpDataCompra.Enabled = true;
                dtpDataCompra.Value = DateTime.Today;
                dtpInicial.Value = DateTime.Today;
                dtpFinal.Value = DateTime.Today;
                dtpDataCompra.MaxDate = DateTime.Today;
                txtCodigo.Visible = false;
                txtNumero.Enabled = true;
                dtpDataCompra.Enabled = true;
                txtValor.Enabled = true;
                btConsultaGeral.Enabled = false;
                txtNumero.CausesValidation = true;
                txtValor.CausesValidation = true;
                dtpDataCompra.CausesValidation = true;
                txtNumero.Focus();                           
            }else{
                if(tcCompra.SelectedIndex == 1){
                    if (String.IsNullOrEmpty(txtNumero.Text))
                    {
                        MessageBox.Show("Não existe uma nota fiscal a ser preenchida!\nSelecionar a nota fiscal para realizar o cadastro dos itens da compra!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tcCompra.SelectedIndex = 0;
                        inicial();
                    }
                    else {
                        cbItemCompra.Enabled = true;
                        cbItemCompra.Text = "                     E. P. I                 ";
                        cbDescricaoCompra.Enabled = true;
                        cbDescricaoCompra.Text = "                Descrição             ";
                        cbTamanhoItem.Enabled = true;
                        cbTamanhoItem.Text = " Tamanho";
                        txtQtdCompra.Enabled = true;
                        txtValorUnitario.Enabled = true;
                        cbItemCompra.CausesValidation = true;
                        cbDescricaoCompra.CausesValidation = true;
                        cbTamanhoItem.CausesValidation = true;
                        txtQtdCompra.CausesValidation = true;
                        txtValorUnitario.CausesValidation = true;
                        cbItemCompra.Select();
                    }                    
                }                
            }
         }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (tcCompra.SelectedIndex == 0)
            {
                inicial();
            }
            else {
               
                inicial();
            }
            
        }

        private void btConsultaGeral_Click(object sender, EventArgs e)
        {
            btCancelar.Enabled = true;
            btConsultaGeral.Enabled = false;
            if (tcCompra.SelectedIndex == 0)
            {
                dtpFinal.MaxDate = DateTime.Today;
                dtpInicial.MaxDate = DateTime.Today;
                limpaCampos();
                dtpInicial.Value = DateTime.Today;
                dtpFinal.Value = DateTime.Today;
                txtValor.CausesValidation = false;
                txtNumero.CausesValidation = false;
                dtpDataCompra.CausesValidation = false;
                lbCodigo.Visible = false;
                txtCodigo.Visible = false;
                txtNumero.Visible = false;
                txtValor.Visible = false;
                lbData.Visible = false;
                lbNumero.Visible = false;
                lbValor.Visible = false;
                dtpDataCompra.Visible = false;
                lbConsulta.Visible = true;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;
                btConsultaCompra.Visible = true;
                dtpInicial.CausesValidation = true;
                dtpFinal.CausesValidation = true;
                btCancelar.Enabled = true;
            }
            else {
                tcCompra.SelectedIndex = 0;
                dtpFinal.MaxDate = DateTime.Today;
                dtpInicial.MaxDate = DateTime.Today;
                limpaCampos();
                dtpInicial.Value = DateTime.Today;
                dtpFinal.Value = DateTime.Today;
                txtValor.CausesValidation = false;
                txtNumero.CausesValidation = false;
                dtpDataCompra.CausesValidation = false;
                lbCodigo.Visible = false;
                txtCodigo.Visible = false;
                txtNumero.Visible = false;
                txtValor.Visible = false;
                lbData.Visible = false;
                lbNumero.Visible = false;
                lbValor.Visible = false;
                dtpDataCompra.Visible = false;
                lbConsulta.Visible = true;
                dtpInicial.Visible = true;
                dtpFinal.Visible = true;
                btConsultaCompra.Visible = true;
                dtpInicial.CausesValidation = true;
                dtpFinal.CausesValidation = true;
                btCancelar.Enabled = true;
            }
        }

        private void btConsultaCompra_Click(object sender, EventArgs e)
        {            
           
            TimeSpan ts = dtpFinal.Value.Subtract(dtpInicial.Value);
            if (ts.Days <= 0)
            {
                MessageBox.Show("A data inicial deve ser inferior a data final.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpInicial.Value=DateTime.Today;
                dtpFinal.Value = DateTime.Today;
            }
            else {
                br.model.clsCompra c = new br.model.clsCompra();
                dgCompra.DataSource = c.searchCompra("data_compra between '" + dtpInicial.Value + "' and '" + dtpFinal.Value + "'");
                dgCompra.Columns["Código"].Visible = false;
            }
           
        }

        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text) || !br.model.clsCompra.validaNumber(txtNumero.Text))
            {
                errorProvider1.SetError(this.txtNumero, "Informe o número da nota fiscal.\nEle deve ser apenas número.");
                txtNumero.Text = String.Empty;
                btSalvar.Enabled = false;
                txtNumero.Focus();
            }
            else {
                errorProvider1.SetError(this.txtNumero, String.Empty);
                dtpDataCompra.Focus();
            }
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if (!br.model.clsCompra.validaMoney(txtValor.Text) || String.IsNullOrEmpty(txtValor.Text))
            {
                errorProvider1.SetError(this.txtValor, "Informe o valor da nota fiscal.\nEle deve ser apenas números em formato de moeda corrente,\nseparando apenas os centavos.");
                txtValor.Text = String.Empty;
                btSalvar.Enabled = false;
                txtValor.Focus();
            }
            else {
                Double valor;
                if(Double.TryParse(this.txtValor.Text, System.Globalization.NumberStyles.Currency, null, out valor)){
                    errorProvider1.SetError(this.txtValor, String.Empty);
                    btSalvar.Enabled = true;
                    btSalvar.Select();
                }               
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tcCompra.SelectedIndex == 0)
            {

                if (String.IsNullOrEmpty(txtCodigo.Text))
                {
                    br.model.clsCompra c = new br.model.clsCompra();
                    try
                    {
                        c.NotaFiscal = Convert.ToInt32(this.txtNumero.Text);
                        c.ValorNota = txtValor.Text.Replace(",", ".");
                        c.DataCompra = Convert.ToDateTime(this.dtpDataCompra.Value.ToShortDateString());
                        c.addCompra();
                        MessageBox.Show("Compra adicionada com sucesso.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inicial();
                    }
                }
                else
                {
                    br.model.clsCompra c = new br.model.clsCompra(txtCodigo.Text);
                    try
                    {
                        c.NotaFiscal = Convert.ToInt32(this.txtNumero.Text);
                        c.ValorNota = txtValor.Text.Replace(",", ".");
                        c.DataCompra = Convert.ToDateTime(this.dtpDataCompra.Value.ToShortDateString());
                        c.addCompra();
                        MessageBox.Show("Compra atualizada com sucesso.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        inicial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inicial();
                    }
                }
            }
            else { 
                if(tcCompra.SelectedIndex == 1){
                   
                    br.model.clsNotaFiscal nf = new br.model.clsNotaFiscal();
                    br.data.clsDataBaseConnection i = new br.data.clsDataBaseConnection();
                    DataTable dt = i.retornaDataTable("select cod_item from item where nome_item = '" + cbItemCompra.Text +
                        "' and tipo_item = '" + cbDescricaoCompra.Text + "' and tamanho_item = '" + cbTamanhoItem.Text + "'" );
                    String cod = dt.Rows[0]["cod_item"].ToString();

                   
                    try
                    {
                        nf.NotaFiscal = Convert.ToInt32(txtNumero.Text);
                        nf.CodItemFk = Convert.ToInt32(cod);
                        nf.TipoItem = cbDescricaoCompra.Text;
                        nf.TamanhoItem = cbTamanhoItem.Text;
                        nf.QuantidadeCompra = Convert.ToInt32(txtQtdCompra.Text);
                        nf.ValorUnitario = txtValorUnitario.Text.Replace(",", ".");
                        txtNumero.Enabled = false;
                        nf.addItemNota();
                        MessageBox.Show("Item adicionado!", "Kornus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargaGridNota();
                        inicial();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("O item informado já está cadastrado na nota atual!","Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inicial();
                        
                    }
                    
                }
            }
        }

        
        private void dtpDataCompra_Validating_1(object sender, CancelEventArgs e)
        {
           
            if (dtpDataCompra.Value > dtpDataCompra.MaxDate)
            {
                errorProvider1.SetError(this.dtpDataCompra, "A data da compra não pode ser superior a " + DateTime.Today + ".");
                dtpDataCompra.Select();
            }
            else {
                errorProvider1.SetError(this.dtpDataCompra, String.Empty);
                txtValor.Focus();
            }
        }

        private void dgCompra_DoubleClick(object sender, EventArgs e)
        {
            carregaObjeto();
        }

        public void carregaObjeto() {
            br.model.clsCompra c = new br.model.clsCompra();
            btConsultaGeral.Enabled = false;
            lbCodigo.Visible = true;
            txtCodigo.Visible = true;
            txtNumero.Enabled = false;
            txtValor.Enabled = false;
            dtpDataCompra.Enabled = false;
            txtNumero.CausesValidation = false;
            txtValor.CausesValidation = false;
            lbConsulta.Visible = false;
            dtpInicial.Visible = false;
            dtpFinal.Visible = false;
            dtpDataCompra.Visible = true;
            lbData.Visible = true;
            txtNumero.Visible = true;
            lbNumero.Visible = true;
            lbValor.Visible = true;
            txtValor.Visible = true;
            btConsultaCompra.Visible = false;
            errorProvider1.SetError(this.txtNumero, String.Empty);
            errorProvider1.SetError(this.txtValor, String.Empty);
            txtCodigo.Text = dgCompra.Rows[dgCompra.CurrentRow.Index].Cells[0].Value.ToString();
            dtpDataCompra.Value = Convert.ToDateTime(dgCompra.Rows[dgCompra.CurrentRow.Index].Cells[1].Value);
            txtNumero.Text = dgCompra.Rows[dgCompra.CurrentRow.Index].Cells[2].Value.ToString();
            txtValor.Text = dgCompra.Rows[dgCompra.CurrentRow.Index].Cells[3].Value.ToString();
            btEditar.Enabled = true;
            btCancelar.Enabled = true;
            cargaGrid();
            cargaGridNota();
                       
        }

        public void cargaGridNota(){
            br.model.clsNotaFiscal nf = new br.model.clsNotaFiscal();            
            
            dgNota.DataSource = nf.searchNota("nota_fiscal_fk = '" + txtNumero.Text + "'");
            dgNota.Columns["Valor item"].DefaultCellStyle.Format="C2";
            dgNota.Refresh();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(tcCompra.SelectedIndex == 0){
                br.data.clsDataBaseConnection  bd = new br.data.clsDataBaseConnection();
                DataTable dt = bd.retornaDataTable("Select * from notaFiscal where nota_fiscal_fk = '" + txtNumero.Text + "'");
                if(dt.Rows.Count > 0){
                    btEditar.Enabled = false;                
                    dtpDataCompra.Enabled = true;
                    txtValor.Enabled = true;
                    btSalvar.Enabled = true;
                }else{
                    btEditar.Enabled = false;
                    txtNumero.Enabled = true;
                    dtpDataCompra.Enabled = true;
                    txtValor.Enabled = true;
                    btSalvar.Enabled = true;
                }               
            }

        }

        private void tcCompra_Click(object sender, EventArgs e)
        {
            txtValor.Enabled = false;
            dtpDataCompra.Enabled = false;
        }

       
       
        public void cargaComboTamanho() {
            br.model.clsItem i = new br.model.clsItem();
            try
            {
                cbTamanhoItem.DataSource = i.retornaTamanhoCompra("tipo_item = '" + cbDescricaoCompra.Text + "'");
                cbTamanhoItem.DisplayMember = ("tamanho_item");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inicial();
            }
            
        }
        public void cargaComboDescricao() {
            br.model.clsItem i = new br.model.clsItem();
            try
            {
                cbDescricaoCompra.DataSource = i.retornaDescricaoCompra("nome_item = '"+ cbItemCompra.Text + "'");
                cbDescricaoCompra.DisplayMember=("tipo_item");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inicial();
            }
        }

       

        private void tcCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaGridNota();
            inicial();
            
        }

        private void cbItemCompra_Validating(object sender, CancelEventArgs e)
        {
            if (cbItemCompra.Text == "                     E. P. I                 ")
            {
                errorProvider1.SetError(this.cbItemCompra, "Selecione o E. P. I.");
                cbItemCompra.Focus();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(this.cbItemCompra, String.Empty);
                cargaComboDescricao();
                cbDescricaoCompra.Text = "                Descrição             ";
                cbDescricaoCompra.Focus();
            }
        }

        private void cbDescricaoCompra_Validating(object sender, CancelEventArgs e)
        {
            if (cbDescricaoCompra.Text == "                Descrição             ")
            {
                errorProvider1.SetError(this.cbDescricaoCompra, "Selecione a descrição do E. P. I.");
                cbDescricaoCompra.Select();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(this.cbDescricaoCompra, String.Empty);
                cargaComboTamanho();
                cbTamanhoItem.Text = " Tamanho";
                cbTamanhoItem.Focus();
            }
        }

        private void cbTamanhoItem_Validating(object sender, CancelEventArgs e)
        {
            if (cbTamanhoItem.Text == " Tamanho")
            {
                errorProvider1.SetError(this.cbTamanhoItem, "Selecione o temanho do E. P. I.");
                cbTamanhoItem.Select();
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(this.cbTamanhoItem, String.Empty);
                txtQtdCompra.Focus();

            }
        }

        private void txtQtdCompra_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtdCompra.Text) || !br.model.clsCompra.validaNumber(txtQtdCompra.Text))
            {
                errorProvider1.SetError(this.txtQtdCompra, "Informe a quantidade comprada.\nEla deve ser apenas números.");
                txtQtdCompra.Select();
                txtQtdCompra.Text = String.Empty;
                btSalvar.Enabled = false;
            }
            else {
                errorProvider1.SetError(this.txtQtdCompra, String.Empty);
                txtValorUnitario.Focus();
            }
        }

        private void txtValorUnitario_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtValorUnitario.Text) || ! br.model.clsCompra.validaMoney(txtValorUnitario.Text))
            {
                errorProvider1.SetError(this.txtValorUnitario, "Informe o valor do e. p. i.\nEle deve ser apenas números em formato de moeda corrente,\nseparando apenas os centavos.");
                txtValor.Text = String.Empty;
                btSalvar.Enabled = false;
                txtValor.Select();
            }
            else {
                Double valor;
                if(Double.TryParse(this.txtValorUnitario.Text, System.Globalization.NumberStyles.Currency, null, out valor)){
                    errorProvider1.SetError(this.txtValorUnitario, String.Empty);
                    btSalvar.Enabled = true;
                    btSalvar.Select();
                }
                
            }
        }

        private void tcCompra_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            inicial();
            cargaGridNota();
        }

        private void dgNota_DoubleClick(object sender, EventArgs e)
        {
            cbItemCompra.CausesValidation = false;
            cbDescricaoCompra.CausesValidation = false;
            cbTamanhoItem.CausesValidation = false;
            txtQtdCompra.CausesValidation = false;
            txtValorUnitario.CausesValidation = false;
            cbItemCompra.Enabled = false;
            cbDescricaoCompra.Enabled = false;
            cbTamanhoItem.Enabled = false;
            txtQtdCompra.Enabled = false;
            txtValorUnitario.Enabled = false;
            errorProvider1.SetError(this.cbItemCompra, String.Empty);
            errorProvider1.SetError(this.cbDescricaoCompra, String.Empty);
            errorProvider1.SetError(this.cbTamanhoItem, String.Empty);
            errorProvider1.SetError(this.txtQtdCompra, String.Empty);
            errorProvider1.SetError(this.txtValorUnitario, String.Empty);
            
            carregaNota();
            btDelete.Visible = true;
            
        }

        public void carregaNota() {

            cbItemCompra.Text = dgNota.Rows[dgNota.CurrentRow.Index].Cells[1].Value.ToString();
            cbDescricaoCompra.Text = dgNota.Rows[dgNota.CurrentRow.Index].Cells[2].Value.ToString();
            cbTamanhoItem.Text = dgNota.Rows[dgNota.CurrentRow.Index].Cells[3].Value.ToString();
            txtValorUnitario.Text=dgNota.Rows[dgNota.CurrentRow.Index].Cells[4].Value.ToString();
            txtQtdCompra.Text = dgNota.Rows[dgNota.CurrentRow.Index].Cells[5].Value.ToString();

            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            br.model.clsNotaFiscal nf = new br.model.clsNotaFiscal();
            br.data.clsDataBaseConnection i = new br.data.clsDataBaseConnection();

            DataTable dt = i.retornaDataTable("Select cod_item from Item where nome_item = '" + cbItemCompra.Text + 
                "' and tipo_item = '" + cbDescricaoCompra.Text + "' and tamanho_item = '" + cbTamanhoItem.Text + "'");
            int cod = Convert.ToInt32(dt.Rows[0]["cod_item"]);
            try
            {
                nf.CodItemFk = cod;
                nf.NotaFiscal = Convert.ToInt32(txtNumero.Text);
                if (MessageBox.Show("Tem certeza que deseja excluir o E. P. I selecionado da nota fiscal?", "Kronus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
                    nf.deleteNota();
                    inicial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                inicial();
            }   
        }

                 
       

             

        
    }
}
