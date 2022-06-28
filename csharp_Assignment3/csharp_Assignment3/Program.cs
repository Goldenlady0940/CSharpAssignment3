namespace csharp_Assignment3
{
    abstract class Shape
    {
        public abstract double area();
        public abstract double perimeter();
    }
    class Circle : Shape
    {
        static readonly double PI = 3.14;
        public int radius { get; set; }
        public override double area()
        {
            return (PI * radius * radius);
        }

        public override double perimeter()
        {
            return (2 * PI * radius);
        }
    }
    class Rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public override double area()
        {
           return (length * width);
        }

        public override double perimeter()
        {
            return (2 * (length + width));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();

            Console.WriteLine("Enter radius of the circle");
            c.radius = int.Parse(Console.ReadLine());
            Console.WriteLine("The area of the circle is: " + c.area());
            Console.WriteLine("The perimeter of the circle is: " + c.perimeter());

            Rectangle r = new Rectangle();
            Console.WriteLine();
            Console.WriteLine("Enter length of the rectangle");
            r.length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of the rectangle");
            r.width = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is: " + r.area());
            Console.WriteLine("The perimeter of the rectangle is: " + r.perimeter());

        }
    }
}
