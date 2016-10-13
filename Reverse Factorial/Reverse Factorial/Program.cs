using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double tmp = 0;
            int counter = 2;
            int num = 0;
            Console.WriteLine("Input number to find Reverse Factorial");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
            }
            tmp = num;
            while (true)
            {
                if (tmp / counter >= 1)
                {
                    tmp = tmp/counter;
                    counter++;
                }
                else if (tmp == 1)
                {
                    Console.WriteLine("{0} is = {1}!",num,counter-1);
                    break;
                }
                else if (tmp < 1)
                {
                    Console.WriteLine("{0} Has no factorial",num); 
                }
                
            }
        }
    }
}
