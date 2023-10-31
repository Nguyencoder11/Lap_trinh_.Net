using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTraTX1
{
    class NhanVien:Person
    {
        private string id;
        private string position;
        private double basic_salary;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public double BasicSalary
        {
            get { return basic_salary; }
            set { basic_salary = value; }
        }

        private double hesochucvu;
        public double HeSoChucVu
        {
            get { return hesochucvu; }
            set { hesochucvu = value; }
        }
        public NhanVien(string maNV, string hoten, int tuoi, string gioitinh, string diachi, string chucvu, double luongcb):base(hoten, tuoi, gioitinh, diachi)
        {
            Id = maNV;
            Position = chucvu;
            BasicSalary = luongcb;
            HeSoChucVu = TinhHeSoChucVu(chucvu);
        }

        private double TinhHeSoChucVu(string chucVu)
        {
            switch (chucVu.ToLower())
            {
                case "giám đốc" or "giam doc":
                    return 10;
                case "trưởng phòng" or "truong phong":
                case "phó giám đốc" or "pho giam doc":
                    return 6;
                case "phó phòng" or "pho phong":
                    return 4;
                default:
                    return 2;
            }
        }

        public override string ToString()
        {
            return string.Format("{0,12}", Id) + base.ToString() + string.Format("{0,15}{1,14}{2,14}", Position, BasicSalary, HeSoChucVu);
        }
    }
}
