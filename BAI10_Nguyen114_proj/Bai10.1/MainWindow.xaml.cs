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

namespace Bai10._1
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

        private void btnNhapSinhVien_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNhapKhoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNhapMonHoc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNhapDiem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTraCuuDiem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTraCuuSvTheoKhoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("Bạn muốn thoát hệ thống?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (message == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
