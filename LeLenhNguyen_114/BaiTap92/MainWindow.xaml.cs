﻿using System;
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

namespace BaiTap92
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
            string ThongTin = txtHoTen.Text + " - " + cboGioiTinh.Text + " - " + cboPhongBan.Text;
            lstDanhSach.Items.Add(ThongTin);
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            var ms = MessageBox.Show("Bạn muốn kết thúc chương trình?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ms == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
