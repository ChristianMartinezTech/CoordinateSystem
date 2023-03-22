using System;

namespace CoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opening Message
            Console.WriteLine("***");
            Console.WriteLine("Welcome! We will calculate a triangle dimensions");
            Console.WriteLine("***");

            // Enter point A coordinates
            Console.WriteLine("Enter Coordinate X of dot A:");
            double ax = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Coordinate Y of dot A:");
            double ay = Convert.ToDouble(Console.ReadLine());


            // Enter point B coordinates
            Console.WriteLine("Enter Coordinate X of dot B:");
            double bx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Coordinate Y of dot B:");
            double by = Convert.ToDouble(Console.ReadLine());


            // Enter point C coordinates
            Console.WriteLine("Enter Coordinate X of dot C:");
            double cx = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Coordinate Y of dot C:");
            double cy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Point A: {0},{1}", ax, ay);
            Console.WriteLine("Point B: {0},{1}", bx, by);
            Console.WriteLine("Point C: {0},{1}", cx, cy);


            // Calculating Triangle sides
            // GOTTA MAKE THIS A METHOD
            // Length of AB
            double lenghtAB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            Console.WriteLine("Lenght of AB is: {0}", lenghtAB);

            // Length of BC
            double lenghtBC = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            Console.WriteLine("Lenght of BC is: {0}", lenghtBC);

            // Length of AC
            double lenghtAC = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
            Console.WriteLine("Lenght of AC is: {0}", lenghtAC);






            // Debugger
            Console.WriteLine("Say smthng:");
            string smthng = Console.ReadLine();
            Console.WriteLine(smthng);
        }
    }
}
