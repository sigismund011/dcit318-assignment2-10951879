using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




// Abstract base class Shape
public abstract class Shape
{
    // Abstract method GetArea
    public abstract double GetArea();
}

// Derived class Circle
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

// Derived class Rectangle
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Circle and Rectangle
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        // Display their areas
        Console.WriteLine("Circle area: " + circle.GetArea());
        Console.WriteLine("Rectangle area: " + rectangle.GetArea());
    }
}
    
