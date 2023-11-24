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

        // En FrmBienvenida
        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            // Puedes crear instancias de los arreglos y pasarlos al constructor de FrmIngresarUsuario
            string[] nombre = new string[100];
            string[] apellido = new string[100];
            string[] usuario = new string[100];
            string[] contra = new string[100];
            char[] gen = new char[100];
            int i = 0;

            FrmIngresarUsuario ObjIniciarSesion = new FrmIngresarUsuario(nombre, apellido, usuario, contra, gen, i);
            ObjIniciarSesion.ShowDialog();
        }



        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
           
        }
    }
}
