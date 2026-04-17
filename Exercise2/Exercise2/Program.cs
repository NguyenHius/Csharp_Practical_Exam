using Exercise2;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion(190.5, "Simba");
        Tiger tiger = new Tiger(220.3, "Sheru");

        lion.Show();
        tiger.Show();
    }
}