using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA_Practica1
{
    enum Tipo
    {
        Importante,
        Normal,
        Menor,
        Sugerencia
    }
    enum Error
    {
        Critico,
        Grave,
        Serio
    }
    enum Estado
    {
        Pendiente,
        Visto,
        Arreglando,
        Solucionado,
        WONTFIX
    }
    class Reporte
    {
        public static long lastID;
        private long _id;
        public long id 
        { 
            get { return _id; } 
            set { _id = value; }
        }
        private string _nombre;
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _desc;
        public string desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
        private Tipo _tipo;
        public Tipo tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        private Error _error;
        public Error error
        {
            get { return _error; }
            set { _error = value; }
        }
        private Estado _estado;
        public Estado estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private Usuario _reportador;
        public Usuario reportador
        {
            get { return _reportador; }
            set { _reportador = value; }
        }
        private List<Comentario> _comentarios;
        public List<Comentario> comentarios
        {
            get { return _comentarios; }
            set { _comentarios = value; }
        }
        public Reporte(string nombre, string desc, Tipo tipo, Error error, Usuario reportador)
        {
            this.id = Reporte.lastID + 1;
            Reporte.lastID++;
            this.nombre = nombre;
            this.desc = desc;
            this.tipo = tipo;
            this.error = error;
            this.reportador = reportador;
            this.comentarios = new List<Comentario>();
            this.estado = Estado.Pendiente;
        }

    }
}
