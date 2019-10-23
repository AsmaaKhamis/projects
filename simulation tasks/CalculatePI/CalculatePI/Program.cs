using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            double pi = 4;
            int c=3;
            while (i <= 1000)
            {
                if (c % 2 != 0)
                {
                    pi -=Convert.ToDouble( 4) / i;
                    c++;
                  
                }
                else
                {
                    pi += Convert.ToDouble(4) / i;
                    c++;
                    Console.WriteLine(pi);
                    
                }
                i += 2;
                 
            }
            Console.ReadKey();
        }
    }
}
