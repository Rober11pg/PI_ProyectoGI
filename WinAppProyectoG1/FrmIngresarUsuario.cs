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
        string[] nombre = new string[100];
        string[] apellido = new string[100];
        string[] usuario = new string[100];
        string[] contra = new string[100];
        char[] gen = new char[100];
        int i = 0;
        int posicion;
        

        public FrmIngresarUsuario(string[] nombre_, string[] apellido_, string[] usuario_, string[] contra_, char[] gen_, int i)
        {
            InitializeComponent();
            this.nombre = nombre_;
            this.apellido = apellido_;
            this.usuario = usuario_;
            this.contra = contra_;
            this.gen = gen_;
            this.i = i;
        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                ClValidaciones ObjValidar = new ClValidaciones(nombre, apellido, usuario, contra, gen);
                if (ObjValidar.ValidarContraseña(txtContrasenia.Text, posicion))
                {
                    FrmHome ObjHome = new FrmHome(nombre[posicion], apellido[posicion]);
                    ObjHome.ShowDialog();
                }
                else
                {
                    txtContrasenia.Clear();
                    txtContrasenia.Focus();
                    MessageBox.Show("Ingreso de contraseña incorrecta", "CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en btnIngresar_Click: {ex.Message}");
                // También puedes mostrar un MessageBox con el mensaje de error si es necesario.
            }
        }
       /* public static void LimpiarCamposEstatico()
        {
            FrmIngresarUsuario frmIngresarUsuario = Application.OpenForms.OfType<FrmIngresarUsuario>().FirstOrDefault();
            frmIngresarUsuario?.LimpiarCampos();
        }*/
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrar ObjRegistrar = new FrmRegistrar();
            ObjRegistrar.ShowDialog();
        }

        private void FrmIngresarUsuario_Load(object sender, EventArgs e)
        {

        }

     /*   public void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }
*/
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ClValidaciones ObjValidar = new ClValidaciones(nombre, apellido, usuario, contra, gen);
                    posicion = ObjValidar.ValidarUsuario(txtUsuario.Text, i);
                    if (posicion != -1)
                    {
                        txtContrasenia.Focus();
                    }
                    else
                    {
                        MessageBox.Show("El correo no se encuentra registrado", "CORREO NO REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en txtUsuario_KeyPress: {ex.Message}");
                // También puedes mostrar un MessageBox con el mensaje de error si es necesario.
            }
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
        }

        private void checkBoxContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContra.Checked)
            {
                txtContrasenia.PasswordChar = '\0';
            }
            else
            {
                txtContrasenia.PasswordChar = '*';
            }
        }       
    }

}
