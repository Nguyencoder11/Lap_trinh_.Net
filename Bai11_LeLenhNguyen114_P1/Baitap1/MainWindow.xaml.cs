using BaiTap1.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace BaiTap1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHangContext db = new QLBanHangContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        join lsp in db.LoaiSanPhams on sp.MaLoai equals lsp.MaLoai
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.SoLuong,
                            sp.DonGia,
                            lsp.TenLoai
                        };
            dtgDanhSachSanPham.ItemsSource = query.ToList();
        }

        private void dtgSanPham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dtgDanhSachSanPham.SelectedItem != null)
            {
                var selectedRow = (dynamic)dtgDanhSachSanPham.SelectedItem;

                string masp = selectedRow.MaSp;
                string tensp = selectedRow.TenSp;
                string soluong = selectedRow.SoLuong.ToString();
                string dongia = selectedRow.DonGia.ToString();
                string tenloai = selectedRow.TenLoai;

                string maloai = db.LoaiSanPhams.FirstOrDefault(lsp => lsp.TenLoai == tenloai)?.MaLoai;

                txtMaSp.Text = masp;
                txtTenSp.Text = tensp;
                txtSoLuong.Text = soluong;
                txtDonGia.Text = dongia;
                txtMaLoai.Text = maloai??"";
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            SanPham spMoi = new SanPham();

        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            var message = MessageBox.Show("Ban muon thoat chuong trinh?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (message == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
