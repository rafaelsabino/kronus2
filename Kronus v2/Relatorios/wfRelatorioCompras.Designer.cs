namespace Kronus_v2.Relatorios
{
    partial class wfRelatorioCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfRelatorioCompras));
            this.wfCrystalCompras = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crvCompras1 = new Kronus_v2.Relatorios.crvCompras();
            this.SuspendLayout();
            // 
            // wfCrystalCompras
            // 
            this.wfCrystalCompras.ActiveViewIndex = 0;
            this.wfCrystalCompras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wfCrystalCompras.Cursor = System.Windows.Forms.Cursors.Default;
            this.wfCrystalCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wfCrystalCompras.Location = new System.Drawing.Point(0, 0);
            this.wfCrystalCompras.Name = "wfCrystalCompras";
            this.wfCrystalCompras.ReportSource = this.crvCompras1;
            this.wfCrystalCompras.ShowCloseButton = false;
            this.wfCrystalCompras.ShowCopyButton = false;
            this.wfCrystalCompras.ShowGroupTreeButton = false;
            this.wfCrystalCompras.ShowParameterPanelButton = false;
            this.wfCrystalCompras.ShowZoomButton = false;
            this.wfCrystalCompras.Size = new System.Drawing.Size(882, 368);
            this.wfCrystalCompras.TabIndex = 0;
            this.wfCrystalCompras.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // wfRelatorioCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 368);
            this.Controls.Add(this.wfCrystalCompras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "wfRelatorioCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Compras";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wfRelatorioCompras_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer wfCrystalCompras;
        private crvCompras crvCompras1;


    }
}