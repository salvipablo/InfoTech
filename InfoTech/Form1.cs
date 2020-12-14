using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            // Comparar y si es igual abrir ventana principal.
            if ( User.UserApp.Equals(user) && User.PassUser.Equals(pass) )
            {
                this.Hide();
                frmMain objFrm = new frmMain();
                objFrm.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
