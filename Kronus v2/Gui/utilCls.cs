using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;


namespace Kronus_v2
{
    class utilCls
    {
        public static int Log_User = 0;
        
        
        #region --Forms--

        public static void OpenForm(Form pai,Form filho)
        {
            try
            {
                for (int i = 0; i < Application.OpenForms.Count ; i++)
                {
                    if (Application.OpenForms[i].Name.Equals(filho.Name))
                    {
                        Application.OpenForms[i].TopMost = true;
                        Application.OpenForms[i].BringToFront();
                        Application.OpenForms[i].Activate();
                        Application.OpenForms[i].Focus();
                        Application.DoEvents();
                        return;
                    }
                }
                filho.MdiParent = pai;
                Application.DoEvents();               
                filho.Show();
                filho.StartPosition = FormStartPosition.CenterParent;
                
            }
            catch (Exception)
            {                
               MessageBox.Show("Erro ao tentar abrir a janela!", "Kronus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion


    }
}
