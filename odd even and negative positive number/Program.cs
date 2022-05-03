using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even_and_negative_positive_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number :");
            int num =int.Parse(Console.ReadLine());

            if(num<0)
                Console.WriteLine("negative number :");
            else
                Console.WriteLine("positive number :");

            if(num%2==0)
                Console.WriteLine("Even number :");
            else
                Console.WriteLine("odd number");
            Console.ReadLine();
        }
    }
}
