using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FATORIAL
{
    class Program
    {
        static public int _Fatorial(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N * _Fatorial(N - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Fatorial de 5: " + _Fatorial(5));
            Console.ReadKey();
        }
    }
}
