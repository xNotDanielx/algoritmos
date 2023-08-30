using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Logica
{
    public class ServicioEstudiante
    {
        Archivo archivo = new Archivo();
        public void Guardar(Estudiante estudiante)
        {
            try
            {
                if (estudiante != null)
                {
                    archivo.GuardarEstudiante(estudiante);
                }
            }
            catch (Exception)
            {

                throw;
            }            
        }

         public int CalcularPulsaciones(Estudiante estudiante)
        {
            if (estudiante.Sexo.Equals('F') || estudiante.Sexo.Equals('f')  )
            {
                estudiante.NumeroPusaciones = (220 - estudiante.Edad) / 10;
                return estudiante.NumeroPusaciones;
            }
            else
            {
                estudiante.NumeroPusaciones = (210 - estudiante.Edad) / 10;
                return estudiante.NumeroPusaciones;
            }
        }
    }
}
