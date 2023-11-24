using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoG1
{
    public partial class FrmIngresarUsuario : Form
    {
        public FrmIngresarUsuario()
        {
            InitializeComponent();
        }

     

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmHome ObjHome = new FrmHome();
            ObjHome.ShowDialog();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrar ObjRegistrar = new FrmRegistrar();
            ObjRegistrar.ShowDialog();
        }

       
    }
}
