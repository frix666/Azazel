using System;

namespace Deym
{





    public class Math
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("Add=  " + (num1 + num2));
        }

        public void Sub(int num1, int num2)
        {
            Console.WriteLine("Subtraction=  " + (num1 - num2));
        }
        public void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication=  " + (num1 * num2));
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine("Division=  " + (num1 / num2));
        }


    }





    class Program
    {
        static void Main(string[] args)
        {
            Math meth = new Math();

            int num1, num2;

            Console.WriteLine("Enter Num1:");
            nim1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Num 2");
            nim2 = int.Parse(Console.ReadLine());

            meth.Add(num1, num2);
            meth.Sub(num1, num2);
            meth.Mul(num1, num2);
            meth.Div(num1, num2);



        }
    }
}