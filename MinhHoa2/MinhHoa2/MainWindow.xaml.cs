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

namespace MinhHoa2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Lay thong tin tu cac truong du lieu
                string maNV = txtMaNV.Text;
                string hoTen = txtHoTen.Text;
                DateTime ngaySinh = dtpNgaySinh.SelectedDate.GetValueOrDefault();
                string gioiTinh = radNam.IsChecked.GetValueOrDefault()?"Nam":"Nữ";
                string phongBan = cboPhongBan.Text;
                string heSoLuong = txtHeSoLuong.Text;

                // Kiem tra du lieu hop le
                if(string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoTen) || ngaySinh==default || string.IsNullOrEmpty(heSoLuong) || (!radNam.IsChecked.Value && !radNu.IsChecked.Value))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Kiem tra tuoi cua nhan vien 
                int tuoi = DateTime.Now.Year - ngaySinh.Year;
                if(tuoi < 18)
                {
                    MessageBox.Show("Tuổi của nhân viên phải lớn hơn hoặc bằng 18.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Kiem tra he so luong
                if(!double.TryParse(heSoLuong, out double heSo) || heSo <= 0)
                {
                    MessageBox.Show("Hệ số lương phải là số thực dương.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Them du lieu vao DataGrid
                dtgNhanVien.Items.Add(new NhanVien
                {
                    MaNV = maNV,
                    HoTen = hoTen,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    PhongBan = phongBan,
                    Tuoi = tuoi
                });

                // Reset cac truong du lieu
                txtMaNV.Clear();
                txtHoTen.Clear();
                dtpNgaySinh.SelectedDate = null;
                radNam.IsChecked = false;
                radNu.IsChecked = false;
                cboPhongBan.SelectedIndex = 0;
                txtHeSoLuong.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Tao cua so Window 2
                Window2 window2 = new Window2();

                // Lay nhan vien co tuoi cao nhat
                int maxTuoi = 0;
                List<NhanVien> oldestEmployees = new List<NhanVien>();

                foreach(NhanVien employee in dtgNhanVien.Items)
                {
                    if(employee.Tuoi > maxTuoi)
                    {
                        maxTuoi = employee.Tuoi;
                        oldestEmployees.Clear();
                        oldestEmployees.Add(employee);
                    }
                    else if(employee.Tuoi == maxTuoi)
                    {
                        oldestEmployees.Add(employee);
                    }
                }

                // Dua danh sach len DataGrid trong Window 2
                window2.dtgNhanVienMaxTuoi.ItemsSource = oldestEmployees;

                window2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
    class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string PhongBan { get; set; }
        public double HeSoLuong { get; set; }

        public int Tuoi { get; set; }
    }
}
