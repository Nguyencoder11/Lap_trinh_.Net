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

namespace BaiTap93
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

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            string gender, marriedStatus, hobby = "";
            if(radNam.IsChecked == true)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }

            if(radChuaKetHon.IsChecked == true)
            {
                marriedStatus = "Chưa kết hôn";
            }
            else
            {
                marriedStatus = "Đã kết hôn";
            }

            if(chkBongDa.IsChecked == true)
            {
                hobby = "Bóng đá";
            }
            if(chkBoiLoi.IsChecked == true)
            {
                hobby += ", Bơi lội";
            }
            if(chkAmNhac.IsChecked == true)
            {
                hobby += ", Âm nhạc";
            }
            if(chkLeoNui.IsChecked == true)
            {
                hobby += ", Leo núi";
            }

            if(hobby.Substring(0,1) == ",")
            {
                hobby = hobby.Substring(2, hobby.Length - 2);
            }

            lstHienThi.Items.Add("Họ tên: " + txtHoTen.Text);
            lstHienThi.Items.Add("Giới tính: " + gender);
            lstHienThi.Items.Add("Tình trạng hôn nhân: " + marriedStatus);
            lstHienThi.Items.Add("Sở thích: " + hobby);
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("Bạn muốn thoát chương trình?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (message == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
