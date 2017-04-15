using System;
using Triangle;

namespace TriangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sides = new double[3];
            Console.WriteLine("Enter 3 sides:");
            Console.Write("A: ");
            while(!Double.TryParse(Console.ReadLine(), out sides[0]))
            {
                Console.WriteLine("Invalid input");
                Console.Write("A: ");
            }
            Console.Write("B: ");
            while (!Double.TryParse(Console.ReadLine(), out sides[1]))
            {
                Console.WriteLine("Invalid input");
                Console.Write("B: ");
            }
            Console.Write("C: ");
            while (!Double.TryParse(Console.ReadLine(), out sides[2]))
            {
                Console.WriteLine("Invalid input");
                Console.Write("C: ");
            }
            try
            {
                if (TriangleUtils.IsTriangle(sides))
                    Console.WriteLine($"There exists a triangle with sides: {sides[0]} {sides[1]} {sides[2]}.");
                else
                {
                    Console.WriteLine($"There is no triangle with sides: {sides[0]} {sides[1]} {sides[2]}.");
                    Console.ReadKey();
                    return;
                }
                if (TriangleUtils.IsEquilateral(sides))
                    Console.WriteLine("Triangle is equilateral.");
                else if (TriangleUtils.IsRightAngled(sides))
                    Console.WriteLine("Triangle is right-angled.");
                else if (TriangleUtils.IsSharpAngled(sides))
                    Console.WriteLine("Triangle is sharp-angled.");
                else
                    Console.WriteLine("Triangle is blunt-angled.");
                Console.WriteLine($"Triangle has {TriangleUtils.EqualSideCount(sides)} equal sides.");
            } catch (ArgumentException e)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}