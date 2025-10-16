using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please select:");
            Console.WriteLine("Circle=1");
            Console.WriteLine("Moraba=2");
            Console.WriteLine("Mostatil=3");
            int select = int.Parse(Console.ReadLine());
            Shape shape;
            switch (select)
            {
                case 1:
                    shape = new Circle();
                    break;
                case 2:
                    shape = new Moraba();
                    break;
                case 3:
                    shape = new Mostatil();
                    break;
                default: Console.WriteLine("Not valid");
                   
                    return;
            }
            shape.Input();
            Console.WriteLine("Please select:");
            Console.WriteLine("Mohit=1");
            Console.WriteLine("Masahat=2");
            Console.WriteLine("Both=3");
            int selectMethod = int.Parse(Console.ReadLine());
            switch (selectMethod)
            {
                case 1: Console.WriteLine($"Mohit is {shape.mohit()}");
                    break;
                case 2:
                    Console.WriteLine($"Masahat is {shape.masahat()}");
                    break;
                case 3:
                    Console.WriteLine($"Mohit is {shape.mohit()} and Masahat is {shape.masahat()}");
                    break;
                default: Console.WriteLine("Not valid");
                    return;
            }
        }
    }
}
