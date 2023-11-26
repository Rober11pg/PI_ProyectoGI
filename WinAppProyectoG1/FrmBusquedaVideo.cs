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
    public partial class FrmBusquedaVideo : Form
    {
        private List<Video> listaVideos;
        private Video videoEncontrado;
        public FrmBusquedaVideo(List<Video> lista)
        {
            InitializeComponent();
            listaVideos = lista;
        }

        private void FrmBusquedaVideo_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarListaVideos(List<Video> nuevaLista)
        {
            listaVideos = nuevaLista;
            // Puedes hacer lo que necesites con la lista actualizada aquí
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                try 
                {
                    btnBuscar.Focus();
                }
                catch (Exception mes) 
                {
                    MessageBox.Show(mes.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreVideo = txtBusqueda.Text;

            if (listaVideos != null && listaVideos.Count > 0)
            {
                videoEncontrado = listaVideos.Find(video => video.NombreArtista == nombreVideo);

                if (videoEncontrado != null)
                {
                    mostrarDatosVideo(dataGridView1);
                }
                else
                {
                    mostrarVideoNoEncontrado(dataGridView1);
                }
            }
            else
            {
                // Mostrar un mensaje indicando que la lista de videos está vacía o no inicializada
                MessageBox.Show("Lista Vacia", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mostrarDatosVideo(DataGridView dgv) 
        {
            dgv.Rows.Clear();
            dgv.Rows.Add(videoEncontrado.NombreArtista, videoEncontrado.PeriodoActividad, videoEncontrado.GeneroArtista, videoEncontrado.PaisOrigen, videoEncontrado.TituloVideo, videoEncontrado.GeneroVideo, videoEncontrado.Discografia, videoEncontrado.Productora, videoEncontrado.Colaboraciones, videoEncontrado.DirectorVideo, videoEncontrado.DescripcionVideo, videoEncontrado.DuracionVideo, videoEncontrado.FechaPublicacion, videoEncontrado.NumeroVisitas, videoEncontrado.LinkVideo);
        }

        private void mostrarVideoNoEncontrado(DataGridView dgv) 
        {
            dgv.Rows.Clear();
            MessageBox.Show("El video no existe", "Video no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
