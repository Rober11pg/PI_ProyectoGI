using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppProyectoG1
{
    public class Video
    {
        //Atributos Artista
        public string NombreArtista { get; set; }
        public string PeriodoActividad { get; set; }
        public string GeneroArtista { get; set; }
        public string PaisOrigen { get; set; }

        //Datos del video 
        public string TituloVideo { get; set; }
        public string GeneroVideo { get; set; }
        public string Discografia { get; set; }
        public string Productora { get; set; }
        public string Colaboraciones { get; set; }
        public string DirectorVideo { get; set; }
        public string DescripcionVideo { get; set; }

        //Datos Adicionales
        public string DuracionVideo { get; set; }
        public string FechaPublicacion { get; set; }
        public string NumeroVisitas { get; set; }
        public string LinkVideo { get; set; }
        
        //Constructor

        public Video(string nombreArtista, string periodoActividad, string generoArtista, string paisOrigen, string tituloVideo, string generoVideo, string discografia, string productora, string colaboraciones, string directorVideo, string descripcionVideo, string duracionVideo, string fechaPublicacion, string numeroVisitas, string linkVideo) 
        {
            this.NombreArtista = nombreArtista;
            this.PeriodoActividad = periodoActividad;
            this.GeneroArtista = generoArtista;
            this.PaisOrigen = paisOrigen;
            this.TituloVideo = tituloVideo;
            this.GeneroVideo = generoVideo;
            this.Discografia = discografia;
            this.Productora = productora;
            this.Colaboraciones = colaboraciones;
            this.DirectorVideo = directorVideo;
            this.DescripcionVideo = descripcionVideo;
            this.DuracionVideo = duracionVideo;
            this.FechaPublicacion = fechaPublicacion;
            this.NumeroVisitas = numeroVisitas;
            this.LinkVideo = linkVideo;
        }
    }
}
