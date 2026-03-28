namespace ConsoleApp1;

public class Letter: DeliveryItem
{
    public Letter(string trackingnumber, double weight) : base(trackingnumber, weight)
    {
        
    }

    public override double CalculateCost()
    {
        return (15 + (Weight + 10));
    }
}