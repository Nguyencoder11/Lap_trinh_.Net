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

namespace TinhTienDien
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

        double soKwTieuThu, tongTien;
        private void btnTinh_Click(object sender, RoutedEventArgs e)
        {
            double chiSoCu, chiSoMoi, soKwTrongDinhMuc, soKwVuotDinhMuc = 0;
            chiSoCu = double.Parse(txtChiSoCu.Text);
            chiSoMoi = double.Parse(txtChiSoMoi.Text);
            soKwTieuThu = chiSoMoi - chiSoCu;
            if(soKwTieuThu <= 50)
            {
                soKwTrongDinhMuc = soKwTieuThu;
                tongTien = soKwTieuThu * 500;
            }
            else
            {
                soKwTrongDinhMuc = 50;
                soKwVuotDinhMuc = soKwTieuThu - 50;
                tongTien = 25000 + soKwVuotDinhMuc * 1000;
            }
            txtSoKwTieuThu.Text = soKwTieuThu.ToString();
            txtTongTienTra.Text = tongTien.ToString("NO");
            txtSoKwTrongDinhMuc.Text = soKwTrongDinhMuc.ToString();
            txtSoKwVuotDinhMuc.Text = soKwVuotDinhMuc.ToString();
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            lstThongTin.Items.Clear();
            lstThongTin.Items.Add(cboHoTen.Text);
            lstThongTin.Items.Add("Số kw tiêu thụ: " + soKwTieuThu);
            lstThongTin.Items.Add("Tổng tiền: " + tongTien.ToString("NO"));
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
