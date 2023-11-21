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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            FrmIngresarUsuario ObjIniciarSesion = new FrmIngresarUsuario();
            ObjIniciarSesion.ShowDialog();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            MessageBox.Show("x");
        }
    }
}
