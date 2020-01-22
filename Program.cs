using System;

namespace CalculaFactorial {
    class Program {
        static void Main(string[] args) {

            int numero;

            Console.Write("Factorial de: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEl factorial de " + numero + " es: " + CalcularFactorial(numero));



        }
        static long CalcularFactorial(int numero) {

            long factorial = 1;
            
            for(int i = 0 ; i < numero ; i++) {
                factorial *= i + 1;
            }
            return factorial;

        }
    }
}
