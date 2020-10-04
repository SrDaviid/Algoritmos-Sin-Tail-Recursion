using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sumatoria de 1 a n
            Console.WriteLine("Ingrese un numero");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1, s = 0;
            while (i<= n)
            {
                Console.WriteLine(i);
                s = s + i;
                i = i + 1;
            }
            Console.WriteLine("La sumantoria es: {0}", s);
            Console.ReadLine();

            //Factorial de 1 a n
            Console.WriteLine("Enter a number");
            int n, factorial = 1, contador = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                contador = contador+1;
                factorial = factorial * contador;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();


            //Maximo Comun Divisor GCD
            Console.WriteLine("Enter your numerator");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your denominator");
            int number2 = int.Parse(Console.ReadLine());

            int answer = GCD(number1, number2);

            Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", number1, number2, answer);
            Console.ReadLine();

            static int GCD( int n1, int n2)
            {
                if (n2 == 0)
                {
                    return n1;
                }
                else
                {
                    return GCD(n2, n1 % n2);
                }
            }

        } 
    }
}
