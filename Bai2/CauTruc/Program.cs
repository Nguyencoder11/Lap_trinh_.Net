using System;

namespace CauTruc
{
    struct HocSinh
    {
        public string HoTen;
        public int Tuoi;
        public bool GioiTinh;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HocSinh[] dsHocSinh = new HocSinh[5];

            // Nhap du lieu cho mang hoc sinh
            for(int i = 0; i < dsHocSinh.Length; i++)
            {
                Console.WriteLine($"Nhap thong tin hoc sinh thu {i+1}: ");
                Console.Write("Ho ten: ");
                dsHocSinh[i].HoTen = Console.ReadLine();
                Console.Write("Tuoi: ");
                dsHocSinh[i].Tuoi = int.Parse(Console.ReadLine());
                Console.Write("Gioi tinh (Nam/Nu): ");
                string gioiTinh = Console.ReadLine();
                dsHocSinh[i].GioiTinh = (gioiTinh.ToLower() == "nam") ? true : false;
            }

            // Tinh tong so tuoi cua 5 hs
            int tongTuoi = 0;
            for(int i = 0;i < dsHocSinh.Length; i++)
            {
                tongTuoi += dsHocSinh[i].Tuoi;
            }
            Console.WriteLine($"Tong so tuoi cua cac hoc sinh la: {tongTuoi}");
        }
    }
}
