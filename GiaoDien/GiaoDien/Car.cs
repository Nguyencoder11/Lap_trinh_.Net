using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    class Car : Vehicles
    {
        private int seats;
        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public Car() : base()
        {
            Seats = 0;
        }

        public Car(string bienso, string hangsx, string tenxe, int namsx, string loaixe, int socho) : base(bienso,hangsx, tenxe, namsx, loaixe)
        {
            Seats = socho;
        }

        public override string NienHanSuDung()
        {
            if(Seats < 0)
            {
                return "Không áp dụng";
            }
            else
            {
                return "30 (năm)"; 
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("{0,12}", Seats);
        }
    }
}
