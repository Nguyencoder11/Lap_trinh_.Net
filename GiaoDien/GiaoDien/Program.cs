using System;
using System.Collections.Generic;
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
            
        }

        private static void SapXepTheoModel()
        {
            
        }

        private static void TimKiemTheoMaker()
        {
            
        }

        private static void TimKiemTheoId()
        {
            
        }

        private static void HienThiDuLieu()
        {
            
        }

        private static void NhapDuLieu()
        {
            try {
                Console.WriteLine("Nhập thông tin xe:");
                Console.Write("Biển số: ");
                string id = Console.ReadLine();
                Console.Write("Hãng sản xuất: ");
                string maker = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Năm sản xuất: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Loại xe: ");
                string type = Console.ReadLine();

                if (type == "Xe chở người")
                {
                    Console.Write("Sỗ chỗ ngồi: ");
                    int seat = int.Parse(Console.ReadLine());
                    vehicleLists.Add(new Car(id, maker, model, year, type, seat));
                    Console.WriteLine("Xe chở người đã được thêm vào danh sách");
                }
                else if (type == "Xe tải")
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

            // int currentYear = DateTime.Now.Year;
        }
    }
}

