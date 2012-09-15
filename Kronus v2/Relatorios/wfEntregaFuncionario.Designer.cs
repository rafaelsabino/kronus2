namespace Kronus_v2.Relatorios
{
    partial class wfEntregaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfEntregaFuncionario));
            this.crvEntregaFunc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvEntregaFuncionario1 = new Kronus_v2.Relatorios.crvEntregaFuncionario();
            this.SuspendLayout();
            // 
            // crvEntregaFunc
            // 
            this.crvEntregaFunc.ActiveViewIndex = 0;
            this.crvEntregaFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEntregaFunc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEntregaFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEntregaFunc.Location = new System.Drawing.Point(0, 0);
            this.crvEntregaFunc.Name = "crvEntregaFunc";
            this.crvEntregaFunc.ReportSource = this.crvEntregaFuncionario1;
            this.crvEntregaFunc.ShowCloseButton = false;
            this.crvEntregaFunc.ShowCopyButton = false;
            this.crvEntregaFunc.ShowParameterPanelButton = false;
            this.crvEntregaFunc.ShowZoomButton = false;
            this.crvEntregaFunc.Size = new System.Drawing.Size(986, 470);
            this.crvEntregaFunc.TabIndex = 0;
            // 
            // wfEntregaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 470);
            this.Controls.Add(this.crvEntregaFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wfEntregaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrega Funcionário";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wfEntregaFuncionario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEntregaFunc;
        private crvEntregaFuncionario crvEntregaFuncionario1;
    }
}