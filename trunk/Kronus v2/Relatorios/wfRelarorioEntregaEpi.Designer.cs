namespace Kronus_v2.Relatorios
{
    partial class wfRelarorioEntregaEpi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfRelarorioEntregaEpi));
            this.crvRelatorioEntrega = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvRelatorioEpi1 = new Kronus_v2.Relatorios.crvRelatorioEpi();
            this.SuspendLayout();
            // 
            // crvRelatorioEntrega
            // 
            this.crvRelatorioEntrega.ActiveViewIndex = 0;
            this.crvRelatorioEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorioEntrega.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRelatorioEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorioEntrega.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorioEntrega.Name = "crvRelatorioEntrega";
            this.crvRelatorioEntrega.ReportSource = this.crvRelatorioEpi1;
            this.crvRelatorioEntrega.ShowCloseButton = false;
            this.crvRelatorioEntrega.ShowCopyButton = false;
            this.crvRelatorioEntrega.ShowGroupTreeButton = false;
            this.crvRelatorioEntrega.ShowParameterPanelButton = false;
            this.crvRelatorioEntrega.ShowZoomButton = false;
            this.crvRelatorioEntrega.Size = new System.Drawing.Size(763, 348);
            this.crvRelatorioEntrega.TabIndex = 0;
            this.crvRelatorioEntrega.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // wfRelarorioEntregaEpi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 348);
            this.Controls.Add(this.crvRelatorioEntrega);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wfRelarorioEntregaEpi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relarorio Entrega E.P. I.";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wfRelarorioEntregaEpi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorioEntrega;
        private crvRelatorioEpi crvRelatorioEpi1;
    }
}