using System;

namespace Homework1
{
    class Program
    {
        static int ConvertHoursToMinutes(int numHours)
        {
            return numHours * 60;
        }

        static double CalculateEquation(double a, double b)
        {
            return (5 * a + b * b) / (b - a);
        }

        static void Swap(ref string a, ref string b)
        {
            string swap = a;
            a = b;
            b = swap;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }    

        static int DivideRemind(int a, int b)
        { 
            return a % b;
        }

        static double CalculateLinearEquation(double a, double b, double c)
        {
            return (c - b) / a;
        }

        static string MakeStraightLineEquation(double x1, double y1, double x2, double y2)
        {            
            double a = (y2 - y1)/(x2 - x1);
            return ("Equation of a straight line: " + y1 + " = " + a + " * " + x1 + " + B");
        }

        static int CalculateSumOfDigits(int n)
        {

            int FirstDigit = n / 10;
            int SeccondDigit = n % 10;
            return FirstDigit + SeccondDigit;
        }

        static void Main(string[] args)
        {
            string a = "Hello ";
            string b = "World ";
            Console.WriteLine("Task 1: " + ConvertHoursToMinutes(4));

            Console.WriteLine("Task 2: " + CalculateEquation(3, 5));

            Swap(ref a, ref b);
            Console.WriteLine("Task 3: " + a + b);

            Console.WriteLine("Task 4: " + Divide(6, 4) + 
                Environment.NewLine + DivideRemind(6, 4));
            Console.WriteLine("Task 5: " + CalculateLinearEquation(2, 3, 7));
            Console.WriteLine("Task 6: " + MakeStraightLineEquation(5, 2, 8, 10));
            Console.WriteLine("Task 7: " + CalculateSumOfDigits(25));
        }
    }
}
