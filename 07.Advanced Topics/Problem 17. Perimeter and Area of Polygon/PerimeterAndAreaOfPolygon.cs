using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of n
//floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. Use the
//input and output format from the examples. To hold the points, define a class Point(x, y). To hold the polygon use a Polygon
//class which holds a list of points. Find in Internet how to calculate the polygon perimeter and how to calculate the area of
//a polygon. 

namespace PerimeterAndAreaOfPolygon
{
    class Point
    {
        public double x;
        public double y;

        public Point(double X, double Y)
        {
            x = X;
            y = Y;
        }

        public double Distance(Point p2)
        {
            double x1 = this.x;
            double y1 = this.y;
            double x2 = p2.x;
            double y2 = p2.y;
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }

    class Polygon
    {
        List<Point> poly;
        int m;

        public Polygon(List<Point> polygon)
        {
            if (polygon.Count > 2)
            {
                this.poly = polygon;
                poly.Add(polygon[0]);
                m = poly.Count();
            }
            else
            {
                Console.WriteLine("Cannot make polygon with less than 3 points!");
            }
        }

        public double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < m - 1; i++)
            {
                Point p1 = poly[i];
                Point p2 = poly[i + 1];
                perimeter += p1.Distance(p2);
            }
            return perimeter;
        }

        public double Area()
        {
            double left = 0;
            double right = 0;
            for (int i = 0; i < m - 1; i++)
            {
                Point p1 = poly[i];
                Point p2 = poly[i + 1];
                left += p1.x * p2.y;
                right += p2.x * p1.y;
            }
            return Math.Abs(left - right) / 2;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Program that calculates the perimeter and the area of given polygon consisting of n floating-point coordinates in the 2D plane.");
            Console.Write("Write n = ");
            int n = int.Parse(Console.ReadLine());
            List<Point> listOfPoints = new List<Point>
            {
            };
            for (int i = 0; i < n; i++)
            {
                Console.Write("Write coordinates of point {0}: ", i + 1);
                string line = Console.ReadLine();
                string[] list = line.Split(' ');
                double x = double.Parse(list[0]);
                double y = double.Parse(list[1]);
                Point p = new Point(x, y);
                listOfPoints.Add(p);
            }
            Polygon polygon = new Polygon(listOfPoints);
            double perimeter = polygon.Perimeter();
            double area = polygon.Area();
            Console.WriteLine("perimeter = {0:0.00}", perimeter);
            Console.WriteLine("area = {0:0.00}", area);
        }
    }
}
