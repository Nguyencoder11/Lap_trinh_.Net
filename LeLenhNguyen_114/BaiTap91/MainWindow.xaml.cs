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

namespace BaiTap91
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Them du lieu
            lstDanhSach.Items.Add("Công nghệ thực tại ảo");
            lstDanhSach.Items.Add("Đảm bảo chất lượng phần mềm");
            lstDanhSach.Items.Add("Giải thuật di truyền và ứng dụng");
            lstDanhSach.Items.Add("Hệ chuyên gia");
            lstDanhSach.Items.Add("Lập trình căn bản");
            lstDanhSach.Items.Add("Lập trình hướng đối tượng");
            lstDanhSach.Items.Add("Lập trình mạng");
            lstDanhSach.Items.Add("Lập trình trên Windows");
            lstDanhSach.Items.Add("Một số phương pháp tính toán phần mềm");
            lstDanhSach.Items.Add("Nhập môn tin học");
            lstDanhSach.Items.Add("Phân tích thiết kế hệ thống");
            lstDanhSach.Items.Add("Phân tích và thống kê số liệu");
            lstDanhSach.Items.Add("Thiết kế Cơ sở dữ liệu");
            lstDanhSach.Items.Add("Thiết kế trang Web");
            lstDanhSach.Items.Add("Tin văn phòng");
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            lstDaChon.Items.Add(lstDanhSach.SelectedItem);
            lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
        }

        private void btnThemHet_Click(object sender, RoutedEventArgs e)
        {
            foreach(string item in lstDanhSach.Items)
            {
                lstDaChon.Items.Add(item);
            }
            lstDanhSach.Items.Clear();
        }

        private void btnBo_Click(object sender, RoutedEventArgs e)
        {
            lstDanhSach.Items.Add(lstDaChon.SelectedItem);
            lstDaChon.Items.Remove(lstDaChon.SelectedItem);
        }

        private void btnBoHet_Click(object sender, RoutedEventArgs e)
        {
            foreach(string item in lstDaChon.Items)
            {
                lstDanhSach.Items.Add(item);
            }
            lstDaChon.Items.Clear();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("Bạn có muốn thoát chương trình?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (message == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
