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

namespace kiemtraky1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TxbHienThi_Click(object sender, RoutedEventArgs e)
        {
            string ten = "Ten: " + txtTenkh.Text + "\n";
            string sdt = "So Dien Thoai: " + txtSodt.Text + "\n";
            string soluong = "SoLuong: " + txtSoLuong.Text + "\n";
            string SanPham;
                
            int tongtien, gia;

            if (rbtTivi.IsChecked == true)
            {
                SanPham = "SanPham: TiVi" + "\n";
                gia = 200000;
            }
            else
                if (rbtTuLanh.IsChecked == true)
            {
                SanPham = "SanPham: TuLanh" + "\n";
                gia = 150000;
            }
            else
            {
                SanPham = "SanPham: MayTinh" + "\n";
                gia = 50000;
            }

            tongtien = Int32.Parse(txtSoLuong.Text) * gia;

                String hienThi = ten + sdt + soluong + SanPham + "Tong Tien : " + tongtien.ToString() + "\n";
                MessageBox.Show( hienThi);
        }
    }
}
