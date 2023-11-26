using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoG1
{
    public partial class FrmHome : Form
    {
        private string nombre;
        private string apellido;
        private List<Video> videos;
        private FrmBusquedaVideo formularioBusqueda;
        public FrmHome(string nombre, string apellido)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;

            // Puedes asignar el nombre y apellido a los controles de tu formulario
            lblNomApe.Text = nombre + " " +apellido;
        }

        private void TStrip_Salir_Click(object sender, EventArgs e)
        {
           /* FrmIngresarUsuario.LimpiarCamposEstatico();*/
            this.Close();
        }


        private void TStrip_IngresarDatosV_Click(object sender, EventArgs e)
        {
            FrmIngresarDatosVideos ObjDatosVideos = new FrmIngresarDatosVideos(formularioBusqueda);
           ObjDatosVideos.ShowDialog();
            
        }

        private void TStrip_Eliminar_Click(object sender, EventArgs e)
        {
            FrmEliminarDatosVideo ObjEliminarDatosVideo = new FrmEliminarDatosVideo();
            ObjEliminarDatosVideo.ShowDialog();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaVideo newBusqueda =  new FrmBusquedaVideo(videos);
            newBusqueda.Show();
        }
    }
}
