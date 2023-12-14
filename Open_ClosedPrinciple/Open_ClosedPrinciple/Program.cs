// Приклад використання принципу відкритості/закритості в C#
// Базовий клас або інтерфейс
public abstract class Shape
{
    public abstract double Area(); // Метод, що розраховує площу фігури
}

// Похідний клас, який розширює базовий клас
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius; // Формула для площі кола
    }
}

// Інший похідний клас, який розширює базовий клас
public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double Area()
    {
        return length * width; // Формула для площі прямокутника
    }
}

