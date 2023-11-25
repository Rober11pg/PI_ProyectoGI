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
        private int var;
        private Random random = new Random();
        private string[] nombre = new string[100];
        private string[] apellido = new string[100];
        private string[] usuario = new string[100];
        private string[] contra = new string[100];
        private char[] gene = new char[100];
        private int i = 0;
        private string nom, ape, usu, co, con;
        private int posicion;
        public FrmRegistrar()
        {
            InitializeComponent();
            var = random.Next(1, 5);
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
            }
        }

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
                if (co == txtConFContra.Text)
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
                btnContinuar.Enabled = false;
                txtIngreCaracteresRoot.Focus();

            }
            else
            {
                panelRoot.Visible = false;
                pbxImageRobot.Visible = false;
                txtIngreCaracteresRoot.Visible = false;
                gpBoxCaracteresroot.Visible = false;
                btnContinuarRot.Visible = false;
                btnCambiarImage.Visible = false;
                btnContinuar.Enabled = true;
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
            switch (var)
            {
                case 1:
                    if (txtIngreCaracteresRoot.Text == "qGphJD")
                    {
                        lbl_resp.Text = "Correcto";
                    }
                    else
                    {
                        lbl_resp.Text = "Incorrecto";
                    }
                    break;
                case 2:
                    if (txtIngreCaracteresRoot.Text == "W6 8HP")
                    {
                        lbl_resp.Text = "Correcto";
                    }
                    else
                    {
                        lbl_resp.Text = "Incorrecto";
                    }
                    break;
                case 3:
                    if (txtIngreCaracteresRoot.Text == "PNRHXR")
                    {
                        lbl_resp.Text = "Correcto";
                    }
                    else
                    {
                        lbl_resp.Text = "Incorrecto";
                    }
                    break;
                case 4:
                    if (txtIngreCaracteresRoot.Text == "upord")
                    {
                        lbl_resp.Text = "Correcto";
                    }
                    else
                    {
                        lbl_resp.Text = "Incorrecto";
                    }
                    break;
                case 5:
                    if (txtIngreCaracteresRoot.Text == "aumso")
                    {
                        lbl_resp.Text = "Correcto";
                    }
                    else
                    {
                        lbl_resp.Text = "Incorrecto";
                    }
                    break;
            }
            
            if (lbl_resp.Text == "Correcto")
            {
                panelRoot.Visible = false;
                pbxImageRobot.Visible = false;
                txtIngreCaracteresRoot.Visible = false;
                gpBoxCaracteresroot.Visible = false;
                btnContinuarRot.Visible = false;
                btnCambiarImage.Visible = false;
                btnContinuar.Enabled = true;
                checkBoxRobot.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ingrese de nuevo el captcha por favor");
                txtIngreCaracteresRoot.Clear();
                txtIngreCaracteresRoot.Focus();
            }
                
        }

        private void btnCambiarImage_Click(object sender, EventArgs e)
        {
            var = random.Next(1, 5);
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
            }
            btnContinuar.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtContra.Text.Length > 7)
                {
                    co = txtContra.Text;
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
            if (rdbtnH.Checked)
            {
                gene[i] = 'H';
            }
            if (rdbtnM.Checked)
            {
                gene[i] = 'M';
            }
            i++;

            FrmIngresarUsuario ObjUsuario = new FrmIngresarUsuario(nombre, apellido, usuario, contra, gene, i);
            ObjUsuario.Show();
        }

    }
}
