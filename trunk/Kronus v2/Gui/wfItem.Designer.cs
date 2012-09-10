namespace Kronus_v2
{
    partial class wfItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.txtEstoqueMin = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.txtCa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.cbFornecedor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTamanho);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.txtConsultar);
            this.groupBox1.Controls.Add(this.txtEstoqueMin);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtNomeItem);
            this.groupBox1.Controls.Add(this.txtCa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.lbCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Item";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(124, 74);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(265, 25);
            this.cbFornecedor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbFornecedor, "Nome do fornecedor do e. p. i.");
            this.cbFornecedor.Validating += new System.ComponentModel.CancelEventHandler(this.cbFornecedor_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fornecedor :";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTamanho.Location = new System.Drawing.Point(510, 121);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(141, 25);
            this.txtTamanho.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtTamanho, "Tamanho do e. p. i.");
            this.txtTamanho.Validating += new System.ComponentModel.CancelEventHandler(this.txtTamanho_Validating);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tamanho :";
            // 
            // btConsultar
            // 
            this.btConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultar.BackgroundImage")));
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Location = new System.Drawing.Point(536, 213);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(90, 30);
            this.btConsultar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btConsultar, "Consultar e. p .i");
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtConsultar
            // 
            this.txtConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsultar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultar.Location = new System.Drawing.Point(124, 216);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(381, 25);
            this.txtConsultar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtConsultar, "Informe o nome do e. p. i.");
            // 
            // txtEstoqueMin
            // 
            this.txtEstoqueMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstoqueMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstoqueMin.Location = new System.Drawing.Point(517, 170);
            this.txtEstoqueMin.Name = "txtEstoqueMin";
            this.txtEstoqueMin.Size = new System.Drawing.Size(100, 25);
            this.txtEstoqueMin.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtEstoqueMin, "Mínimo em estoque para avisar a \r\nnecessidade de compra.");
            this.txtEstoqueMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstoqueMin_Validating);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(124, 170);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(216, 25);
            this.txtDescricao.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDescricao, "Descrição do e. p. i.");
            this.txtDescricao.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescricao_Validating);
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeItem.Location = new System.Drawing.Point(124, 121);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(265, 25);
            this.txtNomeItem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtNomeItem, "Nome do e. p. i.");
            this.txtNomeItem.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomeItem_Validating);
            // 
            // txtCa
            // 
            this.txtCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCa.Location = new System.Drawing.Point(542, 33);
            this.txtCa.Name = "txtCa";
            this.txtCa.Size = new System.Drawing.Size(109, 25);
            this.txtCa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCa, "Certificado de provação do e. p. i.");
            this.txtCa.Validating += new System.ComponentModel.CancelEventHandler(this.txtCa_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Consultar :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mínimo em Estoque :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descrição :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Item :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Certificado Aprovação :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(124, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 21);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 240);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(33, 36);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(60, 17);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código :";
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDeletar.BackgroundImage")));
            this.btDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDeletar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Location = new System.Drawing.Point(111, 3);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(56, 25);
            this.btDeletar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btDeletar, "Cancelar / Excluir registro do e. p. i.");
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(57, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 25);
            this.btSalvar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar registro.");
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNovo.BackgroundImage")));
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Location = new System.Drawing.Point(3, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(56, 25);
            this.btNovo.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btNovo, "Novo registro de e. p. i");
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.AllowUserToDeleteRows = false;
            this.dgItem.AllowUserToResizeRows = false;
            this.dgItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgItem.Location = new System.Drawing.Point(15, 331);
            this.dgItem.MultiSelect = false;
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItem.Size = new System.Drawing.Size(697, 206);
            this.dgItem.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dgItem, "E. p. is registrados.");
            this.dgItem.DoubleClick += new System.EventHandler(this.dgItem_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btDeletar);
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 30);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(604, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 30);
            this.panel2.TabIndex = 14;
            // 
            // wfItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgItem);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de E. P. I.";
            this.Load += new System.EventHandler(this.wfItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.TextBox txtEstoqueMin;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.TextBox txtCa;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}