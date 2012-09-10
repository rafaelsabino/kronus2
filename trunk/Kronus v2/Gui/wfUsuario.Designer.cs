namespace Kronus_v2.Gui
{
    partial class wfUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbAcesso = new System.Windows.Forms.CheckBox();
            this.txtConfirma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodUsuario = new System.Windows.Forms.Label();
            this.dgUsuário = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuário)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btExcluir);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(525, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 30);
            this.panel2.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btExcluir.BackgroundImage")));
            this.btExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btExcluir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Location = new System.Drawing.Point(106, 2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(56, 25);
            this.btExcluir.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btExcluir, "Cancelar / Excluir registro de usuário.");
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSalvar.BackgroundImage")));
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Location = new System.Drawing.Point(52, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(56, 25);
            this.btSalvar.TabIndex = 2;
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
            this.btNovo.Location = new System.Drawing.Point(-1, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(56, 25);
            this.btNovo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btNovo, "Novo registro de usuário.");
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConsultar);
            this.groupBox1.Controls.Add(this.txtConsulta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chbAcesso);
            this.groupBox1.Controls.Add(this.txtConfirma);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lbCodUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Usuário";
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConsultar.BackgroundImage")));
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Location = new System.Drawing.Point(504, 190);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(90, 30);
            this.btConsultar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btConsultar, "Consultar usuário.");
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsulta.Location = new System.Drawing.Point(130, 194);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(357, 25);
            this.txtConsulta.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtConsulta, "Informe o nome do usuário.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Consultar :";
            // 
            // chbAcesso
            // 
            this.chbAcesso.AutoSize = true;
            this.chbAcesso.Checked = true;
            this.chbAcesso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAcesso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAcesso.Location = new System.Drawing.Point(43, 156);
            this.chbAcesso.Name = "chbAcesso";
            this.chbAcesso.Size = new System.Drawing.Size(120, 21);
            this.chbAcesso.TabIndex = 9;
            this.chbAcesso.Text = "Administrador.";
            this.toolTip1.SetToolTip(this.chbAcesso, "Tipo de acesso.");
            this.chbAcesso.UseVisualStyleBackColor = true;
            // 
            // txtConfirma
            // 
            this.txtConfirma.Location = new System.Drawing.Point(422, 114);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(172, 25);
            this.txtConfirma.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtConfirma, "Confirmação da senha de acesso.");
            this.txtConfirma.UseSystemPasswordChar = true;
            this.txtConfirma.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirma_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar senha :";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(100, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(172, 25);
            this.txtSenha.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSenha, "Senha de acesso.");
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(100, 71);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(337, 25);
            this.txtLogin.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtLogin, "Nome de acesso para o usuário realizar \r\nautenticação no sistema.");
            this.txtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogin_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login :";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(272, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(319, 25);
            this.txtNome.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtNome, "Nome do usuário.");
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(106, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(89, 25);
            this.txtCodigo.TabIndex = 4;
            // 
            // lbCodUsuario
            // 
            this.lbCodUsuario.AutoSize = true;
            this.lbCodUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodUsuario.Location = new System.Drawing.Point(40, 34);
            this.lbCodUsuario.Name = "lbCodUsuario";
            this.lbCodUsuario.Size = new System.Drawing.Size(60, 17);
            this.lbCodUsuario.TabIndex = 0;
            this.lbCodUsuario.Text = "Código :";
            // 
            // dgUsuário
            // 
            this.dgUsuário.AllowUserToAddRows = false;
            this.dgUsuário.AllowUserToDeleteRows = false;
            this.dgUsuário.AllowUserToResizeRows = false;
            this.dgUsuário.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuário.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuário.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUsuário.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsuário.Location = new System.Drawing.Point(5, 300);
            this.dgUsuário.MultiSelect = false;
            this.dgUsuário.Name = "dgUsuário";
            this.dgUsuário.ReadOnly = true;
            this.dgUsuário.RowHeadersVisible = false;
            this.dgUsuário.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuário.Size = new System.Drawing.Size(622, 183);
            this.dgUsuário.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dgUsuário, "Usuários registrados.");
            this.dgUsuário.DoubleClick += new System.EventHandler(this.dgUsuário_DoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // wfUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 487);
            this.Controls.Add(this.dgUsuário);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.wfUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuário)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCodUsuario;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbAcesso;
        private System.Windows.Forms.TextBox txtConfirma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.DataGridView dgUsuário;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}