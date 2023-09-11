using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj: ");
            int n = Convert.ToInt16(Console.ReadLine());
            double numb = 0;
            double numc = 3;
            for(int i=1; i<=n; i++)
            {
                numb += 1 / Math.Pow(3,i);
            }
            Console.WriteLine(numb);
            Console.ReadLine();
        }
    }
}
