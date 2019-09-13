using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = new int[] { 1, 3, 5, 7, 9 };
            double[] arrayDouble = new double[] { 1.1, 3.7, 5.6, 7.5, 9.0 };
            string[] arrayString = new string[] { "asdasd", "asdasdm", "sadasd", "hola" };

            string mensaje = InformarTipo<string>(arrayString,2);
            Console.WriteLine(mensaje);
            
        }

        static string InformarTipo<T>(T[] arreglo, int posicion)
        {
            var valor = arreglo[posicion];
            var a = valor.GetType();
            
            return $"El valor de la posicion {posicion} es {valor} y es del tipo {a}";
        
        }
    }
}
