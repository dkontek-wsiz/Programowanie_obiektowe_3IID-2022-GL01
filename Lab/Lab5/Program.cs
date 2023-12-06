using Lab5.Bank;
using Lab5.Shapes;
using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad1();
        }

        static void Zad1()
        {
            Shape shape = new Circle(5);

            shape = new Square() { X = 2 };

            Console.WriteLine(shape.CalulateArea());
        }
    }
}
