using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinAppProyectoG1
{
    public partial class FrmIngresarDatosVideos : Form
    {

        string nombre, periodo, generoArtista, pais, tituloVideo, generoVideo, discografia, productora, colaboraciones, director, descripcion, duracion, fecha, visitas, link;
       
        string restriccionPuntuacion0Simbolos = @"[^\p{L}]+$"; // Permitir solo letras

        



        private void txtNumeroVisitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                visitas = txtNumeroVisitas.Text;
                // Verifica si la cadena contiene solo números o no está vacía o la restriccion de signos de puntuacion o simbolos
                
                /*^: Indica que la coincidencia debe comenzar al inicio de la cadena.
                [0-9]: Representa cualquier dígito del 0 al 9.
                +: Indica que debe haber uno o más dígitos.
                $: Indica que la coincidencia debe estar al final de la cadena.*/
                if (!Regex.IsMatch(visitas, @"^[0-9]+$") || string.IsNullOrWhiteSpace(visitas))
                {
                    MessageBox.Show("Por favor, ingrese el número de visitas del video. No se permite un dato nulo(en blanco), números negativos, letras o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumeroVisitas.Clear();

                }
                else
                {
                    txtLink.Focus();
                }

            }
        }

        private void txtLink_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                link = txtLink.Text;
                // Expresión regular para verificar un formato de enlace web simple
                string patron = @"^(http|https)://[a-zA-Z0-9\-.]+\.[a-zA-Z]{2,}(\/\S*)?$";
                //verifica si la cadena link coincide con el patrón especificado por la expresión regular patron.
                if (Regex.IsMatch(link, patron))
                {
                    MessageBox.Show("El enlace es válido.", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnIngresar.Enabled = true;
                    btnIngresar.Focus();
                    
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un enlace válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLink.Clear();

                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmEliminarDatosVideo objEnvioDatos = new FrmEliminarDatosVideo();
            objEnvioDatos.RecibirDatos(nombre, periodo, generoArtista, pais, tituloVideo, generoVideo, discografia, productora, colaboraciones, director, descripcion, duracion, fecha, visitas, link);
            MessageBox.Show("Datos enviados", "Validación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            objEnvioDatos.ShowDialog();
        }

        private void FrmIngresarDatosVideos_Load(object sender, EventArgs e)
        {
            btnIngresar.Enabled=false;  
        }

        private void dateTimeDuracion_ValueChanged(object sender, EventArgs e)
        {
            
            duracion = dateTimeDuracion.Value.ToString("HH:mm:ss"); 
        }

        private void dateTimeFechaPublicacion_ValueChanged(object sender, EventArgs e)
        {
            fecha = dateTimeFechaPublicacion.Value.ToString();
          
        }

        
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                descripcion = txtDescripcion.Text;
                
                //verifica si lleva numeros o que no este vacio el campo de descripcion o la restriccion de signos de puntuacion o simbolos
                if (Regex.IsMatch(descripcion, @"\d") || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Por favor, ingrese la descripción del video. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDescripcion.Clear();

                }
                else
                {
                    dateTimeDuracion.Focus();
                }

            }
        }

        private void txtDirectorVideo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                director = txtDirectorVideo.Text;
            
                //verifica si lleva numeros o que no este vacio el campo de director o la restriccion de signos de puntuacion o simbolos
                if (Regex.IsMatch(director, @"\d") || string.IsNullOrWhiteSpace(director) || Regex.IsMatch(director, restriccionPuntuacion0Simbolos))
                {
                    MessageBox.Show("Por favor, ingrese el director/a del video. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDirectorVideo.Clear();

                }
                else
                {
                    txtDescripcion.Focus();
                }

            }
        }

        

        private void txtColaboraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                colaboraciones = txtColaboraciones.Text;
                
                //verifica si lleva numeros o que no este vacio el campo de colaboraciones o la restriccion de signos de puntuacion o simbolos
                if (Regex.IsMatch(colaboraciones, @"\d") || string.IsNullOrWhiteSpace(colaboraciones) || Regex.IsMatch(colaboraciones, restriccionPuntuacion0Simbolos))
                {
                    MessageBox.Show("Por favor, ingrese los colaboradores del video. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtColaboraciones.Clear();

                }
                else
                {
                    txtDirectorVideo.Focus();
                }

            }
        }

        private void txtProductora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                productora = txtProductora.Text;
           
                //verifica si lleva numeros o que no este vacio el campo de productora o la restriccion de signos de puntuacion o simbolos
                if (Regex.IsMatch(productora, @"\d") || string.IsNullOrWhiteSpace(productora) || Regex.IsMatch(productora, restriccionPuntuacion0Simbolos))
                {
                    MessageBox.Show("Por favor, ingrese la productora del video. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductora.Clear();

                }
                else
                {
                    txtColaboraciones.Focus();
                }

            }
        }

        private void txtDiscografia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                discografia = txtDiscografia.Text;
                
                //que no este vacio el campo de DISCOGRAFIA o la restriccion de signos de puntuacion o simbolos
               
                if (string.IsNullOrWhiteSpace(discografia))
                {
                    MessageBox.Show("Por favor, ingrese la discografía del video. No se permite un dato nulo(en blanco) ni símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDiscografia.Clear();

                }
                else
                {
                    txtProductora.Focus();
                }

            }
        }

        private void cmbGeneroVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
                generoVideo = cmbGeneroVideo.SelectedItem.ToString();
                txtDiscografia.Focus(); 

        }

        private void txtTituloVideo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tituloVideo = txtTituloVideo.Text;
              
                //verifica si lleva numeros o que no este vacio el campo de tituloVideo o la restriccion de signos de puntuacion o simbolos
                if (Regex.IsMatch(tituloVideo, @"\d") || string.IsNullOrWhiteSpace(tituloVideo) || Regex.IsMatch(tituloVideo, restriccionPuntuacion0Simbolos))
                {
                    MessageBox.Show("Por favor, ingrese el título del video. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTituloVideo.Clear();

                }
                else
                {
                    cmbGeneroVideo.Focus();
                }

            }
        }

        private void txtPaisOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pais = txtPaisOrigen.Text;
                //verifica si lleva numeros o que no este vacio el campo de pais o la restriccion de signos de puntuacion o simbolos
               
                if (Regex.IsMatch(pais, @"\d") || string.IsNullOrWhiteSpace(pais) || Regex.IsMatch(pais, restriccionPuntuacion0Simbolos))
                {
                    MessageBox.Show("Por favor, ingrese el país de origen del artista. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPaisOrigen.Clear();

                }
                else
                {
                    txtTituloVideo.Focus();
                }

            }
        }

        private void txtGenerosArtista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                generoArtista = txtGenerosArtista.Text;
               
                //verifica si lleva numeros o que no este vacio el campo de generoArtista o la restriccion de signos de puntuacion o simbolos
                
                    if ((Regex.IsMatch(generoArtista, @"\d")) || (string.IsNullOrWhiteSpace(generoArtista)) || Regex.IsMatch(generoArtista, restriccionPuntuacion0Simbolos))
                {
                    MessageBox.Show("Por favor, ingrese los géneros que interpreta el artista. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGenerosArtista.Clear();

                }
                else
                {
                    txtPaisOrigen.Focus();
                }

            }
        }

        public FrmIngresarDatosVideos()
        {
            InitializeComponent();

            //FormularioDestino = new FrmEliminarDatosVideo();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                
                nombre = txtNombre.Text;

                //verifica si lleva numeros o que no este vacio el campo de nombre o la restriccion de signos de puntuacion o simbolos
                if (Regex.IsMatch(nombre, @"\d") || string.IsNullOrEmpty(nombre) || Regex.IsMatch(nombre,restriccionPuntuacion0Simbolos)) 
                {
                    MessageBox.Show("Por favor, ingrese el nombre del artista. No se permite un dato nulo(en blanco), números o símbolos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Clear();

                }
                else
                {
                    txtPeriodoActividad.Focus();
                }
                
            }
         
        }

        private void txtPeriodoActividad_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == (char)Keys.Enter)
            {
                periodo = txtPeriodoActividad.Text;
                //que no este vacio el campo de PERIODO 
                if (string.IsNullOrWhiteSpace(periodo))
                {
                    MessageBox.Show("Por favor, ingrese el periodo de actividad del artista. No se permite un dato nulo(en blanco)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPeriodoActividad.Clear();

                }
                else
                {
                    txtGenerosArtista.Focus();
                }

            }
        }
    }
    
}
