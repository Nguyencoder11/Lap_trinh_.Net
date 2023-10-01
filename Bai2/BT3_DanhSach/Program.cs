// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;
List<string> ThanhPho = new List<string>();

// Them 5 thanh pho
ThanhPho.Add("Hà Nội");
ThanhPho.Add("Hồ Chí Minh");
ThanhPho.Add("Đà Nẵng");
ThanhPho.Add("Hải Phòng");
ThanhPho.Add("Cần Thơ");

// Sap xep danh sach thanh pho
ThanhPho.Sort();

Console.WriteLine("Danh sách thành phố đã sắp xếp:");
foreach (string thanhPho in ThanhPho)
{
    Console.WriteLine(thanhPho);
}

// Xoa thanh pho "Ha Noi"
ThanhPho.Remove("Hà Nội");

// Them 5 thanh pho khac
ThanhPho.Add("Đà Lạt");
ThanhPho.Add("Huế");
ThanhPho.Add("Nha Trang");
ThanhPho.Add("Vũng Tàu");
ThanhPho.Add("Phú Quốc");

Console.WriteLine("\nDanh sách thành phố sau khi thêm và xóa:");
foreach (string thanhPho in ThanhPho)
{
    Console.WriteLine(thanhPho);
}