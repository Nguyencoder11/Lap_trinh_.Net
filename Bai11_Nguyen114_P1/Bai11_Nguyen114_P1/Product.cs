using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11_Nguyen114_P1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int Brand { get; set; }

        public Product(int id, string name, double price, string[] colors, int brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }

        // Lay chuoi thong tin san pham gom ID, Name, Price
        override public string ToString() => $"{Id,3}{Name,12}{Price,5}{Brand,2}{string.Join(",",Colors)}";
    }
}
