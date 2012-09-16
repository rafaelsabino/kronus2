using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kronus_v2.Relatorios
{
    public partial class wfRelarorioEntregaEpi : Form
    {
        private Form rel=null;
        private DateTime inicio;
        private DateTime final;

        public wfRelarorioEntregaEpi(Gui.wfRelatorio relatorio)
        {
            InitializeComponent();
            this.rel = relatorio;
            this.inicio = Convert.ToDateTime(relatorio.dtpInicial.Value);
            this.final = Convert.ToDateTime(relatorio.dtpFinal.Value);
        }

        private void wfRelarorioEntregaEpi_Load(object sender, EventArgs e)
        {
            Relatorios.crvRelatorioEpi crv = new crvRelatorioEpi();//criação do objeto relatorio crystal report

            dataSets.dsEntregaFuncionario ds = new dataSets.dsEntregaFuncionario();//criaçã do objeto dataset

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("select * from Item where cod_item = cod_item", Kronus_v2.Properties.Settings.Default.KronusConnectionString);

            System.Data.SqlClient.SqlDataAdapter da2 = new System.Data.SqlClient.SqlDataAdapter("select * from LogEntrega where data_log_entrega between '" + inicio + "' and '" + final + "'", Kronus_v2.Properties.Settings.Default.KronusConnectionString);

            da.Fill(ds, "Item");

            da2.Fill(ds, "LogEntrega");

            crv.SetDataSource(ds);

            crvRelatorioEntrega.ReportSource = crv;

        }
    }
}
