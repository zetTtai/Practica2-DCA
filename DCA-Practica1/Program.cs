using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCA_Practica1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static Usuario usuarioActual;
        public static List<Usuario> usuariosRegistrados = new List<Usuario>();
        public static List<Reporte> reportesRegistrados = new List<Reporte>();
        public static bool darGracias = false;
        [STAThread]
        static void Main()
        {
            Usuario.lastID = 0;
            Reporte.lastID = 0;
            Comentario.lastID = 0;

            // Creamos el usuario administrador al comienzo del programa
            Program.usuariosRegistrados.Add(new Usuario(0,"Admin", "admin@ua", "admin"));

            Program.reportesRegistrados.Add(new Reporte("ReporteEjemplo", "Descripción", Tipo.Sugerencia, Error.Critico, usuariosRegistrados[0]));
            Program.reportesRegistrados.Add(new Reporte("Fin del mundo", "La aplicación no funciona en linux", Tipo.Importante, Error.Grave, usuariosRegistrados[0]));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio());
        }
    }
}
