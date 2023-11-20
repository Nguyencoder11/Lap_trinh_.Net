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

namespace BaiTap95
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

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            string douong = "";

            if (chkNuocCam.IsChecked == true)
            {
                douong = "Nước cam;";
            }
            if (chkKiWiEp.IsChecked == true)
            {
                douong += " Nước Kiwi;";
            }
            if (chkXoaiEp.IsChecked == true)
            {
                douong += " Nước xoài ép; ";
            }
            if (chkSuaTuoi.IsChecked == true)
            {
                douong += " Sữa tươi;";
            }
            if (chkCaPhe.IsChecked == true)
            {
                douong += " Cà phê;";
            }
            if (douong != "")
            {
                MessageBox.Show("Bạn đã chọn " + douong);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đồ uống nào!!!");
            }
        }
    }
}
