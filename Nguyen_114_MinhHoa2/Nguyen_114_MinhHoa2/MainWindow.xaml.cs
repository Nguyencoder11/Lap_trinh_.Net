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

namespace Nguyen_114_MinhHoa2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NhanVien> danhsachNV = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if(dataCheck() == true)
            {
                NhanVien nvMoi = new NhanVien
                {
                    MaNV = txtMaNv.Text,
                    HoTen = txtHoTen.Text,
                    NgaySinh = (DateTime)dtpNgaySinh.SelectedDate,
                    GioiTinh = (radNam.IsChecked == true) ? "Nam" : "Nữ",
                    PhongBan = cboPhongBan.Text,
                    HeSoLuong = double.Parse(txtHeSoLuong.Text)
                };
                danhsachNV.Add(nvMoi);
                dtgDanhSachNhanVien.ItemsSource = null;
                dtgDanhSachNhanVien.ItemsSource = danhsachNV;

                txtMaNv.Text = "";
                txtHoTen.Text = "";
                dtpNgaySinh.SelectedDate = null;
                txtHeSoLuong.Text = "";
            }
        }


        List<NhanVien> dsNhanVienTuoiMax = new List<NhanVien>();
        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            int maxAge = danhsachNV[0].Tuoi;
            for(int i=1; i<danhsachNV.Count; i++)
            {
                if(maxAge < danhsachNV[i].Tuoi)
                {
                    maxAge = danhsachNV[i].Tuoi;
                }
            }
            foreach(var nv in danhsachNV)
            {
                if (nv.Tuoi.Equals(maxAge))
                {
                    dsNhanVienTuoiMax.Add(nv);
                }
            }

            // Hien thi len window 2
            Window2 window2 = new Window2();
            window2.dtgTuoiCaoNhat.ItemsSource = dsNhanVienTuoiMax;
            window2.Show();
        }

        private bool dataCheck()
        {
            // Kiem tra phai nhap het du lieu
            if (string.IsNullOrEmpty(txtMaNv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtHeSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập hệ số lương", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHeSoLuong.Focus();
                return false;
            }

            // Kiem tra tuoi nhan vien >= 18
            DateTime ns = (DateTime)dtpNgaySinh.SelectedDate;
            if((DateTime.Today.Year -ns.Year) < 18)
            {
                MessageBox.Show("Tuổi của nhân viên phải lớn hơn hoặc bằng 18!", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Kiem tra he so luong la so thuc
            try
            {
                double luong = double.Parse(txtHeSoLuong.Text);
                if(luong < 0)
                {
                    MessageBox.Show("Hệ số lương phải là số thực > 0!", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHeSoLuong.Focus();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Hệ số lương phải là số!", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Kiem tra trung ma nhan vien

            return true;
        }
    }
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string PhongBan { get; set; }
        public double HeSoLuong { get; set; }

        public int Tuoi
        {
            get
            {
                return DateTime.Now.Year - NgaySinh.Year;
            }
        }
    }
}