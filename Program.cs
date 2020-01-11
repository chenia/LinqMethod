using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();
            //bool result = method.TestSequenceEqual();
            method.TestJoin();
            Console.ReadKey();

        }
    }
}
