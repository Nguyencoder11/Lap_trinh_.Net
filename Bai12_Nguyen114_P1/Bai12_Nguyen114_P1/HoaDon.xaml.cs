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
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : Window
    {
        // Khai báo
        private QlbhContext db1;

        public string TenDangNhap { get; set; }
        public string SoDt { get; set; }

        public HoaDon(string tenDangNhap, QlbhContext dbContext)
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
                        // Nếu không tìm thấy,thông báo lỗi và đặt Text của TextBox Tên khách hàng là null
                        System.Windows.MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Information);
                        txtHoTenKH.Text = null;
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
            if(e.Key == Key.Enter)
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
                    System.Windows.MessageBox.Show("Không tìm thấy thông tin mặt hàng.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Information);
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

            if(!int.TryParse(txtSoLuong.Text, out soluong))
            {
                System.Windows.MessageBox.Show("Vui lòng nhập số lượng là số.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
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

            // Xóa nội dung các TextBox sau khi thêm
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
        }

        private void btnLuuHoaDon_Click(object sender, RoutedEventArgs e)
        {

            // Thêm thông tin vào csdl 

            // Lưu thay đổi
            db1.SaveChanges();
        }
    }

    // Tao mot lop san pham tu file anh xa
    class SanPham
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
    }
}
