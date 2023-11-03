using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;

namespace GiaoDien
{
    class Program
    {
        static List<Vehicles> vehicleLists = new List<Vehicles>();
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. Hiển thị dữ liệu");
                Console.WriteLine("3. Tìm kiếm theo id");
                Console.WriteLine("4. Tìm kiếm theo maker");
                Console.WriteLine("5. Sắp xếp theo model");
                Console.WriteLine("6. Sắp xếp theo year");
                Console.WriteLine("7. Kết thúc");

                Console.Write("Nhập lựa chọn (1-7): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        NhapDuLieu();
                        break;
                    case "2":
                        HienThiDuLieu();
                        break;
                    case "3":
                        TimKiemTheoId();
                        break;
                    case "4":
                        TimKiemTheoMaker();
                        break;
                    case "5":
                        SapXepTheoModel();
                        break;
                    case "6":
                        SapXepTheoYear();
                        break;
                    case "7":
                        Console.WriteLine("Đã thoát chương trình");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không phù hợp. Vui lòng chọn lại.");
                        break;
                }
            }
        }

        private static void SapXepTheoYear()
        {
            vehicleLists.Sort((v1, v2) => v1.Year.CompareTo(v2.Year));
            Console.WriteLine("Danh sách các phương tiện được sắp xếp theo năm");
            foreach(Vehicles v in vehicleLists)
            {
                Console.WriteLine(v.ToString());
            }
        }

        private static void SapXepTheoModel()
        {
            vehicleLists.Sort((v1, v2) => v1.Model.CompareTo(v2.Model));
            Console.WriteLine("Danh sách các phương tiện được sắp xếp theo model");
            foreach (Vehicles v in vehicleLists)
            {
                Console.WriteLine(v.ToString());
            }
        }

        private static void TimKiemTheoMaker()
        {
            Console.Write("Nhập NSX: ");
            string maker = Console.ReadLine();
            int foundMaker = 0;

            foreach(var  vehicle in vehicleLists)
            {
                if(vehicle!=null && vehicle.Maker == maker)
                {
                    Console.WriteLine(vehicle.ToString());
                    foundMaker++;
                }
            }
            if (foundMaker == 0)
            {
                Console.WriteLine("Không tìm thấy phương tiện sản xuất bởi " + maker);
            }
        }

        private static void TimKiemTheoId()
        {
            Console.Write("Nhập id: ");
            string id = Console.ReadLine();
            bool foundId = false;
            foreach(var vehicle in vehicleLists)
            {
                if(vehicle != null && vehicle.Id == id)
                {
                    Console.WriteLine(vehicle.ToString());
                    foundId = true;
                    break;
                }
            }
            if (!foundId)
            {
                Console.WriteLine("Không tìm thấy phương tiên có id " + id);
            }

        }

        private static void HienThiDuLieu()
        {
            Console.WriteLine("Danh sách các phương tiện:");
            Console.WriteLine("{0,10}{1,15}{2,15}{3,12}{4,15}{5,12}{6,12}{7,15}", "Biển số", "Hãng sản xuất", "Model", "Năm SX", "Loại xe", "Số chỗ", "Tải trọng", "Niên hạn SD");
            foreach(Vehicles vehicle in vehicleLists)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        private static void NhapDuLieu()
        {
            try {
                Console.WriteLine("Nhập thông tin xe:");
                Console.Write("Biển số: ");
                string id = Console.ReadLine();
                if (vehicleLists.Exists(v => v.Id == id))
                {
                    Console.WriteLine("Biển số đã tồn tại. Vui lòng nhập biển số khác");
                    return;
                }
                Console.Write("Hãng sản xuất: ");
                string maker = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Năm sản xuất: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Loại xe: ");
                string type = Console.ReadLine();

                if (type.ToLower() == "Xe chở người".ToLower())
                {
                    Console.Write("Sỗ chỗ ngồi: ");
                    int seat = int.Parse(Console.ReadLine());
                    vehicleLists.Add(new Car(id, maker, model, year, type, seat));
                    Console.WriteLine("Xe chở người đã được thêm vào danh sách");
                }
                else if (type.ToLower() == "Xe tải".ToLower())
                {
                    Console.Write("Tải trọng: ");
                    double loaded = double.Parse(Console.ReadLine());
                    vehicleLists.Add(new Truck(id, maker, model, year, type, loaded));
                    Console.WriteLine("Xe tải đã được thêm vào danh sách");
                }
                else
                {
                    vehicleLists.Add(new Vehicles(id, maker, model, year, type));
                    Console.WriteLine("Xe đã được thêm vào danh sách");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Dữ liệu nhập không đúng định dạng");
            }
        }
    }
}

