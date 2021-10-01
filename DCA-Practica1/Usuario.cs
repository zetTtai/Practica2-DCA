using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCA_Practica1
{
    class Usuario
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
        private string _email;
        public string email 
        { 
            get { return _email;  }
            set { _email = value; }
        }
        private string _password;
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        private bool _admin;
        public bool admin
        {
            get { return _admin; }
            set { _admin = value; }
        }
        private List<Reporte> _reportes;
        public List<Reporte> reportes
        {
            get { return _reportes; }
            set { _reportes = value; }
        }
        public Usuario(string nombre, string email, string password)
        {
            this.id = Usuario.lastID + 1;
            Usuario.lastID++;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.admin = false;
            this.reportes = new List<Reporte>();
        }
        public Usuario(long id, string nombre, string email, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
            this.admin = true;
            this.reportes = new List<Reporte>();
        }

        public void storageReport(Reporte reporte)
        {
            this.reportes.Add(reporte);
        }
    }
}
