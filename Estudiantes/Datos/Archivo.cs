using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        string ruta = "estudiantes.txt";
        public void GuardarEstudiante(Estudiante estudiante)
        {
            StreamWriter writer = new StreamWriter(ruta, true);
            writer.WriteLine(estudiante.ToString());
            writer.Close();
        }
    }
}
