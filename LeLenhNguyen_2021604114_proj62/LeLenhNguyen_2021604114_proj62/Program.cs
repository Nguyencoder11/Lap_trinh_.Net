// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection;
using System;

List<Vehicles> vehiclesList = new List<Vehicles>();

while (true)
{
    Console.WriteLine("======= MENU =======");
    Console.WriteLine("1. Nhap du lieu");
    Console.WriteLine("2. Hien thi du lieu");
    Console.WriteLine("3. Tim kiem theo id");
    Console.WriteLine("4. Tiem kiem theo maker");
    Console.WriteLine("5. Sap xep theo price");
    Console.WriteLine("6. Sap xep theo year");
    Console.WriteLine("7. Ket thuc");
    try
    {
        Console.Write("Nhap vao lua chon: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                NhapCarsAndTrucks();
                break;
            case "2":
                HienThiCarsAndTrucks();
                break;
            case "3":
                TimKiemTheoId();
                break;
            case "4":
                TimKiemTheoMaker();
                break;
            case "5":
                SapXepTheoPrice();
                break;
            case "6":
                SapXepTheoYear();
                break;
            case "7":
                Console.WriteLine("Da thoat chuong trinh!");
                return;
            default:
                Console.WriteLine("Lua chon khong phu hop. Vui long nhap lai lua chon tu menu ben duoi");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

void SapXepTheoPrice()
{
    vehiclesList.Sort((vehicle1, vehicle2) => vehicle1.Price.CompareTo(vehicle2.Price));
    HienThiCarsAndTrucks();
}

void SapXepTheoYear()
{
    vehiclesList.Sort((vehicle1, vehicle2) => vehicle1.Year.CompareTo(vehicle2.Year));
    HienThiCarsAndTrucks();
}

void TimKiemTheoMaker()
{
    Console.Write("Nhap hang san xuat can tim: ");
    string searchMaker = Console.ReadLine();
    bool found = false;
    foreach (var vehicle in vehiclesList)
    {
        if (vehicle != null && vehicle.Maker == searchMaker)
        {
            Console.WriteLine(vehicle.ToString());
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine($"Khong tim duoc phuong tien co ma dinh danh {searchMaker}");
    }
}

void TimKiemTheoId()
{
    Console.Write("Nhap ID can tim: ");
    string searchId = Console.ReadLine();
    bool found = false;
    foreach (var vehicle in vehiclesList)
    {
        if(vehicle != null && vehicle.Id == searchId)
        {
            Console.WriteLine(vehicle.ToString());
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine($"Khong tim duoc phuong tien co ma dinh danh {searchId}");
    }
}

void HienThiCarsAndTrucks()
{
    Console.WriteLine("{0,8}{1,15}{2,15}{3,12}{4,12}", "Ma ID", "Hang san xuat", "Mau xe", "Nam sx", "Gia tien");
    foreach (var vehicle in vehiclesList)
    {
        Console.WriteLine(vehicle.ToString());
    }
}

void NhapCarsAndTrucks()
{
    Console.WriteLine("1. Nhap cho Cars");
    Console.WriteLine("2. Nhap cho Trucks");
    int vehicleChoice = Convert.ToInt32(Console.ReadLine());

    if(vehicleChoice == 1)
    {
        for(int i = 0; i < 3; i++)
        {
            Car car = new Car();
            car.Input();
            vehiclesList.Add(car);
        }
    }
    else if(vehicleChoice == 2)
    {
        for(int i = 0; i < 3; i++)
        {
            Truck truck = new Truck();
            truck.Input();
            vehiclesList.Add(truck);
        }
    }
}