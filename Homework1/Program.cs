using System;

namespace Homework1
{
    class Program
    {
        static void Task1()
        {
            Console.Write("Enter number of hours: ");
            int NumHours = Convert.ToInt32(Console.ReadLine());
            int NumMinutes = NumHours * 60;

            Console.WriteLine("Result: " + NumMinutes);
        }
        static void Task2()
        {
            Console.Write("Enter A value: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter B value: ");
            double B = Convert.ToDouble(Console.ReadLine());
            double result = (5 * A + B * B) / (B - A);

            Console.WriteLine("Result: " + result);
        }

        static void Task3()
        {
            Console.Write("Enter string A: ");
            string A = Console.ReadLine();
            Console.Write("Enter string B: ");
            string B = Console.ReadLine();
            Console.WriteLine("A - " + A + "  B - " + B);

            string swap = A;
            A = B;
            B = swap;

            Console.WriteLine("Swapped A - " + A + "  Swapped B - " + B);
        }

        static void Task4()
        {
            Console.Write("Enter A value: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B value: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int dividing = A / B;
            Console.WriteLine("Dividing: " + dividing);

            int remainder = A % B;
            Console.WriteLine("Remainder: " + remainder);
        }

        static void Task5()
        {
            Console.Write("Enter A value: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter B value: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter C value: ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your linear equation: " + A + " * X + " + B + " = " + C);

            double X = (C - B) / A;
            Console.WriteLine("X = " + X);
        }

        static void Task6()
        {
            Console.Write("Enter X1 value: ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y1 value: ");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter X2 value: ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y2 value: ");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            
            double A = (Y2 - Y1)/(X2 - X1);
            Console.WriteLine("Equation of a straight line: " + Y1 + " = " + A + " * " + X1 + " + B");

            double B = Y1 - A * X1;
            Console.WriteLine("B = " + B);
        }

        static void Task7()
        {
            Console.Write("Enter N value: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int FirstDigit = N / 10;
            int SeccondDigit = N % 10;
            int SumDigits = FirstDigit + SeccondDigit;

            Console.WriteLine("The sum of the digits of N: " + SumDigits);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Task1();
            Console.WriteLine("Task 2:");
            Task2();
            Console.WriteLine("Task 3:");
            Task3();
            Console.WriteLine("Task 4:");
            Task4();
            Console.WriteLine("Task 5:");
            Task5();
            Console.WriteLine("Task 6:");
            Task6();
            Console.WriteLine("Task 7:");
            Task7();
        }
    }
}
