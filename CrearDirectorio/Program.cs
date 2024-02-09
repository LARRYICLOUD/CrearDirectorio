using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearDirectorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE");

            //Creamos nuestro primer directorio
            //Directory.CreateDirectory("Mi segunda carpeta\\Mi tercera carpeta");
            //Console.WriteLine("Creando mi primer carpeta");

            DirectoryInfo directoryInfo = Directory.CreateDirectory("Mi cuarta carpeta");

            //Mostramos informacion del directorio creado, a traves del objeto DirectoryInfo y sus propiedades

            Console.WriteLine($"Nombre: {directoryInfo.Name} ");
            Console.WriteLine($"Ruta absoluta: {directoryInfo.FullName}");
            Console.WriteLine($"Fecha de creacion: {directoryInfo.CreationTime}");

            //Console.ReadKey();

        }
    }
}
