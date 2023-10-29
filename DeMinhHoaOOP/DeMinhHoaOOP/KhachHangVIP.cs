using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMinhHoaOOP
{
    class KhachHangVIP : KhachHang
    {
        private string qua_tang;
        public string QuaTang
        {
            get { return qua_tang; }
            set { qua_tang = value; }
        }

        public KhachHangVIP(string maKH, string hoTen, int soLuongMua, double donGia) : base(maKH, hoTen, soLuongMua, donGia)
        {
            QuaTang = XacDinhQuaTang();
        }

        private string XacDinhQuaTang()
        {
            double tongTien = TinhTongTien();
            if(tongTien < 1000)
            {
                return "Coupon 100";
            }
            else if(tongTien >= 1000 && tongTien <= 5000)
            {
                return "Coupon 200";
            }
            else
            {
                return "Coupon 500";
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0,15}", QuaTang);
        }
    }
}
