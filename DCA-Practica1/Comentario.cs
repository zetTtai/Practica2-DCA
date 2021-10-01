using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA_Practica1
{
    class Comentario
    {
        public static long lastID;
        private long _id;
        public long id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _mensaje;
        public string mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }
        private Reporte _reporte;
        public Reporte reporte
        {
            get { return _reporte; }
            set { _reporte = value; }
        }
        private Usuario _autor;
        public Usuario autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        private List<Comentario> _respuestas;
        public List<Comentario> respuestas
        {
            get { return _respuestas; }
            set { _respuestas = value; }
        }
        private Comentario _responde; // Comentario al que responde
        public Comentario responde
        {
            get { return _responde; }
            set { _responde = value; }
        }

    }
}
