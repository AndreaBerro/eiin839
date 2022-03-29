using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test du serveur SOAP
            ServiceReference2.MathsOperationsClient client = new ServiceReference2.MathsOperationsClient();

            Console.WriteLine("[Appuyer sur Enter pour continuer] \n");

            //test soustraction
            int a = 10;
            int b = 7;
            int result = client.substract(a, b);
            Console.WriteLine("résultat : " + result);
            Console.WriteLine("attendu : " + (a - b) + "\n");
            Console.ReadKey();

            //test addition
            a = 1;
            b = 2;
            result = client.add(a, b);
            Console.WriteLine("résultat : " + result);
            Console.WriteLine("attendu : " + (a + b) + "\n");
            Console.ReadKey();

            //test multiplication
            a = 2;
            b = 2;
            result = client.multiply(a, b);
            Console.WriteLine("résultat : " + result);
            Console.WriteLine("attendu : " + (a * b) + "\n");
            Console.ReadKey();

        }
    }
}
