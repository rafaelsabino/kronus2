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
    public partial class wfEntregaFuncionario : Form
    {
        private Form r = null;
        private DateTime inicio;
        private DateTime final;
        public wfEntregaFuncionario(Gui.wfRelatorio relatorio)
        {
            InitializeComponent();
            this.r = relatorio;
            this.inicio = Convert.ToDateTime(relatorio.dtpInicial.Value);
            this.final = Convert.ToDateTime(relatorio.dtpFinal.Value);
        }

        private void wfEntregaFuncionario_Load(object sender, EventArgs e)
        {
           
            Relatorios.crvEntregaFuncionario crv = new crvEntregaFuncionario(); // instancia do crystal report

            dataSets.dsEntregaFuncionario ds = new dataSets.dsEntregaFuncionario(); //instancia dataset

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("select * from Funcionario  where cod_funcionario = cod_funcionario", Kronus_v2.Properties.Settings.Default.KronusConnectionString);

            System.Data.SqlClient.SqlDataAdapter da2 = new System.Data.SqlClient.SqlDataAdapter("select * from Item where cod_item = cod_item", Kronus_v2.Properties.Settings.Default.KronusConnectionString);

            System.Data.SqlClient.SqlDataAdapter da3 = new System.Data.SqlClient.SqlDataAdapter("select * from LogEntrega  where data_log_entrega between '" + inicio + "' and '" + final + "'", Kronus_v2.Properties.Settings.Default.KronusConnectionString);

            da.Fill(ds, "Funcionario");//

            da2.Fill(ds, "Item");//carrega o data adapterapartir do data set 

            da3.Fill(ds, "LogEntrega");//

            crv.SetDataSource(ds);//passa o data set para o relatorio

            crvEntregaFunc.ReportSource = crv;//carrega o relatorio na  tela

        }
    }
}
