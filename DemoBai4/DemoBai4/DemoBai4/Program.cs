namespace DemoBai4
{
    
    internal class Program
    {
       static private List<NhanVien> dsNhanVien= new List<NhanVien>();
        static void Main(string[] args)
        {
            //dữ liệu test
            //Khai báo, khởi tạo, gán giá trị cho đối tượng sử dụng p/t Nhap
            NhanVien nv1 = new NhanVien();
            nv1.Nhap("NV1", "Nguyen Van An", DateTime.Now, 1);
            //Khai báo, khởi tạo, gán giá trị cho đối tượng sử dụng constructor
            NhanVien nv2 = new NhanVien("NV2", "Hoa", DateTime.Now, 2);
            QuanLy ql1 = new QuanLy("ql1","Tran Duc Trung",DateTime.Now,2,1);
            QuanLy ql2 = new QuanLy("ql2", "Tran Duc Trung", DateTime.Now, 1, 1);
            dsNhanVien.Add(nv1);
            dsNhanVien.Add(nv2);
            dsNhanVien.Add(ql1);
            dsNhanVien.Add(ql2);
            QuanLy ql3 = new QuanLy("ql3", "A", DateTime.Now, 1, 4);
            dsNhanVien.Add(ql3);
            //-------------

            Console.Write("\nMAIN MENU");
            while (true)
            {
                Console.WriteLine("\n1.Them 1 nhan vien");
                Console.WriteLine("2.Hien thi danh sach nhan vien");
                Console.WriteLine("3.Sap xep");
                Console.WriteLine("4.Ket thuc");
                Console.Write("Nhap vao lua chon cua ban: ");
                string chose;
                chose = (Console.ReadLine());
                switch (chose)
                {
                    case "1":
                        NhapNhanVienMoi();
                        break;
                    case "2":
                        HienThiDanhSach();
                        break;
                    case "3":
                        dsNhanVien.Sort();
                        HienThiDanhSach();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Nhap sai lua chon. Vui long nhap lai!");
                        break;
                    
                }
            }

        }

        private static void HienThiDanhSach()
        {
            Console.WriteLine("\n{0,-15}{1,-20}{2,12:d}{3,15}{4,15}{5,15:N0}", "Ma nhan vien", "Ho ten", "Ngay sinh", "He so luong", "He so phu cap", "Luong");
            foreach (NhanVien item in dsNhanVien)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static void NhapNhanVienMoi()
        {
            Console.WriteLine("1.Nhan vien");
            Console.WriteLine("2. Quan ly");
            Console.Write("Nhap vao lua chon cua ban: ");
            string loaiNV = Console.ReadLine();
            switch (loaiNV)
            {
                case "1":
                    NhanVien nvMoi = new NhanVien();
                    Console.Write("Ma nhan vien: ");
                    nvMoi.MaNhanVien = Console.ReadLine();
                    if (dsNhanVien.Contains(nvMoi))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Đã có mã nhân viên này");
                        Console.ResetColor();
                        return;
                    }
                    Console.Write("Ho ten: ");
                    nvMoi.HoTenNhanVien = Console.ReadLine();
                    Console.Write("Ngay sinh: ");
                    nvMoi.NgaySinh =Convert.ToDateTime( Console.ReadLine());
                    Console.Write("He so luong: ");
                    nvMoi.HeSoLuong =double.Parse( Console.ReadLine());
                    //kiểm tra xem một nhân viên đã có trong ds chưa
                    dsNhanVien.Add(nvMoi);
                    break;
                case "2":
                    QuanLy qlMoi = new QuanLy();
                    Console.Write("Ma nhan vien: ");
                    qlMoi.MaNhanVien = Console.ReadLine();
                    if (dsNhanVien.Contains(qlMoi))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Đã có mã nhân viên này");
                        Console.ResetColor();
                        return;
                    }
                    Console.Write("Ho ten: ");
                    qlMoi.HoTenNhanVien = Console.ReadLine();
                    Console.Write("Ngay sinh: ");
                    qlMoi.NgaySinh = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("He so luong: ");
                    qlMoi.HeSoLuong = double.Parse(Console.ReadLine());
                    Console.Write("He so phu cap: ");
                    qlMoi.HeSoPhuCap = double.Parse(Console.ReadLine());
                    //kiểm tra xem một nhân viên đã có trong ds chưa
                    dsNhanVien.Add(qlMoi);
                    break;              
            }
        }
    }
}