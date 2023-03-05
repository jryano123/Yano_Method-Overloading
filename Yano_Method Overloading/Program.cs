using System;

public class Shape
{
    public virtual double Area()
    {
        return 0;
    }

    public virtual double Perimeter()
    {
        return 0;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
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

    public double Area(double newRadius)
    {
        return Math.PI * newRadius * newRadius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        Console.WriteLine("Shape area: " + shape.Area());

        Circle circle1 = new Circle(5);
        Console.WriteLine("Circle area: " + circle1.Area());
        Console.WriteLine("Circle perimeter: " + circle1.Perimeter());

        Circle circle2 = new Circle(3);
        Console.WriteLine("Circle area with new radius: " + circle2.Area(4));