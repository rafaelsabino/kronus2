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
        
        public login()
        {
            InitializeComponent();
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            Application.Exit();
        }

        

       

       
       
    }
}
