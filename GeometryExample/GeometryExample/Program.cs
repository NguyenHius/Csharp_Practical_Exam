using GeometryExample.Models;

class Program
{
    static void Main(string[] args)
    {
        Cylinder cylinder = new Cylinder();

        Console.Write("Enter Radius: ");
        cylinder.Radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height: ");
        cylinder.Height = Convert.ToDouble(Console.ReadLine());

        cylinder.Process();
        cylinder.Result();

        Console.WriteLine("\n===========================\n");
    }
}