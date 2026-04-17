namespace Exercise2;

public class Lion : Animal
{
    public Lion(double weight, string name)
    {
        SetMe(weight, name);
    }

    public override void Show()
    {
        Console.WriteLine("Lion:");
        base.Show();
    }
}