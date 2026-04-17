namespace GeometryExample.Models;

public class Cylinder
{
    public double Radius { get; set; }
    public double Height { get; set; }

    private double BaseArea;
    private double LateralArea;
    private double TotalArea;
    private double Volume;

    public void Process()
    {
        BaseArea = Radius * Radius * Math.PI;
        LateralArea = 2 * Math.PI * Radius * Height;
        TotalArea = 2 * Math.PI * Radius * (Height + Radius);
        Volume = Math.PI * Radius * Radius * Height;
    }

    public void Result()
    {
        Console.WriteLine("===== CYLINDER RESULT =====");
        Console.WriteLine($"Base Area: {BaseArea:F2}");
        Console.WriteLine($"Lateral Area: {LateralArea:F2}");
        Console.WriteLine($"Total Area: {TotalArea:F2}");
        Console.WriteLine($"Volume: {Volume:F2}");
    }
}