using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Calculadora
{
    class Memoria
    {
        public void Leermemoria()
        {
            string archivoDB = "../../db.json";
            StreamReader reader = new StreamReader(archivoDB);
            var dbJSON = reader.ReadToEnd();
            var dbObject = JObject.Parse(dbJSON);
            // Prueba de lectura de archivo db.json
            //var result = dbObject.ToString();
            //var result = dbObject["arreglo"].ToString();
            //var result = dbObject["arreglo"][0].ToString();
            // Lectura de json iterable
            foreach (var item in dbObject)
            {
                // Iteración individual de cada grupo de datos del objeto json.
                Console.WriteLine("Dato en memoria:");
                MemoriaData memoriaData = new MemoriaData(DateTime.Now, item.Value["operacion"].ToString(), (int)item.Value["resultado"]);
                Console.WriteLine(item.Value.ToString());
            }
        }
    }

    class MemoriaData
    {
        DateTime fecha;
        string operacion;
        int resultado;

        public MemoriaData(DateTime date, string operation, int result)
        {
            fecha = date;
            operacion = operation;
            resultado = result;
        }
    }
    class Arreglos
    {
        public void arreglos()
        {
            Console.WriteLine("");
            Console.WriteLine("Arreglo Sencillo\n");
            string[] sencillo = { "Rojo", "Blanco", "Morado" };
            Console.WriteLine("[{0}]", string.Join(", ", sencillo));

            Console.WriteLine("");
            Console.WriteLine("Arreglo Dos Dimensiones\n");
            int[,] dosDimensiones = new int[5, 5];

            for (int i = 0; i < dosDimensiones.GetLength(0); i++)
            {
                for (int j = 0; j < dosDimensiones.GetLength(1); j++)
                {
                    dosDimensiones[i, j] = i + j;
                    Console.WriteLine("{0},{1}={2}", i, j, dosDimensiones[i, j]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Arreglo Tres Dimensiones\n");
           
            int[,,] tresDimensiones = new int[5, 5, 5];
            for (int i = 0; i < tresDimensiones.GetLength(0); i++)
            {
                for (int j = 0; j < tresDimensiones.GetLength(1); j++)
                {
                    for (int k = 0; k < tresDimensiones.GetLength(2); k++)
                    {
                        tresDimensiones[i, j, k] = i + j + k;
                        Console.WriteLine("{0},{1},{2}={3}", i, j, k, tresDimensiones[i, j, k]);
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Arreglo 4 Dimensiones\n");
           
            int[,,,] cuatroDimensiones = new int[5, 5, 5, 5];
            for (int i = 0; i < cuatroDimensiones.GetLength(0); i++)
            {
                for (int j = 0; j < cuatroDimensiones.GetLength(1); j++)
                {
                    for (int k = 0; k < cuatroDimensiones.GetLength(2); k++)
                    {
                        for (int l = 0; l < cuatroDimensiones.GetLength(3); l++)
                        {
                            cuatroDimensiones[i, j, k, l] = i + j + k + l;
                            Console.WriteLine("{0},{1},{2},{3}={4}", i, j, k, l, cuatroDimensiones[i, j, k, l]);
                        }
                    }
                }
            }
        }
    }
}

    
