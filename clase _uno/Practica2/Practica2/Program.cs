using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            string calcu = "";
            do
            {

                float numero, numero2;
                float resultado = 0;
                float acumulador = 0;
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
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();
                        break;
                    case "-":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero - numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();
                        break;
                    case "*":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero * numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();
                        break;
                    case "/":
                        Console.WriteLine("Elige el primer numero");
                        numero = float.Parse(Console.ReadLine());
                        Console.WriteLine("Elige el segundo numero");
                        numero2 = float.Parse(Console.ReadLine());
                        resultado = numero / numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();
                        break;
                    default: Console.WriteLine("Operacion equivocada");
                        break;
                }
                Console.WriteLine("Desea agregar otra operacion?");
                calcu = Console.ReadLine();
                
                do{
                  
                if(calcu =="si"){
                Console.WriteLine("Elija la operacion");
                Console.WriteLine("Suma = +");
                Console.WriteLine("Resta = -");
                Console.WriteLine("Multiplicacion = *");
                Console.WriteLine("Division = /");
                calcu = Console.ReadLine();
                    
                    if(calcu== "+"){
                    Console.WriteLine("Elija numero a sumar");
                        
                        numero2 = float.Parse(Console.ReadLine());
                        acumulador= resultado;
                        resultado = acumulador + numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();

                    }
                       if(calcu== "-"){
                    Console.WriteLine("Elija numero a restar");
                        
                        numero2 = float.Parse(Console.ReadLine());
                        acumulador= resultado;
                        resultado = acumulador - numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();

                    }
                           if(calcu== "*"){
                    Console.WriteLine("Elija numero a multiplicar");
                        
                        numero2 = float.Parse(Console.ReadLine());
                        acumulador= resultado;
                        resultado = acumulador * numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();

                    }
                               if(calcu== "/"){
                    Console.WriteLine("Elija numero a dividir");
                        
                        numero2 = float.Parse(Console.ReadLine());
                        acumulador= resultado;
                        resultado = acumulador / numero2;
                        Console.WriteLine("El resultado es" + resultado);
                        Console.ReadLine();

                    }
                }
                    
               
              
                }
          
               while (calcu=="si");
                 Console.WriteLine("Continuar? Si / No");
                calcu = Console.ReadLine();
            }
            
              while (calcu == "si");
              
        }
        
       
    }
}

