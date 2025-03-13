namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle("Rectangle", 20, 10);
            r.Display();

            Console.WriteLine();

            Circle c = new Circle("Circle", 8);
            c.Display();
        }
    }
}
