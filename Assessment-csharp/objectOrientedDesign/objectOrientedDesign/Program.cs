using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TASK-10

namespace objectOrientedDesign
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract string properties();
    }
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive");
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string properties()
        {
            return $"Circle - Radius: {radius}, Area: {Area()}, Perimeter: {Perimeter()}";
        }
    }
    public class Rectangle : Shape
    { 
        private double width;
        private double length;
        public Rectangle(double width, double length)
        {
            if (width <= 0 || length <= 0) {
                Console.WriteLine("Enter positive values");
            }
            this.width = width;
            this.length = length;
        }
        public override double Area() 
        { 
            return width * length;
        }
        public override double Perimeter()
        {
            return 2 * length*width;
        }
        public override string properties() 
        {
            return $"Rectangle-Length : {length} , width : {width} Area : {Area()} ,perimeter {Perimeter()}";
        }
    }
    public class Triangle : Shape
    { 
        private double side1,side2,side3;
        public Triangle(double side1,double side2,double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("enter positive values");
            }
            if (!(side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2)) 
            {
              throw new  ArgumentException("sum of any two side must greater than 3 rd side");
            } 
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double Area() { 
            double semiPerimeter=(side1+side2+side3)/2;
            double area=Math.Sqrt(semiPerimeter*(semiPerimeter-side1)*(semiPerimeter-side2)*(semiPerimeter-side3));
            return area;
        }
        public override double Perimeter() 
        {
            return side1 + side2 + side3;
        }
        public override string properties()
        {
            return $"Trangle - Sides {side3},{side2},{side3} and Area : {Area()} , Perimeter {Perimeter()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle= new Circle(5);
            Rectangle rectangle = new Rectangle(10, 10);
            Triangle triangle = new Triangle(20, 20, 10);

            Console.WriteLine(circle.properties());
            Console.WriteLine(rectangle.properties());   
            Console.WriteLine(triangle.properties());
            
        }
    }
}
