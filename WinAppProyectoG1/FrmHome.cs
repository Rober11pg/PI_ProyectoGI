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
        public FrmHome()
        {
            InitializeComponent();
        }

        private void TStrip_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TStrip_IngresarDatosV_Click(object sender, EventArgs e)
        {
            FrmIngresarDatosVideos ObjDatosVideos = new FrmIngresarDatosVideos();
            ObjDatosVideos.ShowDialog();
        }
    }
}
