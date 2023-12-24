using DeOnTapThiKTHP.ManageFiles;
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

namespace DeOnTapThiKTHP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLyBanHangContext db = new QuanLyBanHangContext();
        public int ThanhTien { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded (object sender, RoutedEventArgs e)
        {
            hienThi();
        }

        private void hienThi()
        {
            var query = from sp in db.SanPhams
                        orderby sp.DonGia ascending
                        select new
                        {
                            sp.MaSp,
                            sp.TenSp,
                            sp.MaLoai,
                            sp.SoLuongCo,
                            sp.DonGia,
                            ThanhTien = sp.SoLuongCo * sp.DonGia
                        };
            dtgDanhSach.ItemsSource = query.ToList();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (isCheck() == true)
            {
                SanPham sanPham = new SanPham()
                {
                    MaSp = txtMaSp.Text.Trim(),
                    TenSp = txtTenSp.Text.Trim(),
                    MaLoai = db.LoaiSps.SingleOrDefault(ls => ls.TenLoai.Equals(cboLoaiSp.Text)).MaLoai,
                    DonGia = int.Parse(txtDonGia.Text),
                    SoLuongCo = int.Parse(txtSoLuongCo.Text),
                };

                db.SanPhams.Add(sanPham);

                db.SaveChanges();

                txtMaSp.Text = "";
                txtTenSp.Text = "";
                txtSoLuongCo.Text = "";
                txtDonGia.Text = "";

                hienThi();   
            }
        }

        private bool isCheck()
        {
            if(txtMaSp.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sản phẩm", "Thông báo lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaSp.Focus();
                return false;
            }
            if (txtTenSp.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sản phẩm", "Thông báo lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtTenSp.Focus();
                return false;
            }
            if (txtSoLuongCo.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng có", "Thông báo lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSoLuongCo.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Chưa nhập đơn giá", "Thông báo lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDonGia.Focus();
                return false;
            }

            try
            {
                int soluongco = int.Parse(txtSoLuongCo.Text);
                if(soluongco <= 0)
                {
                    MessageBox.Show("Số lượng có là số nguyên > 0", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoLuongCo.Focus();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Số lượng có phải là số!", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            try
            {
                int dongia = int.Parse(txtDonGia.Text);
                if (dongia <= 0)
                {
                    MessageBox.Show("Đơn giá là số nguyên > 0", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtDonGia.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đơn giá phải là số!", "Valid Data", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Kiem tra trung ma san pham
            var sp = db.SanPhams.SingleOrDefault(s => s.MaSp.Equals(txtMaSp.Text.Trim()));
            if(sp != null)
            {
                MessageBox.Show($"Đã tồn tại mã sản phẩm {txtMaSp.Text}, Nhập mã sản phẩm khác.", "Thêm", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaSp.SelectAll();
                txtMaSp.Focus();
                return false;
            }

            return true;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var spSua = db.SanPhams.SingleOrDefault(sp => sp.MaSp.Equals(txtMaSp.Text.Trim()));
            if (spSua != null)
            {
                // cap nhat san pham
                spSua.TenSp = txtTenSp.Text.Trim();
                spSua.MaLoai = db.LoaiSps.SingleOrDefault(s => s.TenLoai.Equals(cboLoaiSp.Text)).MaLoai;
                spSua.DonGia = int.Parse(txtDonGia.Text);
                spSua.SoLuongCo = int.Parse(txtSoLuongCo.Text);

                db.SaveChanges();

                txtMaSp.Text = "";
                txtTenSp.Text = "";
                txtSoLuongCo.Text = "";
                txtDonGia.Text = "";

                hienThi();
            }
            else
            {
                MessageBox.Show("Không có mã sản phẩm muốn sửa", "UPDATE DATA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var spXoa = db.SanPhams.SingleOrDefault(sp => sp.MaSp.Equals(txtMaSp.Text.Trim()));
            if (spXoa != null)
            {
                var messageConfirm = MessageBox.Show("Bạn có muốn xóa sản phẩm cỏ mã " + spXoa.MaSp + "?", "DELETE DATA", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(messageConfirm == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(spXoa);

                    db.SaveChanges();

                    hienThi();
                }
            }
            else
            {
                MessageBox.Show("Không có mã sản phẩm muốn xoá", "DELETE DATA", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            // Lay danh sach cac san pham 
            var queryTim = from sp in db.SanPhams
                           join lsp in db.LoaiSps on sp.MaLoai equals lsp.MaLoai
                           join hoadon in db.ChiTietHoaDons on sp.MaSp equals hoadon.MaSp
                           group hoadon by new { sp.MaSp, sp.TenSp, lsp.TenLoai } into grouped
                           select new
                           {
                               grouped.Key.MaSp,
                               grouped.Key.TenSp,
                               grouped.Key.TenLoai,
                               SoLuongBan = grouped.Sum(hoadon => hoadon.SoLuongMua),
                               TongTien = grouped.Sum(hoadon => hoadon.DonGia * hoadon.SoLuongMua),
                           };

            FindProduct window = new FindProduct();
            window.dtgFindProduct.ItemsSource = queryTim.ToList();
            window.Show();
        }

    }
}