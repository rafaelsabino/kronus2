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
    public partial class login : Form
    {
        private Principal wfHome = null;

        public login(Principal wfHome)
        {
            InitializeComponent();
            this.wfHome = wfHome;
            this.wfHome.fornecedoresToolStripMenuItem.Visible = false;
            this.wfHome.equipamentoProteçãoIndividualToolStripMenuItem.Visible = false;
            this.wfHome.comprasToolStripMenuItem.Visible = false;
            this.wfHome.funcionariosToolStripMenuItem.Visible = false;
            this.wfHome.relatóriosToolStripMenuItem.Visible = false;
            this.wfHome.administraçãoToolStripMenuItem.Visible = false;
            this.wfHome.statusStrip1.Items[0].Text = "";
            this.wfHome.MainMenuStrip.Enabled = false;
                      
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            Application.Exit();
        }

        private void Logar_Click(object sender, EventArgs e)
        {
            br.data.clsDataBaseConnection db = new br.data.clsDataBaseConnection();
            
                DataTable dt = db.retornaDataTable("select nome_user, login_user, senha_user, tipo_user from Usuario where login_user = '" + txtLogin.Text +
               "' and senha_user = '" + txtSenha.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    String login = dt.Rows[0]["login_user"].ToString();
                    String senha = dt.Rows[0]["senha_user"].ToString();
                    String nome = dt.Rows[0]["nome_user"].ToString();
                    int tipo = Convert.ToInt32(dt.Rows[0]["tipo_user"]);
                    if (String.Compare(login, txtLogin.Text, false) != 0)
                    {
                        MessageBox.Show("O login informado não está correto.\nDigite novamente!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtLogin.Text = String.Empty;
                        txtSenha.Text = String.Empty;
                        txtLogin.Focus();
                    }
                    else {
                        if (String.Compare(senha, txtSenha.Text, false) != 0)
                        {
                            MessageBox.Show("A senha informada é diferente da senha cadastrada.\nInforme a senha novamente!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSenha.Text = String.Empty;
                            txtSenha.Focus();
                        }
                        else {
                            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
                            {
                                MessageBox.Show("Bem vindo " + nome + "!\nQue disposição, hein!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else {
                                if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                                {
                                    MessageBox.Show("Bem vindo " + nome + "!\nTenha um bom dia!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else {
                                    if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                                    {
                                        MessageBox.Show("Bem vindo  " + nome + "!\nTenha uma boa tarde!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else {
                                        MessageBox.Show("Bem vindo " + nome + "!\nTenha uma boa noite!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            this.wfHome.mnPrincipal.Enabled = true;
                                                     
                            if (tipo == 0)
                            {
                                this.wfHome.fornecedoresToolStripMenuItem.Visible = true;
                                this.wfHome.equipamentoProteçãoIndividualToolStripMenuItem.Visible = true;
                                this.wfHome.comprasToolStripMenuItem.Visible = true;
                                this.wfHome.funcionariosToolStripMenuItem.Visible = true;
                                this.wfHome.relatóriosToolStripMenuItem.Visible = true;
                                this.wfHome.administraçãoToolStripMenuItem.Visible = true;
                                this.wfHome.statusStrip1.Items[0].Text = "\tUSUÁRIO : " + nome;
                            }
                            else {
                                if(tipo == 1){
                                    this.wfHome.fornecedoresToolStripMenuItem.Visible = false;
                                    this.wfHome.equipamentoProteçãoIndividualToolStripMenuItem.Visible = false;
                                    this.wfHome.comprasToolStripMenuItem.Visible = false;
                                    this.wfHome.funcionariosToolStripMenuItem.Visible = false;
                                    this.wfHome.relatóriosToolStripMenuItem.Visible = false;
                                    this.wfHome.administraçãoToolStripMenuItem.Visible = false;
                                    this.wfHome.statusStrip1.Items[0].Text = "\tUSUÁRIO : " + nome;
                                }                                
                            }
                            this.Tag = false;                            
                            this.Close();

                            
                        }
                    }
                }
                else {
                    MessageBox.Show("Usuário ou senha estão incorretos.\nDigite novamente!", "kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Text = String.Empty;
                    txtSenha.Text = String.Empty;
                    txtLogin.Focus();                
                }
        }

       
    }
}
