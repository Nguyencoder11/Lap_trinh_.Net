using Bai12_Nguyen114_P1.DataModels;
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

namespace Bai12_Nguyen114_P1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlbhContext db = new QlbhContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            if(checkData() == true)
            {
                // Lấy dữ liệu nhập vào từ người dùng 
                string tendn = txtTenDangNhap.Text.Trim();
                string matkhau = txtMatKhau.Text.Trim();

                // tìm kiếm thông tin tài khoản trong csdl và đối chiếu
                var userInfo = db.NguoiDungs.SingleOrDefault(user => (user.TenDangNhap == tendn && user.MatKhau == matkhau));
                // Nếu tồn tại
                if(userInfo != null)
                {
                    // hiển thị giao diện Hóa đơn
                    Window2 hoadon = new Window2(tendn, db);
                    hoadon.Show();
                }
                else
                {
                    // đưa ra thông báo nếu không tìm thấy
                    System.Windows.MessageBox.Show("Tài khoản không tồn tại. Vui lòng nhập lại tài khoản", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
        }

        private bool checkData()
        {
            if(string.IsNullOrEmpty(txtTenDangNhap.Text) && string.IsNullOrEmpty(txtMatKhau.Text) )
            {
                System.Windows.MessageBox.Show("Yêu cầu nhập đầy đủ thông tin đăng nhập", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtTenDangNhap.Text) )
            {
                System.Windows.MessageBox.Show("Chưa nhập tên người dùng", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTenDangNhap.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txtMatKhau.Text) )
            {
                System.Windows.MessageBox.Show("Chưa nhập mật khẩu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }
    }
}