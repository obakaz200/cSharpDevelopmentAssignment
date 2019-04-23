using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Point X");
            bool success = int.TryParse(Console.ReadLine(), out int a);
            if (success) Console.WriteLine("Input Point Y");
            bool good = int.TryParse(Console.ReadLine(), out int b);
            if (good) Console.WriteLine("Input Point Z");
            bool nice = int.TryParse(Console.ReadLine(), out int c);
            if (nice) Console.WriteLine("Input Point X2");

            
            bool successs = int.TryParse(Console.ReadLine(), out int d);
            if (successs) Console.WriteLine("Input Point Y2");
            bool goods = int.TryParse(Console.ReadLine(), out int e);
            if (goods) Console.WriteLine("Input Point Z2");
            bool nices = int.TryParse(Console.ReadLine(), out int f);
            Point pt1 = new Point(a, b, c);
            Point pt2 = new Point(d, e, f);

            Point rt = pt1.Add(pt2);
            double r = pt1.Distance(pt2);
            if (nice) Console.WriteLine($"Addition of Points is:{rt}");
            if (nice) Console.WriteLine($"The distance between the two Points is:{r}");



            Point set1 =new Point (10,0,0);
            Point set2 = new Point (10, 20, 30); 
            Point set3 = new Point (10, 20, 30);
            Point result = set1.Add(set2).Add(set3);
            Point result1 = set1.Mul(set2).Mul(set3);
            Point result2 = set1.Sub(set2).Sub(set3);
            Console.WriteLine($"Addition is:{result} \nMultipication is:{result1} \nSubtraction is:{result2}");
            Console.ReadLine();
        }
        public struct Point
        {
            int X { get; set; }
            int Y { get; set; }
            int Z { get; set; }

            public Point(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
            public Point(int x)
            {
                X = x;
                Y = 0;
                Z = 0;
            }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
                Z = 0;
            }
            public double Distance(Point pt)
            {
               double b = Math.Sqrt((Math.Pow((X - pt.X), 2)+ Math.Pow((Y - pt.Y), 2) + Math.Pow((Z - pt.Z), 2)));
                return b;
            }
            public Point Add(Point pt)
            {
                return new Point(X + pt.X, Y + pt.Y, Z + pt.Z);
            }
            public Point Mul(Point pt)
            {
                return new Point(X * pt.X, Y * pt.Y, Z * pt.Z);
            }
            public Point Sub(Point pt)
            {
                return new Point(X - pt.X, Y - pt.Y, Z - pt.Z);
            }
            public override string ToString()
            {
                return $"(X:{X}, Y:{Y}, Z:{Z})";
            }
        }
     }
}
