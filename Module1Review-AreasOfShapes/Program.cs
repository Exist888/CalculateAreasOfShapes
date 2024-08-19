namespace Module1Review_AreasOfShapes;

class Program
{
    static void Main(string[] args)
    {
        
        //Prompt User for Circle Radius, Will Calculate Area in Later Method:
        Console.WriteLine("\n" +
                          "Enter the radius of a circle:");
        CircleArea(double.Parse(Console.ReadLine()));
        
        
        //Prompt User for Triangle Length & Height, Will Calculate Area in Later Method:
        Console.WriteLine("\n" +
                          "Enter the base length of a triangle,\n" +
                          "then enter the height of the triangle:");
        TriangleArea(double.Parse(Console.ReadLine()), 
                         double.Parse(Console.ReadLine()));
        
        
        //Prompt User for Rectangle Length & Width, Will Calculate Area in Later Method:
        Console.WriteLine("\n" +
                          "Enter the length of a rectangle,\n" +
                          "then enter the width of the rectangle:");
        RectangleArea(double.Parse(Console.ReadLine()), 
                       double.Parse(Console.ReadLine()));
        
        
        //Prompt User for Square Side Length, Will Calculate Area in Later Method:
        Console.WriteLine("\n" +
                          "Enter the side of a square:");
        SquareArea(double.Parse(Console.ReadLine()));
        
    }

    
    //Calculate, Print, & Return Circle Area:
    public static double CircleArea(double radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"A circle with a radius of {radius}\n" +
                          $"    will have an area of {area}.");
        return area;
    }

    
    //Calculate, Print, & Return Triangle Area:
    public static double TriangleArea(double baseLength, double height)
    {
        double area = (baseLength * height) / 2;
        Console.WriteLine($"A triangle with a base length of {baseLength} and a height of {height}\n" +
                          $"    will have an area of {area}.");
        return area;
    }

    
    //Calculate, Print, & Return Rectangle Area:
    public static double RectangleArea(double length, double width)
    {
        double area = (length * width);
        Console.WriteLine($"A rectangle with a length of {length} and a width of {width}\n" +
                          $"    will have an area of {area}.");
        return area;
    }


    //Calculate, Print, & Return Square Area:
    public static double SquareArea(double side)
    {
        double area = (side * side);
        Console.WriteLine($"A square with a side length of {side}\n" +
                          $"    will have an area of {area}.");
        return area;
    }
    
}

