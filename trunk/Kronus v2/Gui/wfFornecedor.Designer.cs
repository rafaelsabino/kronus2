namespace Kronus_v2
{
    partial class wfFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtemailFornec = new System.Windows.Forms.TextBox();
            this.mtTelFornec = new System.Windows.Forms.MaskedTextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtConsultaFornec = new System.Windows.Forms.TextBox();
            this.txtNomeFornec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodfornec = new System.Windows.Forms.TextBox();
            this.lbCodfornec = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgFornec = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnFornecedor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.txtemailFornec);
            this.groupBox1.Controls.Add(this.mtTelFornec);
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.txtConsultaFornec);
            this.groupBox1.Controls.Add(this.txtNomeFornec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodfornec);
            this.groupBox1.Controls.Add(this.lbCodfornec);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Fornecedores";
            // 
            // txtemailFornec
            // 
            this.txtemailFornec.Location = new System.Drawing.Point(349, 127);
            this.txtemailFornec.Name = "txtemailFornec";
            this.txtemailFornec.Size = new System.Drawing.Size(260, 25);
            this.txtemailFornec.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtemailFornec, "Email do fornecedor.");
            this.txtemailFornec.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailFornec_Validating);
            // 
            // mtTelFornec
            // 
            this.mtTelFornec.Location = new System.Drawing.Point(131, 127);
            this.mtTelFornec.Mask = "(99) 9999-9999 ";
            this.mtTelFornec.Name = "mtTelFornec";
            this.mtTelFornec.Size = new System.Drawing.Size(118, 25);
            this.mtTelFornec.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mtTelFornec, "Telefone do fornecedor.");
            this.mtTelFornec.Validating += new System.ComponentModel.CancelEventHandler(this.mtTelFornec_Validating);
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultar.BackgroundImage")));
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btConsultar.Image")));
            this.btConsultar.Location = new System.Drawing.Point(519, 175);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(90, 30);
            this.btConsultar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btConsultar, "Consultar fornecedor.");
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtConsultaFornec
            // 
            this.txtConsultaFornec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultaFornec.Location = new System.Drawing.Point(131, 177);
            this.txtConsultaFornec.Name = "txtConsultaFornec";
            this.txtConsultaFornec.Size = new System.Drawing.Size(358, 25);
            this.txtConsultaFornec.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtConsultaFornec, "Informe o nome do fornecedor.");
            // 
            // txtNomeFornec
            // 
            this.txtNomeFornec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFornec.Location = new System.Drawing.Point(131, 81);
            this.txtNomeFornec.Name = "txtNomeFornec";
            this.txtNomeFornec.Size = new System.Drawing.Size(358, 25);
            this.txtNomeFornec.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNomeFornec, "Nome do fornecedor.");
            this.txtNomeFornec.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomeFornec_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Consultar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome :";
            // 
            // txtCodfornec
            // 
            this.txtCodfornec.Location = new System.Drawing.Point(131, 34);
            this.txtCodfornec.Name = "txtCodfornec";
            this.txtCodfornec.Size = new System.Drawing.Size(118, 25);
            this.txtCodfornec.TabIndex = 1;
            // 
            // lbCodfornec
            // 
            this.lbCodfornec.AutoSize = true;
            this.lbCodfornec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodfornec.Location = new System.Drawing.Point(41, 37);
            this.lbCodfornec.Name = "lbCodfornec";
            this.lbCodfornec.Size = new System.Drawing.Size(60, 17);
            this.lbCodfornec.TabIndex = 0;
            this.lbCodfornec.Text = "Código :";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluir.BackgroundImage")));
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(119, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(56, 25);
            this.btExcluir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btExcluir, "Cancelar / Excuir registro de fornecedor.");
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(60, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 25);
            this.btSalvar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar registro.");
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.Transparent;
            this.btNovo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btNovo.BackgroundImage")));
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNovo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Location = new System.Drawing.Point(1, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(56, 25);
            this.btNovo.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btNovo, "Novo registro de fornecedor.");
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dgFornec
            // 
            this.dgFornec.AllowUserToAddRows = false;
            this.dgFornec.AllowUserToDeleteRows = false;
            this.dgFornec.AllowUserToResizeRows = false;
            this.dgFornec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFornec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFornec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgFornec.Location = new System.Drawing.Point(12, 297);
            this.dgFornec.MultiSelect = false;
            this.dgFornec.Name = "dgFornec";
            this.dgFornec.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFornec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgFornec.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgFornec.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgFornec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFornec.Size = new System.Drawing.Size(676, 195);
            this.dgFornec.TabIndex = 10;
            this.toolTip1.SetToolTip(this.dgFornec, "Fornecedores registrados");
            this.dgFornec.DoubleClick += new System.EventHandler(this.dgFornec_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // pnFornecedor
            // 
            this.pnFornecedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnFornecedor.BackgroundImage")));
            this.pnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnFornecedor.Controls.Add(this.btNovo);
            this.pnFornecedor.Controls.Add(this.btExcluir);
            this.pnFornecedor.Controls.Add(this.btSalvar);
            this.pnFornecedor.Location = new System.Drawing.Point(-1, 1);
            this.pnFornecedor.Name = "pnFornecedor";
            this.pnFornecedor.Size = new System.Drawing.Size(701, 30);
            this.pnFornecedor.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(577, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 30);
            this.panel2.TabIndex = 12;
            // 
            // wfFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnFornecedor);
            this.Controls.Add(this.dgFornec);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.wfFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFornec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnFornecedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCodfornec;
        private System.Windows.Forms.TextBox txtConsultaFornec;
        private System.Windows.Forms.TextBox txtNomeFornec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodfornec;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView dgFornec;
        private System.Windows.Forms.MaskedTextBox mtTelFornec;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnFornecedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtemailFornec;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}