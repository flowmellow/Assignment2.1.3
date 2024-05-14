/*3. Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system).
Write overloaded methods with logic and give choice to user to call different methods:
a.Add(int num1, int num2)
b.Add(decimal num1, decimal num2, decimal num3)
c.Multiply(float num1, float num2)
d.Multiply(float num1, float num2, float num3)
Declare these methods as public and static.*/



using System;
using System.ComponentModel;

namespace Assignment2._1._3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string readResult;

            do
            {
                Console.WriteLine("Choose A if you would like to add 2 numbers");
                Console.WriteLine("Choose B if you would like to add 3 numbers");
                Console.WriteLine("Choose C if you would like to multiply 2 numbers");
                Console.WriteLine("Choose D if you would like to multiply 3 numbers");
                Console.WriteLine("Choose X if you would like to exit the application");

                readResult = Console.ReadLine();

                switch (readResult)
                {
                    case "A":
                    case "a":
                        Console.WriteLine(SimpleMath.Add(1, 2));
                        break;
                    case "B":
                    case "b":
                        Console.WriteLine(SimpleMath.Add(2.0m, 2.3m, 2.7m));
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine(SimpleMath.Multiply(3.5f, 3.5f));
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine(SimpleMath.Multiply(3.5f, 3.5f, 3.5f));
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                } 
            } while (readResult != "x" && readResult != "X");

            // Code before adding user switch/user option
            //Console.WriteLine(SimpleMath.Add(1, 2));
            //Console.WriteLine(SimpleMath.Add(2.0m, 2.3m, 2.7m));
            //Console.WriteLine(SimpleMath.Multiply(3.5f, 3.5f));
            //Console.WriteLine(SimpleMath.Multiply(3.5f, 3.5f, 3.5f));

        }
    }

    static public class SimpleMath
    {
        static public int Add(int num1, int num2)
        {
            return num1 + num2;           
        }

        static public decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return (decimal)num1 + (decimal)num2 + (decimal)num3;
        }

        static public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        static public float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}
