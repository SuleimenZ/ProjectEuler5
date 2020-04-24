using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 11*13*17*19;; i += 11*13*17*19)
            {
                if (i % 20 == 0 && i % 18 == 0 && i % 16 == 0 && i % 15 == 0 && i % 14 == 0&& i % 12 == 0)
                {
                    result = i;
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
