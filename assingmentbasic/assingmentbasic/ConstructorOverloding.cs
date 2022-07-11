using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingmentbasic
{
    public class ConstructorOverloding
    {
        public ConstructorOverloding(int a, int b)
        {
            Console.WriteLine("  Two Parameter : constructor overloading");
        }
        public ConstructorOverloding(int a, int c, int d)
        {
            Console.WriteLine(" 3 Parameter : constructor overloading")
                ;
        }
        public ConstructorOverloding(int a)
        {
            Console.WriteLine("Only 1 Parametter :constructor Overloading");
        }
    }
}
