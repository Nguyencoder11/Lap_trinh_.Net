using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    class Vehicles : IVehicle
    {
        private string id;
        private string maker;
        private string model;
        private int year;
        private string type;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Maker
        {
            get { return maker; }
            set { maker = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Vehicles()
        {
            Id = "";
            Maker = "";
            Model = "";
            Year = 2020;
            Type = "";
        }
        public Vehicles(string bienso, string hangsx, string tenxe, int namsx, string loaixe)
        {
            Id = bienso;
            Maker = hangsx;
            Model = tenxe;
            Year = namsx;
            Type = loaixe;
        }
        public virtual string NienHanSuDung()
        {
            if (Type == "Xe tải")
            {
                return "20 (năm)";
            }
            else if(Type == "Xe chở người")
            {
                return "30 (năm)";
            }
            else
            {
                return "Không xác định";
            }
        }

        public override bool Equals(object obj)
        {
            Vehicles vehicle = (Vehicles)obj;
            return Id.Equals(vehicle.Id);
        }

        public override string ToString()
        {
            return string.Format("{0,10}{1,15}{2,15}{3,12}{4,15}", Id, Maker, Model, Year, Type);
        }
    }
}
