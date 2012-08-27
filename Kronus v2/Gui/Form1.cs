using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronus_v2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
           
            
            utilCls.OpenForm(this, new login());
            Application.DoEvents();
           

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilCls.OpenForm(this, new login());
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilCls.OpenForm(this, new wfFornecedor());
        }

        private void equipamentoProteçãoIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilCls.OpenForm(this, new wfItem());
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilCls.OpenForm(this, new Gui.wfCompra());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataHora.Text = DateTime.Now.ToLongTimeString();
            data.Text = DateTime.Now.ToShortDateString();

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilCls.OpenForm(this, new Gui.wfUsuario());
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            utilCls.OpenForm(this, new Gui.wfFuncionario());
        }

                            
    }
}
