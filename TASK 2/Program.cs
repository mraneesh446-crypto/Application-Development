namespace TASK_2;

class Program
{
    static void Main(string[] args)
    {
        // Uncomment this line to see the compilation error:
        // Circle.PI = 3.14159;
        // PI is a constant, so its value cannot be changed after declaration.

        double radius = 5;
        Console.WriteLine($"Circle area: {Circle.CalculateArea(radius):F2}");
        Console.WriteLine($"Circle perimeter: {Circle.CalculatePerimeter(radius):F2}");
    }
}

class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius) => PI * radius * radius;

    public static double CalculatePerimeter(double radius) => 2 * PI * radius;
}
