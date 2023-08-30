using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class GUI
    {
        ServicioEstudiante servicioEstudiante = new ServicioEstudiante();
        Estudiante estudiante = new Estudiante();
        public void Menu()
        {
            int Op = 0;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5); Console.WriteLine("Bienvenido al sistema de registro de estudiantes y calculo de sus pulsaciones x segundo");
                Console.SetCursorPosition(10, 6); Console.WriteLine("1. Registrar estudiante");
                Console.SetCursorPosition(10, 7); Console.WriteLine("2. Consultar estudiante");
                Console.SetCursorPosition(10, 8); Console.WriteLine("3. Informe de estudiantes");
                Console.SetCursorPosition(10, 9); Console.WriteLine("0. Salir");
                Console.SetCursorPosition(10, 10); Console.Write("Opcion: "); Op = int.Parse(Console.ReadLine());
                switch (Op)
                {
                    case 1: RegistrarEstudiante(); break;

                    case 2: ConsultarEstudiante(); break;

                    case 3:InformeEstudiantes(); break;

                    default: Console.WriteLine("Opcion no valida"); break;
                }
            } while (Op != 0);
        }

        public void RegistrarEstudiante()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 5); Console.WriteLine("Registro de estudiante");
            Console.SetCursorPosition(10, 6); Console.Write("Id: "); estudiante.Id = Console.ReadLine();   
            Console.SetCursorPosition(10, 7); Console.Write("Nombre: "); estudiante.Nombre = Console.ReadLine();
            Console.SetCursorPosition(10, 8); Console.Write("Sexo: "); estudiante.Sexo = char.Parse(Console.ReadLine());
            Console.SetCursorPosition(10, 9); Console.Write("Edad: "); estudiante.Edad= int.Parse(Console.ReadLine());
            Console.SetCursorPosition(10, 10); Console.Write("Su numero de pulsaciones es: " + servicioEstudiante.CalcularPulsaciones(estudiante));
            Console.SetCursorPosition(10, 13); Console.WriteLine("Presione una tecla para continuar"); Console.ReadKey();   
            servicioEstudiante.Guardar(estudiante);
        }

        public void ConsultarEstudiante()
        {
            Console.Clear();
        }

        public void InformeEstudiantes()
        {
            Console.Clear();
        }

    }
}
