// See https://aka.ms/new-console-template for more information

class Person
{
    private int id;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string name;
    private string address;
    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public Person()
    {
        id = 0;
        name = "";
        address = "";
    }

    public Person(int id, string name, string address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }

    public virtual void Input()
    {
        Console.WriteLine("Nhập thông tin:");
        Console.Write("ID: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Họ tên: ");
        name = Console.ReadLine();
        Console.Write("Địa chỉ: ");
        address = Console.ReadLine();
    }

    public virtual void Output()
    {
        Console.Write("{0,8}{1,20}{2,20}", id, name, address);
    }
}