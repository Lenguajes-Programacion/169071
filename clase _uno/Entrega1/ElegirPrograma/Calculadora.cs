﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegirPrograma
{
    class Calculadora
    {
        string calcu = "";
        float numero, numero2;
        float resultado = 0;
        float acumulador = 0;


        //Metodo publico sin retorno de la clase calculadora, para la ejecucion de todo el programa
        public void Usar()
        {
            do
            {
                Console.WriteLine("Elige tu operacion");
                Console.WriteLine("Suma = +");
                Console.WriteLine("Resta = -");
                Console.WriteLine("Multiplicacion = *");
                Console.WriteLine("Division = /");

                calcu = Console.ReadLine();
                string opcion = Convert.ToString(calcu);

                switch (opcion)
                {
                    case "+":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero + numero2;
                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();
                        break;
                    case "-":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero - numero2;
                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();
                        break;
                    case "*":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero * numero2;
                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();
                        break;
                    case "/":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero / numero2;
                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Operacion equivocada");
                        Console.ReadLine();
                        break;
                }

                Console.WriteLine("Desea agregar otra operacion?");
                calcu = Console.ReadLine();

                while (calcu == "si")
                {
                    Console.WriteLine();
                    Console.WriteLine("Elija la operacion");
                    Console.WriteLine("Suma = +");
                    Console.WriteLine("Resta = -");
                    Console.WriteLine("Multiplicacion = *");
                    Console.WriteLine("Division = /");

                    calcu = Console.ReadLine();

                    if (calcu == "+")
                    {
                        Console.WriteLine("Elija numero a sumar");

                        numero2 = float.Parse(Console.ReadLine());
                        acumulador = resultado;
                        resultado = acumulador + numero2;

                        Console.WriteLine(); 

                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();

                    }
                    if (calcu == "-")
                    {
                        Console.WriteLine("Elija numero a restar");

                        numero2 = float.Parse(Console.ReadLine());
                        acumulador = resultado;
                        resultado = acumulador - numero2;

                        Console.WriteLine();

                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();

                    }
                    if (calcu == "*")
                    {
                        Console.WriteLine("Elija numero a multiplicar");

                        numero2 = float.Parse(Console.ReadLine());
                        acumulador = resultado;
                        resultado = acumulador * numero2;

                        Console.WriteLine();

                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();

                    }
                    if (calcu == "/")
                    {
                        Console.WriteLine("Elija numero a dividir");

                        numero2 = float.Parse(Console.ReadLine());
                        acumulador = resultado;
                        resultado = acumulador / numero2;

                        Console.WriteLine();

                        Console.WriteLine("El resultado es " + resultado);
                        Console.ReadLine();

                    }

                    Console.WriteLine("¿Desea agregar otra operación?");
                    calcu = Console.ReadLine();

                }

                Console.WriteLine("¿Desea continuar usando la calculadora?");
                calcu = Console.ReadLine();

            } while (calcu == "si");

          
        }
    }
}
