using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    class Truck : Vehicles
    {
        private double load;
        public double Load
        {
            get { return load; }
            set { load = value; }
        }

        public Truck() : base() {
            Load = 0;
        }

        public Truck(string bienso, string hangsx, string tenxe, int namsx, string loaixe, double taitrong) : base(bienso, hangsx, tenxe, namsx, loaixe)
        {
            Load = taitrong;
        }

        public override string ToString()
        {
            return string.Format("{0,10}{1,15}{2,15}{3,12}{4,15}{5,12}{6,12}{7,15}", Id, Maker, Model, Year, Type, "-", Load, NienHanSuDung());
        }
    }
}
