namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Letter letter1 = new Letter("AKDJK512", 20);
        Letter letter2 = new Letter("OSJGUK809", 10);

        Parcel parcel1 = new Parcel("HKFHS680", 50, "40x20x40");
        Parcel parcel2 = new Parcel("JGJGHI689", 70, "10x10x40");
        
        letter1.PrintInfo();
        parcel2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        
        Console.WriteLine($"The total cost of the items is: {myCargo.GetTotalCost()}");
        
    }
}