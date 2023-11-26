using DemoBai11_12.MoHinhCSDL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoBai11_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //khai báo, khởi tạo đối tượng dbcontext
        QlnhanSuContext db = new QlnhanSuContext();
        public MainWindow()
        {
            InitializeComponent();
            dtpNgayTL.SelectedDate = DateTime.Today;
        }

        private void btnHienThi_Click(object sender, RoutedEventArgs e)
        {
            //hiển thị  dữ liệu
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            //-- dùng linq để lấy dữ liệu trong lớp thực thể phòng ban
            var queryPhongBan = from p in db.PhongBans
                                select p;
            //--hiển thị lên datagrid
            dtgPhongBan.ItemsSource = queryPhongBan.ToList();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (isKiemTra() == true)
            {
                //thêm một phòng ban mới
                //-- tạo mới một đối tượng phòng ban
                PhongBan pbMoi = new PhongBan();

                //-- giá trị thuộc tính của phòng ban
                pbMoi.MaPb = txtMaPB.Text;
                pbMoi.TenPb = txtTenPB.Text;
                pbMoi.NgayThanhLap = dtpNgayTL.SelectedDate;
                // mới do user nhập vào
                //thêm vào lớp thực thể tương ứng
                db.PhongBans.Add(pbMoi);
                //cập nhật thay đổi vào csdl
                db.SaveChanges();
                //hiển thị lại sau cập nhật
                HienThiDuLieu();
            }

        }
        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            //lấy phòng ban muốn sửa
            var querySua = from p in db.PhongBans
                           where p.MaPb == txtMaPB.Text
                           select p;
            PhongBan pbSua = querySua.FirstOrDefault();
            if (pbSua != null)
            {
                //--sửa thông tin 
                pbSua.TenPb = txtTenPB.Text;
                pbSua.NgayThanhLap = dtpNgayTL.SelectedDate;
                //cập nhật thay đổi vào csdl
                db.SaveChanges();
                //hiển thị lại sau cập nhật
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Không có mã phòng ban muốn sửa",
                    "UPDATE DATA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void bntXoa_Click(object sender, RoutedEventArgs e)
        {
            //lấy phòng ban muốn xóa
            var queryXoa = from p in db.PhongBans
                           where p.MaPb == txtMaPB.Text
                           select p;
            PhongBan pbXoa = queryXoa.FirstOrDefault();
            if (pbXoa != null)
            {
                //--xóa phòng ban
                db.PhongBans.Remove(pbXoa);
                //cập nhật thay đổi vào csdl
                db.SaveChanges();
                //hiển thị lại sau cập nhật
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Không có mã phòng ban muốn xóa",
                    "UPDATE DATA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void dtgPhongBan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //lấy ra phòng ban được chọn
            PhongBan pbChon = dtgPhongBan.SelectedItem as PhongBan;
            if (pbChon != null)
            {
                //gán cho điều khiên tương ứng
                txtMaPB.Text = pbChon.MaPb;
                txtTenPB.Text = pbChon.TenPb;
                dtpNgayTL.SelectedDate = pbChon.NgayThanhLap;
            }
        }

        private bool isKiemTra()
        {
            //kiểm tra phải nhập tất cả các trường
            if (txtMaPB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã phòng ban", "Thêm", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaPB.Focus();
                return false;
            }
            if (txtTenPB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên phòng ban", "Thêm", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTenPB.Focus();
                return false;
            }
            if (dtpNgayTL.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ngày thành lập", "Thêm", MessageBoxButton.OK, MessageBoxImage.Error);
                dtpNgayTL.SelectedDate = DateTime.Today;
                return false;
            }
            //kiểm tra trùng khóa chính
            var pb = db.PhongBans.FirstOrDefault(x => x.MaPb.Equals(txtMaPB.Text));

            if (pb != null)
            {
                MessageBox.Show($"Đã tồn tại mã phòng ban {txtMaPB.Text}, Nhập mã phòng ban khác.", "Thêm", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaPB.SelectAll();
                txtMaPB.Focus();
                return false;
            }

            return true;

        }
    }
}
