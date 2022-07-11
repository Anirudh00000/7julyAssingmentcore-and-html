
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assingmentbasic.Answers;

namespace assingmentbasic
{
    public class Program
    {
        public  static void Main(String []args)
        {
            //Answers.evenodd();
            //Answers.boxingunboxing();
            // Answers.largestnumber();
            //Console.WriteLine($"Calling Addition method having 2 param of int type, result is : {Solutions.Addition(2, 4)} and calling overloaded method having 3 params of double type, result is: {Solutions.Addition(30.4, 50.4,33.03)} ");
            //Answer.shortstring();

            //Console.WriteLine("================== Constructor Overloading===============");
            ConstructorOverloding constructorOverloding = new ConstructorOverloding(100);
            ConstructorOverloding constructorOverloding1 = new ConstructorOverloding(1, 2);
            ConstructorOverloding constructorOverloding2 = new ConstructorOverloding(3, 4, 5);
            //Computation computation = new Computation();
            //Console.WriteLine($"result of addition method {computation.Add()}");
            //Console.WriteLine($"result of multiplication method {computation.Multiplication()}");
            //Answers.Showcricketplayer();
            // Answers.Student();


        }

    }
}
