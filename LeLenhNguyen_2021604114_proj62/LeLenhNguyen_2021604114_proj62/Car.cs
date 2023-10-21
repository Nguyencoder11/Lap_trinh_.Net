// See https://aka.ms/new-console-template for more information

class Car:Vehicles
{
    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public Car() : base() { 
        Color = "red";
    }
    public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
    {
        Color = color;
    }
    public override void Input()
    {
        base.Input();
        Console.Write("Mau sac: ");
        Color = Console.ReadLine();
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine("Mau sac: " + Color);
    }

    public override string ToString()
    {
        return base.ToString() + string.Format("{0,15}", Color);
    }
}
