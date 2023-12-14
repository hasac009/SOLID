// Базовий клас
public class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

// Похідний клас - Коло
public class Circle : Shape
{
    private readonly double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}

// Похідний клас - Квадрат
public class Square : Shape
{
    private readonly double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }
}
