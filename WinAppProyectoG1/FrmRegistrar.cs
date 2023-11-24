using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppProyectoG1.Properties;

namespace WinAppProyectoG1
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
            /*Assembly.LoadFile("WinAppProyectoG1.Resources.dll");
            var = random.Next(1, 5);
            switch (var)
            {
                case 1:
                    pbxImageRobot.Image = Resources.;
                    break;
                case 2:
                    pbxImageRobot.Image = Resources.2;
                    break;
                case 3:
                    pbxImageRobot.Image = Resources.3;
                    break;
                case 4:
                    pbxImageRobot.Image = Resources.4;
                    break;
                case 5:
                    pbxImageRobot.Image = Resources.5;
                    break;
            }*/
        }
        int var;
        Random random = new Random();
        string[] nombre = new string[100];
        string[] apellido = new string[100];
        string[] usuario = new string[100];
        string[] contra = new string[100];
        char[] gene = new char[100];
        string[] rol = new string[100];
        int[] edad = new int[100];
        int i = 0;
        string nom, ape, usu, co, con;
        int posicion;
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    usu = txtUsuario.Text;
                    if(usu != "")
                    {
                        txtContra.Enabled = true; 
                        txtContra.Focus();
                    }
                }
        }

        private void txtConFContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (con == txtConFContra.Text)
                {
                    grpGenero.Enabled = true;
                    rdbtnH.Enabled = true;
                    rdbtnM.Enabled = true;
                }
                else
                    MessageBox.Show("La contraseña no es la misma", "CONSTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbtnH_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnH.Checked)
            {
                checkBoxRobot.Enabled = true;
            }
        }

        private void checkBoxRobot_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRobot.Checked)
            {
                btnContinuar.Enabled = true;
               
                panelRoot.Visible = true;
                pbxImageRobot.Visible = true;
                txtIngreCaracteresRoot.Visible= true;
                gpBoxCaracteresroot.Visible= true;
                btnContinuarRot.Visible = true;
                btnCambiarImage.Visible = true;

            }
            else
            {
                panelRoot.Visible = false;
                pbxImageRobot.Visible = false;
                txtIngreCaracteresRoot.Visible = false;
                gpBoxCaracteresroot.Visible = false;
                btnContinuarRot.Visible = false;
                btnCambiarImage.Visible = false;
            }
            
        }

        private void rdbtnM_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnM.Checked)
            {
                checkBoxRobot.Enabled = true;
            }
        }

        private void checkBoxContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContra.Checked)
            {
                txtContra.PasswordChar = '\0';
                txtConFContra.PasswordChar = '\0';
            }
            else
            {
                txtContra.PasswordChar = '*';
                txtConFContra.PasswordChar = '*';
            }
        }

        private void btnContinuarRot_Click(object sender, EventArgs e)
        {
           /* var = random.Next(1, 5);
            switch (var)
            {
                case 1:
                    pbxImageRobot.Image = Resources._1;
                    break;
                case 2:
                    pbxImageRobot.Image = Resources._2;
                    break;
                case 3:
                    pbxImageRobot.Image = Resources._3;
                    break;
                case 4:
                    pbxImageRobot.Image = Resources._4;
                    break;
                case 5:
                    pbxImageRobot.Image = Resources._5;
                    break;
            }*/
            btnContinuar.Focus();
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtContra.Text.Length > 7)
                {
                    con = txtContra.Text;
                    txtConFContra.Enabled = true;
                    txtConFContra.Focus();
                    
                }
                else
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres", "CONSTRASEÑA INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                if(e.KeyChar == (char)Keys.Enter)
                {
                    ape = txtApellido.Text.Trim();
                    if(ape != "")
                    {
                        txtUsuario.Enabled = true;
                        txtUsuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un apellido", "APELLIDO VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    nom = txtNombre.Text.Trim();
                    if (nom != "")
                    {
                        txtApellido.Enabled = true;
                        txtApellido.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un nombre primero", "NOMBRE VACÍO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                   
                }
                else
                {
                    e.Handled = true; // Ignorar el carácter presionado
                    MessageBox.Show("Solo se permiten letras para el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Clear();
                    txtNombre.Focus();
                }
            }
        }




        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // txtNombre.Focus();
            nombre[i] = nom;
            apellido[i] = ape;
            usuario[i] = usu;
            contra[i] = co;
            if(rdbtnH.Checked)
            {
                gene[i] = 'H';
            }
            if(rdbtnM.Checked)
            {
                gene[i] = 'M';
            }
            i++;
        }
    }
}
