using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtraTx1._5
{
    internal class KhachHangVIP : KhachHang
    {
        private string quatang;

        public string QuaTang 
        {
            get { return quatang; }
            set { quatang = value; }
        }

        public KhachHangVIP()
        {
            QuaTang = XacDinhQuaTang();
        }

        public string XacDinhQuaTang()
        {
            double tongtien = TongTien();
            if(tongtien > 0&& tongtien<1000) 
            {
                return "coupon 100";
            }
            else if(tongtien > 1000 && tongtien < 5000)
            {
                return "coupon 200";
            }
            else
            {
                return "coupon 500";
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("{0,15}",XacDinhQuaTang());
        }
    }
}
