namespace ConsoleApp1;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> DeliveryItems = new List<T>();
    private double totalCost = 0;

    public void AddItem(T item)
    {
        DeliveryItems.Add(item);
    }

    public double GetTotalCost()
    {
        totalCost = 0;
        foreach (T element in DeliveryItems)
        {
            totalCost += element.CalculateCost();
        }

        return totalCost;
    }
    
        

}