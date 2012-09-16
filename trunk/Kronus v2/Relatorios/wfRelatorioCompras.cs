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
    public partial class wfRelatorioCompras : Form
    {
        private Form rl = null;
        private DateTime inicio;
        private DateTime final;
        public wfRelatorioCompras(Gui.wfRelatorio rl)
        {
            InitializeComponent();
            this.rl = rl;
            this.inicio = rl.dtpInicial.Value;
            this.final = rl.dtpFinal.Value;
        }

        private void wfRelatorioCompras_Load(object sender, EventArgs e)
        {          
           

            Relatorios.crvCompras rpt = new crvCompras(); //instancia objeto crystal report view (relatorio)

            dataSets.dsCompras ds = new dataSets.dsCompras(); //instancia dataset

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("Select * FROM Compra where data_compra between '" + inicio + "' and '" + final + "'", Kronus_v2.Properties.Settings.Default.KronusConnectionString); //comando para gerar relatorio

            da.Fill(ds, "Compra"); //carrega dataAdapter apartir do data set

            rpt.SetDataSource(ds); //passa o dataset para o relatorio

            wfCrystalCompras.ReportSource = rpt; //passa o relatorio para o formulario

        }

        
    }
}
