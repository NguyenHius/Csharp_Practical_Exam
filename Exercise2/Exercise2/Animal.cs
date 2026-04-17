namespace Exercise2;

public class Animal
{
    protected double weight;
    protected string name;

    public void SetMe(double weight, string name)
    {
        this.weight = weight;
        this.name = name;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}, Weight: {weight}");
    }
}