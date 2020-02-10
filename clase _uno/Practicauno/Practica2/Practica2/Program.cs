using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num;
            int numero, numero2;
            int suma, resta, mult, div;
            Console.WriteLine("Elige tu operacion");
            num = Convert.ToByte(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Elige el primer numero");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elige el segundo numero");
                    numero2 = int.Parse(Console.ReadLine());
                    suma = numero + numero2;
                    Console.WriteLine("El resultado es" + suma);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Elige el primer numero");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elige el segundo numero");
                    numero2 = int.Parse(Console.ReadLine());
                    resta = numero - numero2;
                    Console.WriteLine("El resultado es" + resta);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Elige el primer numero");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elige el segundo numero");
                    numero2 = int.Parse(Console.ReadLine());
                    mult = numero * numero2;
                    Console.WriteLine("El resultado es" + mult);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Elige el primer numero");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elige el segundo numero");
                    numero2 = int.Parse(Console.ReadLine());
                    div = numero / numero2;
                    Console.WriteLine("El resultado es" + div);
                    Console.ReadLine();
                    break;
            }

        }
    }
}

