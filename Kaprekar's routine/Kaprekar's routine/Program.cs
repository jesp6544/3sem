using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaprekar_s_routine
{
    class Program
    {
        static void Main(string[] args)
        {
            int highNumSwich = 0;
            int highNumSwichCount = 0;
            int counter = 1;
            int tmp;
            for (int i = 1000; i < 10000; i++)
            {
                tmp = i;
                do
                {
                    tmp = SortDigits(tmp, "d") - SortDigits(tmp, "a");
                    counter++;
                } while (tmp != 6174 && tmp != 0);
                
                    if (tmp == 6174)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine("{0} Took {1} switches", i, counter);
                    }
                    if (tmp == 0)
                    {
                        Console.WriteLine("{0} reaches 0",i);
                    }
                if (counter > highNumSwichCount)
                {
                    highNumSwichCount = counter;
                    highNumSwich = i;
                }
                counter = 0;
            }
            Console.WriteLine("{0} did the highest number of switches: {1}",highNumSwich, highNumSwichCount);
        }
        
        public static int SortDigits(int num, string state)  //state: a for acending, d for decending
        {
            int tmp = 0;
            int multi = 1000;
            List<int> digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num = num / 10;
            }
            if (state == "d")
            {
                digits.Sort();
                digits.Reverse();
            }
            if (state == "a")
            {
                digits.Sort();
            }
            
            foreach (int digit in digits)
            {
                tmp = tmp + digit * multi;
                multi = multi/10;
            }
            return tmp;
        }
        public static int LargestDigit(int num)
        {
            int tmp = 0;
            List<int> digits= new List<int>();
            while (num > 0)
            {
                digits.Add(num%10);
                num = num/10;
            }
            foreach (int digit in digits)
            {
                if (digit > tmp)
                    tmp = digit;
            }
            return tmp;
        }
    }
}
