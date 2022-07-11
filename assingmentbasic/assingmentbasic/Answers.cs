using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingmentbasic
{
    public class Answers
    {

        //////Write a c# program to count the even and odd numbers in the following list. List items - 50, 65, 56, 71,81

        public static void evenodd()
        {
            List<int> number = new List<int> { 50, 65, 56, 71, 81 };
            int odd = 0, even = 0;
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"even number:{even}");
            Console.WriteLine($"odd number: {odd}");
            Console.ReadLine();

        }

        //Explain Boxing and Unboxing using code snippets.
        public static void boxingunboxing()
        {
            int x = 109;

            // Boxing copies the value of x into object A.
            object A = x;

            // Change the value of x.
            x = 235;

            // The change in x doesn't affect the value stored in A.
            System.Console.WriteLine("The value-type value = {0}", x);
            System.Console.WriteLine("The object-type value = {0}", A);
            //System.Console.ReadLine();

            //unboxing
            int num = 235;

            // boxing
            object obj = num;

            // unboxing
            int i = (int)obj;

            // Display result
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
            System.Console.ReadLine();
        }

        // Write a program to find the largest value out of 325, 750, 478.
        public static void largestnumber()
        {
            List<int> number = new List<int> { 325, 750, 478 };
            number.Sort();
            Console.WriteLine($"Largest value in the array ={number.Last()}");
            System.Console.ReadLine();

        }
        /////Write a program to prints all odd numbers between 1 and 10.
        public static void Alloddnumber()
        {
            {
                Console.WriteLine("Odd numbers from 1 to 10.");
                for (int n = 1; n < (10 + 1); n++)
                {
                    if (n % 2 != 0)
                    {
                        Console.WriteLine(n.ToString());

                    }
                }
            }
        }


        ///Define Method overloading in c# code and how to call them (write sample syntax).


        public static int Addition(int a, int b)
        {
            return a + b;
        }

        //overlaoded method
        public static double Addition(double a, double b, double c)
        {
            return a + b + c;
        }




        /// Program to create  list for Delhi, Mumbai, Kolkata, Chennai and sort them

        public static void shortstring()
        {
            {
                List<string> names = new List<string>();
                names.Add("Delhi");
                names.Add("Mumbai,");
                names.Add("Kolkata,");
                names.Add("Chennai");

                names.Sort();
                foreach (string s in names)
                    Console.WriteLine(s);
                Console.ReadLine();
            }
        }

        /////Write a code snippet in c# for an overloaded constructor.

        public static void overlodadedconstructor()
        {
        }

        /// /9. Write a program to display all the 11 cricket players using Generic Dictionary.

        public static void Showcricketplayer()
        {
            Dictionary<int, string> My_dict1 =
                      new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1, "Rohit");
            My_dict1.Add(2, "Sanju");
            My_dict1.Add(3, "Virat");
            My_dict1.Add(4, "Iyer");
            My_dict1.Add(5, "Surya");
            My_dict1.Add(6, "Ms Dhoni");
            My_dict1.Add(7, "Sir jadega");
            My_dict1.Add(8, "Bhuvneshwar Kumar");
            My_dict1.Add(9, "Jasprit Bumrah");
            My_dict1.Add(10, " Deepak ");
            My_dict1.Add(11, "Chahal");


            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("Batting order {0} Player name is {1}",
                          ele1.Key, ele1.Value);
            }
            Console.WriteLine();

        }


        public static void Student()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Akash", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Suman",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Vick",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Hemant" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Anirudh" , Age = 25 },
                new Student() { StudentID = 6, StudentName = "Vijay",  Age = 12 } ,
                new Student() { StudentID = 7, StudentName = "Radha" , Age = 16} ,
                new Student() { StudentID = 8, StudentName = "Rajan" , Age = 11 }
            };

            var list = studentList.Where(student => student.Age < 18).ToList();
            foreach (var student in list)
            {
                Console.WriteLine($"{student.StudentID} {student.StudentName} {student.Age}");
            }
        }
    }

    public class Student
    {

        public int StudentID { get; set; }
        public string? StudentName { get; set; }
        public int Age { get; set; }
    }





    public class Computation : IComputation
    {


        public int Add()
        {
            int x, y;
            Console.WriteLine("Enter the First number for add");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second  number for add");
            y = Convert.ToInt32(Console.ReadLine());
            return x + y;
        }
        public int Multiplication()
        {
            int x, y;
            Console.WriteLine("Enter the First number for multiply");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second  number for multiply");
            y = Convert.ToInt32(Console.ReadLine());
            return x * y;
        }

    }
        

    }

    
