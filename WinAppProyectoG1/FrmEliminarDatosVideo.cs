using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WinAppProyectoG1
{
    public partial class FrmEliminarDatosVideo : Form
    {
        public FrmEliminarDatosVideo()
        {
            InitializeComponent();
        }

        private void FrmEliminarDatosVideo_Load(object sender, EventArgs e)
        {
        }

        public void RecibirDatos(string nombre,string periodo,string generoArtista,string pais,string tituloVideo,string generoVideo,string discografia,string productora,string colaboraciones,string director,string descripcion,string duracion,string fecha,string visitas,string link)
        {
            dataGridView1.Rows.Add(nombre, periodo, generoArtista, pais, tituloVideo, generoVideo, discografia, productora, colaboraciones, director, descripcion, duracion, fecha, visitas, link);
        }
    }
}
