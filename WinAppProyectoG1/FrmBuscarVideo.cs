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
    public partial class FrmBuscarVideo : Form
    {
         List<Video> videoList;
        public FrmBuscarVideo(List<Video> videos)
        {
            InitializeComponent();
            InitializeTextBox();
            this.videoList = videos;
        }

        private void InitializeTextBox() 
        {
            txtBusqueda.Text = "Buscar...";
            txtBusqueda.ForeColor = SystemColors.GrayText;

            txtBusqueda.Enter += txtBusqueda_Enter; 
            txtBusqueda.Leave += txtBusqueda_Leave;
            
        }
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Buscar...")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor= SystemColors.ControlText;
            }
        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                txtBusqueda.Text = "Buscar...";
                txtBusqueda.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
