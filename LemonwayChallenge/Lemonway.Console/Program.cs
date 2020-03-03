using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonway.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciServiceReference.FibonacciWebServiceSoapClient client = new FibonacciServiceReference.FibonacciWebServiceSoapClient();

            System.Console.WriteLine(client.Fibonacci(10));
            System.Console.ReadLine();

        }
    }
}
