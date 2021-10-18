using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //main on koht kus arvuti paneb meie programmi käima

            Console.WriteLine("Sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vali tehe (sisesta '+', '-', '*', või '/'):");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        private static void AddTwoNumbers(int x, int y) /* void tähendabe t funktsiooni ei salvestata */
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y; /* double saab salvestada kümnendarvud */
            /*decimal result = x / y; /* decimal on ülitäpne, aga vajab rohkem aega arvutil*/
            Console.WriteLine(result);
        }

        //lahutamine
        public static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }

        //korrutamine
        public static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }

    }
}
