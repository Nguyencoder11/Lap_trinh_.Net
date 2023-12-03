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
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            if(checkData() == true)
            {

            }
        }

        private bool checkData()
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            if(string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password) )
            {
                System.Windows.MessageBox.Show("Yêu cầu nhập đầy đủ thông tin đăng nhập", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(string.IsNullOrEmpty(username) )
            {
                System.Windows.MessageBox.Show("Chưa nhập tên người dùng", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTenDangNhap.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(password) )
            {
                System.Windows.MessageBox.Show("Chưa nhập mật khẩu", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }
    }
}