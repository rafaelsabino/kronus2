namespace Kronus_v2.Gui
{
    partial class wfEntrega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEntrega));
            this.tcEntrega = new System.Windows.Forms.TabControl();
            this.tpEntrega = new System.Windows.Forms.TabPage();
            this.dgLogEntrega = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTamanho = new System.Windows.Forms.ComboBox();
            this.cbDescricao = new System.Windows.Forms.ComboBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.lbFunc = new System.Windows.Forms.Label();
            this.lbQtd = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbEpi = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tpEntregaVencida = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btConsultaEntregaVenc = new System.Windows.Forms.Button();
            this.txtConsultaVenc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgEntregaVenc = new System.Windows.Forms.DataGridView();
            this.tpConsultaEstoque = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgVisaoEstoque = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbConsultaFuncEnt = new System.Windows.Forms.Label();
            this.txtConsultaFuncEnt = new System.Windows.Forms.TextBox();
            this.btConsultaFuncEnt = new System.Windows.Forms.Button();
            this.tcEntrega.SuspendLayout();
            this.tpEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogEntrega)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tpEntregaVencida.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntregaVenc)).BeginInit();
            this.tpConsultaEstoque.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVisaoEstoque)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcEntrega
            // 
            this.tcEntrega.Controls.Add(this.tpEntrega);
            this.tcEntrega.Controls.Add(this.tpEntregaVencida);
            this.tcEntrega.Controls.Add(this.tpConsultaEstoque);
            this.tcEntrega.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEntrega.Location = new System.Drawing.Point(2, 65);
            this.tcEntrega.Name = "tcEntrega";
            this.tcEntrega.SelectedIndex = 0;
            this.tcEntrega.Size = new System.Drawing.Size(893, 405);
            this.tcEntrega.TabIndex = 0;
            this.tcEntrega.SelectedIndexChanged += new System.EventHandler(this.tcEntrega_SelectedIndexChanged);
            this.tcEntrega.Click += new System.EventHandler(this.tcEntrega_Click);
            // 
            // tpEntrega
            // 
            this.tpEntrega.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tpEntrega.Controls.Add(this.dgLogEntrega);
            this.tpEntrega.Controls.Add(this.groupBox1);
            this.tpEntrega.Location = new System.Drawing.Point(4, 34);
            this.tpEntrega.Name = "tpEntrega";
            this.tpEntrega.Padding = new System.Windows.Forms.Padding(3);
            this.tpEntrega.Size = new System.Drawing.Size(885, 367);
            this.tpEntrega.TabIndex = 0;
            this.tpEntrega.Text = "Entregar E. P. I";
            // 
            // dgLogEntrega
            // 
            this.dgLogEntrega.AllowUserToAddRows = false;
            this.dgLogEntrega.AllowUserToDeleteRows = false;
            this.dgLogEntrega.AllowUserToResizeRows = false;
            this.dgLogEntrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLogEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgLogEntrega.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgLogEntrega.Location = new System.Drawing.Point(14, 159);
            this.dgLogEntrega.MultiSelect = false;
            this.dgLogEntrega.Name = "dgLogEntrega";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLogEntrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgLogEntrega.RowHeadersVisible = false;
            this.dgLogEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLogEntrega.Size = new System.Drawing.Size(855, 201);
            this.dgLogEntrega.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConsultaFuncEnt);
            this.groupBox1.Controls.Add(this.txtConsultaFuncEnt);
            this.groupBox1.Controls.Add(this.lbConsultaFuncEnt);
            this.groupBox1.Controls.Add(this.cbTamanho);
            this.groupBox1.Controls.Add(this.cbDescricao);
            this.groupBox1.Controls.Add(this.cbItem);
            this.groupBox1.Controls.Add(this.cbFuncionario);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.lbDescricao);
            this.groupBox1.Controls.Add(this.lbTamanho);
            this.groupBox1.Controls.Add(this.lbFunc);
            this.groupBox1.Controls.Add(this.lbQtd);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.lbEpi);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Entrega";
            // 
            // cbTamanho
            // 
            this.cbTamanho.FormattingEnabled = true;
            this.cbTamanho.Location = new System.Drawing.Point(572, 88);
            this.cbTamanho.Name = "cbTamanho";
            this.cbTamanho.Size = new System.Drawing.Size(98, 25);
            this.cbTamanho.TabIndex = 13;
            this.cbTamanho.Validating += new System.ComponentModel.CancelEventHandler(this.cbTamanho_Validating);
            // 
            // cbDescricao
            // 
            this.cbDescricao.FormattingEnabled = true;
            this.cbDescricao.Location = new System.Drawing.Point(316, 88);
            this.cbDescricao.Name = "cbDescricao";
            this.cbDescricao.Size = new System.Drawing.Size(163, 25);
            this.cbDescricao.TabIndex = 12;
            this.cbDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.cbDescricao_Validating);
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(87, 88);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(134, 25);
            this.cbItem.TabIndex = 11;
            this.cbItem.Validating += new System.ComponentModel.CancelEventHandler(this.cbItem_Validating);
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(488, 40);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(249, 25);
            this.cbFuncionario.TabIndex = 10;
            this.cbFuncionario.Validating += new System.ComponentModel.CancelEventHandler(this.cbFuncionario_Validating);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(265, 40);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(89, 25);
            this.txtData.TabIndex = 9;
            this.txtData.Validating += new System.ComponentModel.CancelEventHandler(this.txtData_Validating);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(777, 88);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(51, 25);
            this.txtQuantidade.TabIndex = 8;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(237, 91);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(75, 17);
            this.lbDescricao.TabIndex = 7;
            this.lbDescricao.Text = "Descrição :";
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamanho.Location = new System.Drawing.Point(492, 91);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(74, 17);
            this.lbTamanho.TabIndex = 6;
            this.lbTamanho.Text = "Tamanho :";
            // 
            // lbFunc
            // 
            this.lbFunc.AutoSize = true;
            this.lbFunc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFunc.Location = new System.Drawing.Point(390, 43);
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.Size = new System.Drawing.Size(89, 17);
            this.lbFunc.TabIndex = 5;
            this.lbFunc.Text = "Funcionário :";
            // 
            // lbQtd
            // 
            this.lbQtd.AutoSize = true;
            this.lbQtd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtd.Location = new System.Drawing.Point(683, 91);
            this.lbQtd.Name = "lbQtd";
            this.lbQtd.Size = new System.Drawing.Size(88, 17);
            this.lbQtd.TabIndex = 4;
            this.lbQtd.Text = "Quantidade :";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(212, 43);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(45, 17);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "Data :";
            // 
            // lbEpi
            // 
            this.lbEpi.AutoSize = true;
            this.lbEpi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpi.Location = new System.Drawing.Point(30, 91);
            this.lbEpi.Name = "lbEpi";
            this.lbEpi.Size = new System.Drawing.Size(51, 17);
            this.lbEpi.TabIndex = 2;
            this.lbEpi.Text = "E. P. I :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 25);
            this.txtCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(33, 43);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(60, 17);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código :";
            // 
            // tpEntregaVencida
            // 
            this.tpEntregaVencida.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tpEntregaVencida.Controls.Add(this.groupBox2);
            this.tpEntregaVencida.Controls.Add(this.dgEntregaVenc);
            this.tpEntregaVencida.Location = new System.Drawing.Point(4, 34);
            this.tpEntregaVencida.Name = "tpEntregaVencida";
            this.tpEntregaVencida.Padding = new System.Windows.Forms.Padding(3);
            this.tpEntregaVencida.Size = new System.Drawing.Size(885, 367);
            this.tpEntregaVencida.TabIndex = 1;
            this.tpEntregaVencida.Text = "Entregas vencidas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btConsultaEntregaVenc);
            this.groupBox2.Controls.Add(this.txtConsultaVenc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar funcionário";
            // 
            // btConsultaEntregaVenc
            // 
            this.btConsultaEntregaVenc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaEntregaVenc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultaEntregaVenc.BackgroundImage")));
            this.btConsultaEntregaVenc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultaEntregaVenc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaEntregaVenc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaEntregaVenc.Location = new System.Drawing.Point(606, 41);
            this.btConsultaEntregaVenc.Name = "btConsultaEntregaVenc";
            this.btConsultaEntregaVenc.Size = new System.Drawing.Size(90, 30);
            this.btConsultaEntregaVenc.TabIndex = 2;
            this.btConsultaEntregaVenc.UseVisualStyleBackColor = false;
            // 
            // txtConsultaVenc
            // 
            this.txtConsultaVenc.Location = new System.Drawing.Point(232, 45);
            this.txtConsultaVenc.Name = "txtConsultaVenc";
            this.txtConsultaVenc.Size = new System.Drawing.Size(350, 25);
            this.txtConsultaVenc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Consultar :";
            // 
            // dgEntregaVenc
            // 
            this.dgEntregaVenc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEntregaVenc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntregaVenc.Location = new System.Drawing.Point(13, 122);
            this.dgEntregaVenc.MultiSelect = false;
            this.dgEntregaVenc.Name = "dgEntregaVenc";
            this.dgEntregaVenc.RowHeadersVisible = false;
            this.dgEntregaVenc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntregaVenc.Size = new System.Drawing.Size(857, 231);
            this.dgEntregaVenc.TabIndex = 0;
            // 
            // tpConsultaEstoque
            // 
            this.tpConsultaEstoque.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tpConsultaEstoque.Controls.Add(this.groupBox3);
            this.tpConsultaEstoque.Location = new System.Drawing.Point(4, 34);
            this.tpConsultaEstoque.Name = "tpConsultaEstoque";
            this.tpConsultaEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultaEstoque.Size = new System.Drawing.Size(885, 367);
            this.tpConsultaEstoque.TabIndex = 2;
            this.tpConsultaEstoque.Text = "Consultar estoque";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.dgVisaoEstoque);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 341);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visão geral do estoque";
            // 
            // dgVisaoEstoque
            // 
            this.dgVisaoEstoque.AllowUserToAddRows = false;
            this.dgVisaoEstoque.AllowUserToDeleteRows = false;
            this.dgVisaoEstoque.AllowUserToResizeRows = false;
            this.dgVisaoEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVisaoEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVisaoEstoque.ColumnHeadersVisible = false;
            this.dgVisaoEstoque.Location = new System.Drawing.Point(6, 34);
            this.dgVisaoEstoque.MultiSelect = false;
            this.dgVisaoEstoque.Name = "dgVisaoEstoque";
            this.dgVisaoEstoque.RowHeadersVisible = false;
            this.dgVisaoEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVisaoEstoque.Size = new System.Drawing.Size(861, 301);
            this.dgVisaoEstoque.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btDeletar);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btConsultar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 30);
            this.panel1.TabIndex = 1;
            // 
            // btDeletar
            // 
            this.btDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeletar.BackgroundImage")));
            this.btDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeletar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Location = new System.Drawing.Point(240, 3);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(56, 25);
            this.btDeletar.TabIndex = 6;
            this.btDeletar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelar.BackgroundImage")));
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(180, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(56, 25);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultar.BackgroundImage")));
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Location = new System.Drawing.Point(120, 3);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(56, 25);
            this.btConsultar.TabIndex = 4;
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(60, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 25);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNovo.BackgroundImage")));
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Location = new System.Drawing.Point(0, 3);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(56, 25);
            this.btNovo.TabIndex = 2;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(776, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 30);
            this.panel2.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lbConsultaFuncEnt
            // 
            this.lbConsultaFuncEnt.AutoSize = true;
            this.lbConsultaFuncEnt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsultaFuncEnt.Location = new System.Drawing.Point(157, 68);
            this.lbConsultaFuncEnt.Name = "lbConsultaFuncEnt";
            this.lbConsultaFuncEnt.Size = new System.Drawing.Size(75, 17);
            this.lbConsultaFuncEnt.TabIndex = 14;
            this.lbConsultaFuncEnt.Text = "Consultar :";
            // 
            // txtConsultaFuncEnt
            // 
            this.txtConsultaFuncEnt.Location = new System.Drawing.Point(246, 65);
            this.txtConsultaFuncEnt.Name = "txtConsultaFuncEnt";
            this.txtConsultaFuncEnt.Size = new System.Drawing.Size(330, 25);
            this.txtConsultaFuncEnt.TabIndex = 15;
            // 
            // btConsultaFuncEnt
            // 
            this.btConsultaFuncEnt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaFuncEnt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultaFuncEnt.BackgroundImage")));
            this.btConsultaFuncEnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultaFuncEnt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaFuncEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaFuncEnt.Location = new System.Drawing.Point(615, 61);
            this.btConsultaFuncEnt.Name = "btConsultaFuncEnt";
            this.btConsultaFuncEnt.Size = new System.Drawing.Size(90, 30);
            this.btConsultaFuncEnt.TabIndex = 16;
            this.btConsultaFuncEnt.UseVisualStyleBackColor = false;
            // 
            // wfEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tcEntrega);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega";
            this.Load += new System.EventHandler(this.wfEntrega_Load);
            this.tcEntrega.ResumeLayout(false);
            this.tpEntrega.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogEntrega)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpEntregaVencida.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntregaVenc)).EndInit();
            this.tpConsultaEstoque.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVisaoEstoque)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcEntrega;
        private System.Windows.Forms.TabPage tpEntrega;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tpEntregaVencida;
        private System.Windows.Forms.TabPage tpConsultaEstoque;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgLogEntrega;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.Label lbFunc;
        private System.Windows.Forms.Label lbQtd;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbEpi;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.ComboBox cbDescricao;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.ComboBox cbTamanho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btConsultaEntregaVenc;
        private System.Windows.Forms.TextBox txtConsultaVenc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgEntregaVenc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgVisaoEstoque;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btConsultaFuncEnt;
        private System.Windows.Forms.TextBox txtConsultaFuncEnt;
        private System.Windows.Forms.Label lbConsultaFuncEnt;
    }
}