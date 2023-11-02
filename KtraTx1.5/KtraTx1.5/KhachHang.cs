using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraTx1._5
{
    internal class KhachHang
    {
        private string mkh;
        private string ht;
        private int slm;
        private double dg;

        public string MaKhachHang
        {
            get { return mkh; }
            set { mkh = value; }
        }
        public string HoTen
        {
            get { return ht; }
            set { ht = value; }
        }
        public int SLM
        {
            get { return slm; }
            set { slm = value; }
        }
        public double DonGia
        {
            get { return dg; }
            set { dg = value; }
        }

        public KhachHang()
        {
            MaKhachHang = "";
            HoTen = "";
            SLM = 0;
            DonGia = 0;
        }
        public KhachHang(string maKH,string hoTen,int slm, double dg)
        {
            MaKhachHang = maKH;
            HoTen = hoTen;
            SLM = slm;
            DonGia = dg;
        }

        public double TongTien()
        {
            return SLM * DonGia;
        }
        public override string ToString()
        {
            return string.Format("{0,15}{1,15}{2,15}{3,15}{4,15}",MaKhachHang,HoTen,SLM,DonGia,TongTien());
        }
    }
}
