using Bai11_Nguyen114_ThucHanh.MyModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bai11_Nguyen114_ThucHanh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlnhanSuContext db = new QlnhanSuContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            var query = from nv in db.NhanViens
                        join pb in db.PhongBans on nv.MaPb equals pb.MaPb
                        select new
                        {
                            nv.MaNv,
                            nv.HoTen,
                            nv.NgaySinh,
                            nv.Gioitinh,
                            nv.NgoaiNgu,
                            pb.TenPb,
                            Tuoi = DateTime.Now.Year - nv.NgaySinh.Value.Year
                        };
            dtgDanhSachNhanVien.ItemsSource = query.ToList();
        }

        private void btnHienThi_Click(object sender, RoutedEventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            var existedID = db.NhanViens.FirstOrDefault(nv => nv.MaNv == manv);
            if (existedID != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return;
            }

            NhanVien nvMoi = new NhanVien();
            nvMoi.MaNv = txtMaNV.Text;
            nvMoi.HoTen = txtHoTen.Text;
            nvMoi.NgaySinh = dtpNgaySinh.SelectedDate.Value;
            if(radNam.IsChecked == true)
            {
                nvMoi.Gioitinh = "Nam";
            }
            else
            {
                nvMoi.Gioitinh = "Nữ";
            }
            nvMoi.NgoaiNgu = txtNgoaiNgu.Text;
            nvMoi.MaPb = txtMaPhongBan.Text;

            db.NhanViens.Add(nvMoi);

            db.SaveChanges();

            _ClearControll_();

            HienThi();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            if(string.IsNullOrEmpty(manv) )
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return;
            }
            var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNv == manv);
            if(nhanvien == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã " + manv, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return;
            }
            nhanvien.HoTen = txtHoTen.Text.Trim();
            nhanvien.NgaySinh = dtpNgaySinh.SelectedDate;
            if(radNam.IsChecked == true)
            {
                nhanvien.Gioitinh = "Nam";
            }
            else
            {
                nhanvien.Gioitinh = "Nữ";
            }
            nhanvien.NgoaiNgu = txtNgoaiNgu.Text.Trim();
            nhanvien.MaPb = txtMaPhongBan.Text.Trim();

            db.SaveChanges();
            _ClearControll_();
            HienThi();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            string manv = txtMaNV.Text.Trim();
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return;
            }

            var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.MaNv == manv);
            if (nhanvien == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên có mã " + manv, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return;
            }

            var delMessageConfirm = MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + manv + " không?", "Xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(delMessageConfirm == MessageBoxResult.Yes)
            {
                db.NhanViens.Remove(nhanvien);
                db.SaveChanges();
                _ClearControll_();
                HienThi();
            }
        }

        private void _ClearControll_()
        {
            txtMaNV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            dtpNgaySinh.SelectedDate = default;
            radNam.IsChecked = false;
            radNu.IsChecked = false;
            txtNgoaiNgu.Text = string.Empty;
        }

        private void dtgNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dtgDanhSachNhanVien.SelectedItem != null)
            {
                var selectedRow = (dynamic)dtgDanhSachNhanVien.SelectedItem;

                txtMaNV.Text = selectedRow.MaNv;
                txtHoTen.Text= selectedRow.HoTen;
                dtpNgaySinh.SelectedDate = selectedRow.NgaySinh;
                if(selectedRow.Gioitinh == "Nam")
                {
                    radNam.IsChecked = true;
                }
                else
                {
                    radNu.IsChecked = true;
                }
                txtNgoaiNgu.Text = selectedRow.NgoaiNgu;
                string tenpb = selectedRow.TenPb;
                string maPb = db.PhongBans.FirstOrDefault(pb => pb.TenPb == tenpb)?.MaPb;
                txtMaPhongBan.Text = maPb ?? "";
            }
        }
    }
}