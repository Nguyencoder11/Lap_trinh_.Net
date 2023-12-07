using Bai12_Nguyen114_P1.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Bai12_Nguyen114_P1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        // Khai báo
        private QlbhContext db1;

        public string TenDangNhap { get; set; }
        public string SoDt { get; set; }
        public string MaHd { get; private set; }
        public DateTime NgayLap { get; private set; }
        public KhachHang? MaKh { get; private set; }
        public string NguoiLap { get; private set; }

        public Window2(string tenDangNhap, QlbhContext dbContext)
        {
            InitializeComponent();

            // Sau khi click vào button "Đăng nhập" trên giao diện MainWindow
            TenDangNhap = tenDangNhap;  // hiển thị tên đăng nhập đã nhập và đã tồn tại trong csdl
            txtHoaDonTenDangNhap.Text = TenDangNhap;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");  // hiển thị ngày lập là ngày hiện tại của hệ thống

            // Lưu đối tượng QlbhContext
            db1 = dbContext;

            txtSdtKH.KeyUp += txtSdtKH_KeyUp;   // Gán sự kiện KeyUp cho TextBox số điện thoại
            txtMaHang.KeyUp += txtMaH_KeyUp;    // Gán sự kiện KeyUp cho TextBox Mã hàng
        }

        private void txtSdtKH_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string phoneNum = txtSdtKH.Text;
                if (int.TryParse(phoneNum, out int number))
                {
                    // Tìm thông tin khách hàng có số điện thoại nhập vào trong csdl
                    var khachhang = db1.KhachHangs.SingleOrDefault(dt => dt.SoDt == phoneNum);
                    if (khachhang != null)
                    {
                        // Hiển thị tên khách hàng lên TextBox Họ tên khách hàng
                        txtHoTenKH.Text = khachhang.TenKh;
                    }
                    else
                    {
                        // Nếu không tìm thấy,thông báo lỗi
                        System.Windows.MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }
                else
                {
                    // Hiển thị thông báo yêu cầu nhập số
                    System.Windows.MessageBox.Show("Vui lòng nhập số điện thoại là số", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSdtKH.Focus();
                    return;
                }
            }
        }

        private void txtMaH_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string mah = txtMaHang.Text;
                // Tìm sản phẩm có mã hàng nhập vào trong CSDL
                var mahang = db1.SanPhams.SingleOrDefault(mh => mh.MaSp == mah);
                if (mahang != null)
                {
                    txtTenHang.Text = mahang.TenSp; // Hiển thị tên mặt hàng 
                    txtDonGia.Text = mahang.DonGia.ToString();  // Hiển thị đơn giá của mặt hàng
                }
                else
                {
                    // Nếu không tìm thấy thì đưa ra thông báo lỗi
                    System.Windows.MessageBox.Show("Không tìm thấy thông tin mặt hàng có mã " + mah, "Lỗi", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtMaHang.Focus();
                    return;
                }
            }
        }

        private void btnThemHang_Click(object sender, RoutedEventArgs e)
        {
            string mahang = txtMaHang.Text;
            string tenhang = txtTenHang.Text;
            int dongia = int.Parse(txtDonGia.Text);
            int soluong;

            if (!int.TryParse(txtSoLuong.Text, out soluong))
            {
                System.Windows.MessageBox.Show("Vui lòng nhập số lượng là số nguyên.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSoLuong.Focus();
                return;
            }

            int thanhTien = soluong * dongia;

            // Tao doi tuong mat hang moi
            SanPham hangmoi = new SanPham
            {
                MaSp = mahang,
                TenSp = tenhang,
                DonGia = dongia,
                SoLuong = soluong,
                ThanhTien = thanhTien
            };

            // Thêm vào danh sách DataGrid
            dtgDanhSachHangMua.Items.Add(hangmoi);
        }

        private void btnLuuHoaDon_Click(object sender, RoutedEventArgs e)
        {
            if (checkBill() == true)
            {
                // Lay day du du lieu tu window Hoadon
                string sohd = txtSoHd.Text.Trim();
                string hoten = txtHoTenKH.Text;
                string mahang = txtMaHang.Text;
                int sl = int.Parse(txtSoLuong.Text);
                DateTime ngaylap = DateTime.Now;


                // Kiểm tra sự tồn tại của mã hóa đơn
                var billID = db1.HoaDons.SingleOrDefault(s => s.MaHd == sohd);
                if (billID != null)
                {
                    System.Windows.MessageBox.Show("Mã hóa đơn này đã tồn tại. Vui lòng nhập mã hóa đơn khác", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoHd.Focus();
                    return;
                }

                var maKh = db1.KhachHangs.SingleOrDefault(kh => kh.TenKh == hoten);
                HoaDon hoaDon = new HoaDon()
                {
                    MaHd = sohd,
                    NgayLap = ngaylap,
                    MaKh = maKh.MaKh,
                    NguoiLap = "",
                    TenDangNhap = txtHoaDonTenDangNhap.Text
                };

                // Thêm thông tin hóa đơn vào bảng HoaDon
                db1.HoaDons.Add(hoaDon);

                foreach (SanPham sp in dtgDanhSachHangMua.Items)
                {
                    HoaDonChiTiet chiTiet = new HoaDonChiTiet
                    {
                        MaHd = sohd,
                        MaSp = mahang,
                        SoLuongMua = sl
                    };
                    // Thêm thông tin mua hàng vào HoaDonChiTiet
                    db1.HoaDonChiTiets.Add(chiTiet);
                }

                // Lưu thay đổi
                db1.SaveChanges();

                // Xóa nội dung các TextBox sau khi thêm
                txtSoHd.Clear();
                txtSdtKH.Clear();
                txtHoTenKH.Clear();
                txtMaHang.Clear();
                txtTenHang.Clear();
                txtDonGia.Clear();
                txtSoLuong.Clear();
            }
        }
        private bool checkBill()
        {
            if (string.IsNullOrEmpty(txtSoHd.Text) || string.IsNullOrEmpty(txtSdtKH.Text) || string.IsNullOrEmpty(txtHoTenKH.Text))
            {
                System.Windows.MessageBox.Show("Vui lòng nhập đầy đủ thông tin hóa đơn", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtMaHang.Text) || string.IsNullOrEmpty(txtTenHang.Text) || string.IsNullOrEmpty(txtSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text))
            {
                System.Windows.MessageBox.Show("Vui lòng nhập đầy đủ thông tin hàng mua", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
    }
    // Tao mot lop san pham tu file anh xa
    public class SanPham
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
    }
}
