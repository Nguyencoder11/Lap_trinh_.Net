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

namespace DE3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<KhachHang> danhsach = new List<KhachHang>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            Window1 newWindow = new Window1();
            newWindow.Show();
            

        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            
            if(kiemtra() == true)
            {
                KhachHang khmoi = new KhachHang();
                khmoi.HoTen = txtHoTen.Text;
                khmoi.NgayMua = dtpNgayMua.SelectedDate.Value;
                khmoi.SoLuong = int.Parse(txtSoLuongMua.Text);

                danhsach.Add(khmoi);

                dtgDanhSach.ItemsSource = null;
                dtgDanhSach.ItemsSource = danhsach;
            }
            
        }

        private bool kiemtra()
        {
            // Lay du lieu 
            string hoten = txtHoTen.Text;
            DateTime ngay = dtpNgayMua.SelectedDate.Value;

            string soluong = txtSoLuongMua.Text;

            // Kiem tra
            if (string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Chua nhap ho ten", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            if (ngay == default)
            {
                MessageBox.Show("Ban chua lua chon ngay", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (string.IsNullOrEmpty(soluong))
            {
                MessageBox.Show("Ban chua nhap so luong", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (ngay.Date != DateTime.Today)
            {
                MessageBox.Show("Ngay mua khac voi nggay he thong", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if(int.Parse(soluong) <= 10 || int.Parse(soluong) >= 20)
            {
                MessageBox.Show("So luong phai trong khoang 10-20", "Loi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSoLuongMua.Focus();
                return false;
            }

            return true;
        }
    }

    class KhachHang
    {
        public string HoTen { get; set; }
        public DateTime NgayMua { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { 
            set { ThanhTien = value; }
            get { return SoLuong * 1000; }
        }
    }
}