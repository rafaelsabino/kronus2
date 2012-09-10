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
    public partial class wfRelatorio : Form
    {
        public wfRelatorio()
        {
            InitializeComponent();
        }

        private void btGeraRelatorio_Click(object sender, EventArgs e)
        {
            if (dtpInicial.Value > dtpFinal.Value)
            {
                MessageBox.Show("A data inicial deve ser inferior a data final.", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpInicial.Focus();
            }
            else {
                
                if(utilCls.relatorio == 1){
                    this.Tag = false;
                    this.Close();
                    Form rel = new Relatorios.wfRelatorioCompras(this);
                    rel.Show();
                }
            }
        }

        private void wfRelatorio_Load(object sender, EventArgs e)
        {
            this.dtpInicial.MaxDate = DateTime.Today;
            this.dtpFinal.MaxDate = DateTime.Today;
        }

       
    }
}
