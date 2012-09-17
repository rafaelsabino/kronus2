namespace Kronus_v2.Gui
{
    partial class wfCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btConsultaGeral = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.tcCompra = new System.Windows.Forms.TabControl();
            this.nota = new System.Windows.Forms.TabPage();
            this.dgCompra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultaCompra = new System.Windows.Forms.Button();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.lbConsulta = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgNota = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtQtdCompra = new System.Windows.Forms.TextBox();
            this.lbQtdCompra = new System.Windows.Forms.Label();
            this.cbTamanhoItem = new System.Windows.Forms.ComboBox();
            this.cbDescricaoCompra = new System.Windows.Forms.ComboBox();
            this.cbItemCompra = new System.Windows.Forms.ComboBox();
            this.lbValorUnitario = new System.Windows.Forms.Label();
            this.lbTamanho = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbItem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tcCompra.SuspendLayout();
            this.nota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNota)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btConsultaGeral);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btEditar);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 30);
            this.panel1.TabIndex = 1;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDelete.BackgroundImage")));
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Location = new System.Drawing.Point(295, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(56, 25);
            this.btDelete.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btDelete, "Excluir dados do registro da nota fiscal.");
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelar.BackgroundImage")));
            this.btCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(235, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(56, 25);
            this.btCancelar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btCancelar, "Cancelar Registro.");
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btConsultaGeral
            // 
            this.btConsultaGeral.BackColor = System.Drawing.Color.Transparent;
            this.btConsultaGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultaGeral.BackgroundImage")));
            this.btConsultaGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultaGeral.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaGeral.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaGeral.Location = new System.Drawing.Point(176, 2);
            this.btConsultaGeral.Name = "btConsultaGeral";
            this.btConsultaGeral.Size = new System.Drawing.Size(56, 25);
            this.btConsultaGeral.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btConsultaGeral, "Consultar registro de nota fiscal.");
            this.btConsultaGeral.UseVisualStyleBackColor = false;
            this.btConsultaGeral.Click += new System.EventHandler(this.btConsultaGeral_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(116, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 25);
            this.btSalvar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar dados do registro.");
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditar.BackgroundImage")));
            this.btEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEditar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Location = new System.Drawing.Point(58, 2);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(56, 25);
            this.btEditar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btEditar, "Editar registro de nota fiscal.");
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Transparent;
            this.btNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNovo.BackgroundImage")));
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Location = new System.Drawing.Point(0, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(56, 25);
            this.btNovo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btNovo, "Novo registro de nota fiscal.");
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // tcCompra
            // 
            this.tcCompra.Controls.Add(this.nota);
            this.tcCompra.Controls.Add(this.tabPage2);
            this.tcCompra.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcCompra.Location = new System.Drawing.Point(3, 63);
            this.tcCompra.Name = "tcCompra";
            this.tcCompra.SelectedIndex = 0;
            this.tcCompra.Size = new System.Drawing.Size(893, 405);
            this.tcCompra.TabIndex = 10;
            this.tcCompra.SelectedIndexChanged += new System.EventHandler(this.tcCompra_SelectedIndexChanged_1);
            this.tcCompra.Click += new System.EventHandler(this.tcCompra_Click);
            // 
            // nota
            // 
            this.nota.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nota.Controls.Add(this.dgCompra);
            this.nota.Controls.Add(this.groupBox1);
            this.nota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota.Location = new System.Drawing.Point(4, 34);
            this.nota.Name = "nota";
            this.nota.Padding = new System.Windows.Forms.Padding(3);
            this.nota.Size = new System.Drawing.Size(885, 367);
            this.nota.TabIndex = 0;
            this.nota.Text = "Nota";
            // 
            // dgCompra
            // 
            this.dgCompra.AllowUserToAddRows = false;
            this.dgCompra.AllowUserToDeleteRows = false;
            this.dgCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCompra.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgCompra.Location = new System.Drawing.Point(14, 159);
            this.dgCompra.MultiSelect = false;
            this.dgCompra.Name = "dgCompra";
            this.dgCompra.ReadOnly = true;
            this.dgCompra.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCompra.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCompra.Size = new System.Drawing.Size(855, 201);
            this.dgCompra.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dgCompra, "Notas fiscais registradas.");
            this.dgCompra.DoubleClick += new System.EventHandler(this.dgCompra_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btConsultaCompra);
            this.groupBox1.Controls.Add(this.dtpInicial);
            this.groupBox1.Controls.Add(this.lbConsulta);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Controls.Add(this.dtpDataCompra);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lbValor);
            this.groupBox1.Controls.Add(this.lbNumero);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Nota";
            // 
            // btConsultaCompra
            // 
            this.btConsultaCompra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultaCompra.BackgroundImage")));
            this.btConsultaCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultaCompra.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaCompra.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultaCompra.Image = ((System.Drawing.Image)(resources.GetObject("btConsultaCompra.Image")));
            this.btConsultaCompra.Location = new System.Drawing.Point(611, 59);
            this.btConsultaCompra.Name = "btConsultaCompra";
            this.btConsultaCompra.Size = new System.Drawing.Size(90, 30);
            this.btConsultaCompra.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btConsultaCompra, "Consultar notas fiscais.");
            this.btConsultaCompra.UseVisualStyleBackColor = false;
            this.btConsultaCompra.Click += new System.EventHandler(this.btConsultaCompra_Click);
            // 
            // dtpInicial
            // 
            this.dtpInicial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(210, 61);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(133, 25);
            this.dtpInicial.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dtpInicial, "Data inicial");
            this.dtpInicial.Value = new System.DateTime(2012, 8, 22, 0, 0, 0, 0);
            // 
            // lbConsulta
            // 
            this.lbConsulta.AutoSize = true;
            this.lbConsulta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConsulta.Location = new System.Drawing.Point(129, 67);
            this.lbConsulta.Name = "lbConsulta";
            this.lbConsulta.Size = new System.Drawing.Size(70, 17);
            this.lbConsulta.TabIndex = 11;
            this.lbConsulta.Text = "Consulta :";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(436, 61);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(133, 25);
            this.dtpFinal.TabIndex = 10;
            this.toolTip1.SetToolTip(this.dtpFinal, "Data final.");
            this.dtpFinal.Value = new System.DateTime(2012, 8, 22, 0, 0, 0, 0);
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(472, 37);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(133, 25);
            this.dtpDataCompra.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtpDataCompra, "Data da compra.");
            this.dtpDataCompra.Value = new System.DateTime(2012, 8, 22, 0, 0, 0, 0);
            this.dtpDataCompra.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataCompra_Validating_1);
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(698, 37);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 25);
            this.txtValor.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtValor, "Valor total da nota fiscal.");
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(291, 37);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 25);
            this.txtNumero.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtNumero, "Número da nota fiscal.");
            this.txtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumero_Validating);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValor.Location = new System.Drawing.Point(632, 40);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(68, 17);
            this.lbValor.TabIndex = 4;
            this.lbValor.Text = "Valor R$ :";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(220, 40);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(66, 17);
            this.lbNumero.TabIndex = 3;
            this.lbNumero.Text = "Número :";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(414, 40);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(45, 17);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(99, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TabIndex = 5;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(33, 40);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(60, 17);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código :";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.dgNota);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            // 
            // dgNota
            // 
            this.dgNota.AllowUserToAddRows = false;
            this.dgNota.AllowUserToDeleteRows = false;
            this.dgNota.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNota.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgNota.Location = new System.Drawing.Point(14, 155);
            this.dgNota.MultiSelect = false;
            this.dgNota.Name = "dgNota";
            this.dgNota.ReadOnly = true;
            this.dgNota.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNota.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNota.Size = new System.Drawing.Size(855, 203);
            this.dgNota.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dgNota, "E. P. Is componentes da nota fiscal. ");
            this.dgNota.DoubleClick += new System.EventHandler(this.dgNota_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.txtValorUnitario);
            this.groupBox2.Controls.Add(this.txtQtdCompra);
            this.groupBox2.Controls.Add(this.lbQtdCompra);
            this.groupBox2.Controls.Add(this.cbTamanhoItem);
            this.groupBox2.Controls.Add(this.cbDescricaoCompra);
            this.groupBox2.Controls.Add(this.cbItemCompra);
            this.groupBox2.Controls.Add(this.lbValorUnitario);
            this.groupBox2.Controls.Add(this.lbTamanho);
            this.groupBox2.Controls.Add(this.lbDescricao);
            this.groupBox2.Controls.Add(this.lbItem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 127);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Item";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitario.Location = new System.Drawing.Point(641, 82);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(140, 23);
            this.txtValorUnitario.TabIndex = 10;
            this.txtValorUnitario.Validating += new System.ComponentModel.CancelEventHandler(this.txtValorUnitario_Validating);
            // 
            // txtQtdCompra
            // 
            this.txtQtdCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdCompra.Location = new System.Drawing.Point(232, 82);
            this.txtQtdCompra.Name = "txtQtdCompra";
            this.txtQtdCompra.Size = new System.Drawing.Size(170, 23);
            this.txtQtdCompra.TabIndex = 9;
            this.txtQtdCompra.Validating += new System.ComponentModel.CancelEventHandler(this.txtQtdCompra_Validating);
            // 
            // lbQtdCompra
            // 
            this.lbQtdCompra.AutoSize = true;
            this.lbQtdCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdCompra.Location = new System.Drawing.Point(67, 85);
            this.lbQtdCompra.Name = "lbQtdCompra";
            this.lbQtdCompra.Size = new System.Drawing.Size(155, 17);
            this.lbQtdCompra.TabIndex = 8;
            this.lbQtdCompra.Text = "Quantidade Comprada :";
            // 
            // cbTamanhoItem
            // 
            this.cbTamanhoItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTamanhoItem.FormattingEnabled = true;
            this.cbTamanhoItem.Location = new System.Drawing.Point(700, 34);
            this.cbTamanhoItem.Name = "cbTamanhoItem";
            this.cbTamanhoItem.Size = new System.Drawing.Size(81, 23);
            this.cbTamanhoItem.TabIndex = 7;
            this.cbTamanhoItem.Validating += new System.ComponentModel.CancelEventHandler(this.cbTamanhoItem_Validating);
            // 
            // cbDescricaoCompra
            // 
            this.cbDescricaoCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescricaoCompra.FormattingEnabled = true;
            this.cbDescricaoCompra.Location = new System.Drawing.Point(397, 34);
            this.cbDescricaoCompra.Name = "cbDescricaoCompra";
            this.cbDescricaoCompra.Size = new System.Drawing.Size(192, 23);
            this.cbDescricaoCompra.TabIndex = 6;
            this.cbDescricaoCompra.Validating += new System.ComponentModel.CancelEventHandler(this.cbDescricaoCompra_Validating);
            // 
            // cbItemCompra
            // 
            this.cbItemCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItemCompra.FormattingEnabled = true;
            this.cbItemCompra.Location = new System.Drawing.Point(123, 32);
            this.cbItemCompra.Name = "cbItemCompra";
            this.cbItemCompra.Size = new System.Drawing.Size(175, 23);
            this.cbItemCompra.TabIndex = 5;
            this.cbItemCompra.Validating += new System.ComponentModel.CancelEventHandler(this.cbItemCompra_Validating);
            // 
            // lbValorUnitario
            // 
            this.lbValorUnitario.AutoSize = true;
            this.lbValorUnitario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorUnitario.Location = new System.Drawing.Point(514, 85);
            this.lbValorUnitario.Name = "lbValorUnitario";
            this.lbValorUnitario.Size = new System.Drawing.Size(122, 17);
            this.lbValorUnitario.TabIndex = 4;
            this.lbValorUnitario.Text = "Valor Unitário R$ :";
            // 
            // lbTamanho
            // 
            this.lbTamanho.AutoSize = true;
            this.lbTamanho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamanho.Location = new System.Drawing.Point(609, 38);
            this.lbTamanho.Name = "lbTamanho";
            this.lbTamanho.Size = new System.Drawing.Size(74, 17);
            this.lbTamanho.TabIndex = 3;
            this.lbTamanho.Text = "Tamanho :";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(316, 35);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(75, 17);
            this.lbDescricao.TabIndex = 2;
            this.lbDescricao.Text = "Descrição :";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(67, 35);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(44, 17);
            this.lbItem.TabIndex = 0;
            this.lbItem.Text = "Item :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(774, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 30);
            this.panel2.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // wfCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(899, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tcCompra);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.wfCompra_Load);
            this.panel1.ResumeLayout(false);
            this.tcCompra.ResumeLayout(false);
            this.nota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNota)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConsultaGeral;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TabControl tcCompra;
        private System.Windows.Forms.TabPage nota;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.DataGridView dgNota;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbItemCompra;
        private System.Windows.Forms.Label lbValorUnitario;
        private System.Windows.Forms.Label lbTamanho;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtQtdCompra;
        private System.Windows.Forms.Label lbQtdCompra;
        private System.Windows.Forms.ComboBox cbTamanhoItem;
        private System.Windows.Forms.ComboBox cbDescricaoCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbConsulta;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btConsultaCompra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}