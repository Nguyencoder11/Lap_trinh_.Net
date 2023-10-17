// See https://aka.ms/new-console-template for more information

class Student:Person
{
    private byte maths;
    private byte physics;
    public Student():base()
    {
        maths = 0;
        physics = 0;
    }

    public Student(int id, string name, string address, byte maths, byte physics) : base(id, name, address)
    {
        this.maths = maths;
        this.physics = physics;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Nhập điểm Toán: ");
        maths = byte.Parse(Console.ReadLine());
        Console.Write("Nhập điểm Lý: ");
        physics = byte.Parse(Console.ReadLine());
    }

    public override void Output() 
    {
        base.Output();
        Console.Write("{0,12}{1,12}{2,12}\n", maths, physics, this.Total());
    }

    public int Total()
    {
        return maths + physics;
    }
}