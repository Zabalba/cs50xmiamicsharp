using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class HW2_1
    {
        static void Main(string[] args)
        {

            Circle c1 = new Circle(5, 5);
            Circle c2 = new Circle(5, 5);
            Circle c3 = new Circle(6, 6);
            Rectangle r1 = new Rectangle(5, 5);
            Rectangle r2 = new Rectangle(5, 5);

            //returns true
            Console.WriteLine(c1.Equals(c2));

            //returns false
            c1.Height = 10;
            Console.WriteLine(c1.Equals(c2));

            //returns false
            Console.WriteLine(c3.Equals(c2));

            //returns false
            Console.WriteLine(r1.Equals(c2));

            //returns true
            Console.WriteLine(r1.Equals(r2));

            Console.ReadKey();
        }
    }


    public class Circle : Shape
    {
        public Circle(double width, double height)
        {
            Width = width;
            Height = width;
            _type = "Circle";
        }
        public override double CalculateArea()
        {
            return (Width * Height) * Math.PI;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            _type = "Rectangle";
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Type { get { return _type; } }
        protected string _type = "Undefined";

        public abstract double CalculateArea();
        public override string ToString()
        {
            return Type.ToString();
        }
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
                return false;

            Shape inc = (Shape)obj;
            return (_type.Equals(inc._type, StringComparison.OrdinalIgnoreCase)
                    && Width == inc.Width
                    && Height == inc.Height);
        }

    }
}
