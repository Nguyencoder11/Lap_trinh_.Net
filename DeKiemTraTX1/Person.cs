using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeKiemTraTX1
{
    class Person
    {
        private string name;
        private string address;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; } 
            set { address = value; }
        }
        // Them 3 bien thanh vien private: age, gender
        private int age;
        private string gender;
        // Bo sung them 3 thuoc tinh tuong ung voi 3 bien thanh vien
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Person(string hoten, int tuoi, string gioitinh, string diachi)
        {
            Name = hoten;
            Age = tuoi;
            Gender = gioitinh;
            Address = diachi;
        }

        public override string ToString()
        {
            return string.Format("{0,20}{1,10}{2,15}{3,15}", Name, Age, Gender, Address);
        }
    }
}
