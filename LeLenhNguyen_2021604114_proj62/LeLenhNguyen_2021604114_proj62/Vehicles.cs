// See https://aka.ms/new-console-template for more information

class Vehicles:IVehicle
{
    private string id, maker, model;
    private int year;
    public double price;
    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Maker
    {
        get { return maker; }
        set { maker = value; }

    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public Vehicles()
    {
        Id = "";
        Maker = "";
        Model = "";
        Year = 2000;
        Price = 0;
    }
    public Vehicles(string id)
    {
        Id = id;
    }
    public Vehicles(string id, string maker, string model, int year, double price)
    {
        Id = id;
        Maker = maker;
        Model = model;
        Year = year;
        Price = price;
    }

    public virtual void Input()
    {
        Console.WriteLine("-> Nhap thong tin:");
        Console.Write("Ma dinh danh: ");
        Id = Console.ReadLine();
        Console.Write("Hang san xuat: ");
        Maker = Console.ReadLine();
        Console.Write("Ten xe: ");
        Model = Console.ReadLine();
        Console.Write("Nam san xuat: ");
        Year = int.Parse(Console.ReadLine());
        Console.Write("Gia tien: ");
        Price = double.Parse(Console.ReadLine());
    }
    public virtual void Output()
    {
        Console.WriteLine("Ma dinh danh: " + Id);
        Console.WriteLine("Hang san xuat: " + Maker);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Nam san xuat: " + Year);
        Console.WriteLine("Gia tien: " + Price);
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        Vehicles vh = (Vehicles)obj;
        return Id.Equals(vh.Id);
    }
    public override string ToString()
    {
        return string.Format("{0,8}{1,15}{2,15}{3,12}{4,12}", Id, Maker, Model, Year, Price);
    }
}