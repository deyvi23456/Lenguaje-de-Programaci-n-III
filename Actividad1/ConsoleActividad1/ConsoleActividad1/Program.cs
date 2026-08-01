//Autor: Luis David Ruiz Villanueva
//Actividad1: Realiza run expediente de alumno desarrollando una aplicación en consola en lenguaje C#
//Fecha:31 de Julio del 2026

using System;

namespace ConsoleActividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de las variables 
            string nombre;
            string edad;
            string FechaNac;
            string carrera;

            //Proceso
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");
            Console.WriteLine("\n\nIngresa los datos que se le pide: ");
            Console.WriteLine("Nombre completo: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Edad: ");
            edad = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento (DD/MM/AAAA): ");
            FechaNac = Console.ReadLine();
            Console.WriteLine("Carrera a la desea ingresar: ");
            carrera = Console.ReadLine();

            Console.WriteLine("\n\nGracias " + nombre + "por formar parte de UMI/Universidad Coppel.  \nBievenid@ a la carrera de " + carrera + ".");
            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("\nDatos ingresados: ");
            Console.WriteLine("Nombre: " + nombre + ".");
            Console.WriteLine("Edad: " + edad + ".");
            Console.WriteLine("Fecha de Nacimiento: " + FechaNac + ".");
            Console.WriteLine("Carrera asignada: " + carrera + ".");
        }
    }
}
