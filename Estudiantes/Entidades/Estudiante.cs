using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        public Estudiante() {   }
        public string Id { get; set; }
        public string Nombre { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public int NumeroPusaciones { get; set; }

        public Estudiante(string id, string nombre, char sexo, int edad, int numeroPulsaciones)
        {
            Id = id;
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
            NumeroPusaciones = numeroPulsaciones;
        }
        public override string ToString()
        {
            return  $"{Id};{Nombre};{Sexo};{Edad};{NumeroPusaciones}";
        }
    }
}
