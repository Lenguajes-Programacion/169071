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
}
