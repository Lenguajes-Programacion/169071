using System;

namespace Practicauno
{
    class Program
    {
        //Variable de la clase
        static string nombre = "Yael";
        static void Main(string[] args)
        {
            //Respondemos con el primer argumento y el segundo.
            //Condicion se debe de cumplir todas las sentencias si utilizan &&.
            //Condicion se debe de cumplir cualquier de las sentencias si utilizan ll.
            //Tipos de comparacion > < == >= <= !=

            if (args[0].Length > 0 && args[0] == nombre) //true o false.
            {

                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("User unathorized");
            }
        }
    }
}
