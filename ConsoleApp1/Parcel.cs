namespace ConsoleApp1;

public class Parcel: DeliveryItem
{
    public string Dimensions { get; private set; }

    public Parcel(string trackingnumber, double weight, string dimensions = "30x20x15") : base(trackingnumber, weight)
    {
        this.Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return (50 + (Weight + 25));
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"The dimensions are {Dimensions}");
    }
}