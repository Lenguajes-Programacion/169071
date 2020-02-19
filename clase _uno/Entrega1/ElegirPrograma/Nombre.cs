using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegirPrograma
{
    class Name
    {
        public string nombre = "Yael";
        string n = "";
        int contra = 12345678;
        int pass;
        public void Yael()
        {
            //Respondemos con el primer argumento y el segundo.
            //Condicion se debe de cumplir todas las sentencias si utilizan &&.
            //Condicion se debe de cumplir cualquier de las sentencias si utilizan ll.
            //Tipos de comparacion > < == >= <= !=
            Console.WriteLine("Escribe el nombre");
            n = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Escribe la contrasena");
            pass = int.Parse(Console.ReadLine());

            if (n == nombre && pass== contra) //true o false.
            {
                Console.WriteLine();
                Console.WriteLine("Hello" + n);
            }
            else
            {
                Console.WriteLine("User unathorized");
            }
        }
       
    }
}
