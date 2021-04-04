using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> Caracteres = new Dictionary<char, char>
            {
                { 'á', 'a' }, { 'Á', 'A' },
                { 'é', 'e' }, { 'É', 'E' },
                { 'í', 'i' }, { 'Í', 'I' },
                { 'ó', 'o' }, { 'Ó', 'O' },
                { 'ú', 'u' }, { 'Ú', 'U' },
            };

            Console.Write("Ingrese texto: ");
            string ingreso = Console.ReadLine();
            foreach (KeyValuePair<char, char> caracter in Caracteres){
                ingreso = ingreso.Replace(caracter.Key, caracter.Value);
            }
            Console.WriteLine(ingreso);
            Console.ReadKey();
        }
    }
}
