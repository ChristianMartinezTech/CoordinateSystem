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
            
            Console.WriteLine();
            Console.WriteLine("Point A: {0},{1}", ax, ay);
            Console.WriteLine("Point B: {0},{1}", bx, by);
            Console.WriteLine("Point C: {0},{1}", cx, cy);


            // Calculating Length of AB
            Console.WriteLine();
            double lenghtAB = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            Console.WriteLine("Lenght of AB is: {0}", lenghtAB);

            // Calculating Length of BC
            double lenghtBC = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            Console.WriteLine("Lenght of BC is: {0}", lenghtBC);

            // Calculating Length of AC
            double lenghtAC = Math.Sqrt(Math.Pow(cx - ax, 2) + Math.Pow(cy - ay, 2));
            Console.WriteLine("Lenght of AC is: {0}", lenghtAC);
            Console.WriteLine();


            // Calculating Equilateral
            Console.WriteLine();
            if ((lenghtAB == lenghtBC) && (lenghtBC == lenghtAC) && (lenghtAC == lenghtAB))
            {
                Console.WriteLine("Triangle is Equilateral");
            } else
            {
                Console.WriteLine("Triangle is NOT Equilateral");
            }
            Console.WriteLine();


            // Calculating Isosceles
            if ((lenghtAB == lenghtBC) || (lenghtBC == lenghtAC) || (lenghtAB == lenghtAC))
            {
                Console.WriteLine("Triangle is Isosceles");
            } else
            {
                Console.WriteLine("Triangle is NOT Isosceles");
            }
            Console.WriteLine();


            // Calculating Rightness
            if ((ax == bx) && (ay == cy))
            {
                Console.WriteLine("Triangle is Right");
            }
            else
            {
                Console.WriteLine("Triangle is NOT Right");
            }
            Console.WriteLine();


            // Calculating Permeter
            double perimeter = lenghtAB + lenghtBC + lenghtAC;
            Console.WriteLine("Perimeter is: {0}", perimeter);
            Console.WriteLine();


            // Even numbers up to parameter
            for (int i = 0; i < Convert.ToInt32(perimeter); i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            // Keeping the console open
            string openedWindow = Console.ReadLine();
        }
    }
}
