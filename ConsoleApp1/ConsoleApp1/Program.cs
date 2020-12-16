using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter n1 and n2");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //int n2 = Convert.ToInt32(Console.ReadLine());

            int num, i, ctr, n1, n2;

            Console.Write("Input starting number of range: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            n2 = Convert.ToInt32(Console.ReadLine());
           

            for (num = n1; num <= n2; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
            Console.WriteLine("final statement");
        }

    }
    }

