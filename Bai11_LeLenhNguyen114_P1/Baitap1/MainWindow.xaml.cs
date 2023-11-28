using BaiTap1.Models;
using Microsoft.EntityFrameworkCore;
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
            HienThi();
        }

        private void HienThi()
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

        private void Clear_TextBox()
        {
            // Dua cac textbox ve trang thai chua nhap
            txtMaSp.Text = string.Empty;
            txtTenSp.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtMaLoai.Text = string.Empty;
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
            string masp = txtMaSp.Text.Trim();
            // Kiem tra ma da ton tai trong CSDL chua
            var existingID = db.SanPhams.FirstOrDefault(sp => sp.MaSp == masp);
            if (existingID != null)
            {
                MessageBox.Show("Ma san pham da ton tai. Hay chon ma san pham khac.", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaSp.Focus();
                return;
            }

            SanPham spMoi = new SanPham();
            spMoi.MaSp = txtMaSp.Text;
            spMoi.TenSp = txtTenSp.Text;
            spMoi.SoLuong = int.Parse(txtSoLuong.Text);
            spMoi.DonGia = int.Parse(txtDonGia.Text);
            spMoi.MaLoai = txtMaLoai.Text;

            // Them vao csdl
            db.SanPhams.Add(spMoi);

            // luu thay doi csdl
            db.SaveChanges();

            // Clear cac textbox
            Clear_TextBox();

            // hien thi danh sach sau khi them
            HienThi();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            string masp = txtMaSp.Text;
            // Kiem tra neu ma san pham khong duoc nhap
            if (string.IsNullOrEmpty(masp))
            {
                MessageBox.Show("Vui long nhap ma san pham can sua.", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaSp.Focus();
                return;
            }

            // Tim san pham trong csdl
            var sanpham = db.SanPhams.FirstOrDefault(sp => sp.MaSp == masp);
            
            // Neu khong tim thay dua ra thong bao
            if (sanpham == null) {
                MessageBox.Show("Khong tim thay san pham co ma " + masp + ".", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaSp.Focus();
                return;
            }

            // nguoclai tien hanh cap nhat
            sanpham.TenSp = txtTenSp.Text;
            sanpham.SoLuong = int.Parse(txtSoLuong.Text);
            sanpham.DonGia = int.Parse(txtDonGia.Text);
            sanpham.MaLoai = txtMaLoai.Text;

            // luu thay doi csdl
            db.SaveChanges();

            // Clear cac textbox
            Clear_TextBox();

            // Hien thi danh sach sau khi cap nhat
            HienThi();
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            string masp = txtMaSp.Text;
            // Kiem tra neu masp khong duoc nhap
            if (string.IsNullOrEmpty(masp)) {
                MessageBox.Show("Vui long nhap ma san pham can xoa.", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaSp.Focus();
                return;
            }

            // Tim san pham can xoa trong csdl
            var sanpham = db.SanPhams.FirstOrDefault(sp => sp.MaSp == masp);

            // Neu khong tim thay dua ra thong bao
            if (sanpham == null)
            {
                MessageBox.Show("Khong tim thay san pham co ma " + masp + ".", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtMaSp.Focus();
                return;
            }

            // Hien thi hop thoai san pham xoa
            var confirmMessage = MessageBox.Show("Ban co muon xoa san pham co ma " + masp + "?", "Xac nhan xoa", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // Xoa san pham khi chon Yes
            if(confirmMessage == MessageBoxResult.Yes)
            {
                // Xoa san pham khoi csdl
                db.SanPhams.Remove(sanpham);
                db.SaveChanges();

                // Clear cac textbox
                Clear_TextBox();

                // hien thi danh sach sau khi xoa
                HienThi();
            }
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
