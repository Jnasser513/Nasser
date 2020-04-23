using System;

namespace Ejercicio_01
{
    internal class Program
    {
        public static void Main(string[] args) {
            int num;
            Console.Write("Introduzca el numero hasta donde quiere imprimir la serie de fibonacci: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("Tiene quee escoger un numero mayor que 0");
            else
            {
                if (num > 0)
                {
                    int inicial = 0, nuevo = 1, resultado;
                    Console.Write(inicial + " ");
                    Console.Write(nuevo + " ");
                    for (int i = 3; i <= num; i++)
                    {
                        resultado = inicial + nuevo;
                        Console.Write(resultado + " ");
                        inicial = nuevo;
                        nuevo = resultado;
                    }
                }
                    
            }
            
        }
    }
}