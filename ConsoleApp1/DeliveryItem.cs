namespace ConsoleApp1;

public abstract class DeliveryItem
{
    public string TrackingNumber { get;  }
    public double Weight { get; }

    public DeliveryItem(string trackingNumber, double weight)
    {
        this.TrackingNumber = trackingNumber;
        this.Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"The track number is: {TrackingNumber} and the weight is: {Weight}");
    }
}