using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string pass, input;
            pass = "111";
            Console.Write("\n  Enter Your Password : ");
            input = Console.ReadLine();

            while (input != pass)
            {
                Console.WriteLine("\a *.* Error Password *.* ");

                Console.Write(" Enter Your Password : ");
                input = Console.ReadLine();
            }
            Console.WriteLine("\t WElcome ");
            Console.ReadKey();
        }
    }
}