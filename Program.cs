using System;

namespace MyNamespace 
{
    internal class Program
    {
        double length;
        double width;

        public Program(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + GetArea());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width:");
            double width = double.Parse(Console.ReadLine());

            Program program = new Program(length, width);
            program.Display();
        }
    }
}
