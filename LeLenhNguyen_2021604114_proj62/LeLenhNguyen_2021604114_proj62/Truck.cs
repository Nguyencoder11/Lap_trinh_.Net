// See https://aka.ms/new-console-template for more information

using System.Drawing;

class Truck:Vehicles
{
    private int truckload;
    public int TruckLoad
    {
        get { return truckload; }
        set { truckload = value; }
    }
    public Truck() : base() 
    {
        TruckLoad = 0;
    }

    public Truck(string id, string maker, string model, int year, double price, int truckload):base(id, maker, model, year, price)
    {
        TruckLoad = truckload;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Tai trong: ");
        TruckLoad = int.Parse(Console.ReadLine());
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine("Tai trong: " + TruckLoad);
    }

    public override string ToString()
    {
        return base.ToString() + string.Format("{0,15}", TruckLoad);
    }
}