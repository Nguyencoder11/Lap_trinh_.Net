// See https://aka.ms/new-console-template for more information
using Bai11_Nguyen114_P1;
using System.Text.RegularExpressions;

var brands = new List<Brand>()
{
    new Brand{ID=1, Name="Vingroup"},
    new Brand{ID=2, Name="Samsung"},
    new Brand{ID=3, Name="FPT"}
};



var products = new List<Product>()
{
    new Product(1,"O to",400, new string[] {"Do", "Trang", "Den"}, 1),
    new Product(2,"Dien thoai",400, new string[] {"Den", "Xanh"}, 2),
    new Product(3,"May giat",500, new string[] {"Trang"}, 2),
    new Product(4,"Tu lanh",200, new string[] {"Trang", "Xam"}, 2),
    new Product(5,"Laptop",300, new string[] {"Xam", "Den", "Do"}, 3),
    new Product(6,"Dieu hoa",500, new string[] {"Trang"}, 2),
    new Product(7,"Xe may",600, new string[] {"Trang"}, 1),
};

// Menh de from va select
var ketqua = from product in products
             select product;
foreach(var product in ketqua)
    Console.WriteLine(product.ToString());
// Cu phap tuong tu
var res = products.Select(product => product);



// Chi lay ra 1 loai du lieu cua phan tu
var ketqua1 = from product in products
              select product.Name;
foreach (var productName in ketqua1)
    Console.WriteLine(productName);
// Tuong tu
var res1 = products.Select(product => product.Name);



// Tra ve kieu vo danh voi new
var ketqua2 = from product in products
              select new
              {
                  ten = product.Name.ToUpper(),
                  mausac = string.Join(',', product.Colors)
              };
foreach (var item in ketqua2)
{
    Console.WriteLine(item.ten + " - " + item.mausac);
}
// Tuong tu
var res2 = products.Select(product => new
{
    ten = product.Name.ToUpper(),
    mausac = string.Join(',', product.Colors)
});



// Menh de where
var  ketqua3 = from product in products
               where product.Price == 400
               select product;
foreach(var product in ketqua3) { Console.WriteLine(product.ToString()); }
// Tuong tu
var res3 = products.Where(product => product.Price == 400);



// in ra cac san pham gia>=500 va <600 hoac ten san pham co ky tu e
var ketqua4 = from product in products
              where (product.Price >= 500 && product.Price < 600) || product.Name.Contains('e')
              select product;
foreach(var product in ketqua4) { Console.WriteLine(product.ToString()); }
// Tuong tu
var res4 = products.Where(product => (product.Price >= 500 && product.Price < 600) || product.Name.Contains('e'));



// Menh de orderby
var ketqua5 = from product in products
              where product.Price <= 400
              orderby product.Price descending
              select product;
foreach (var product in ketqua5)
    Console.WriteLine($"{product.Name} - {product.Price}");
// Tuong tu
var res5 = (products.Where(product => product.Price<=400)).OrderByDescending(product => product.Price);



//Sap xep 
var ketqua6 = from product in products
              where product.Price <= 400
              orderby product.Price, product.Name descending
              select product;
foreach (var product in ketqua6)
    Console.WriteLine($"{product.Name} - {product.Price}");



// Menh de group va by
var ketqua7 = from product in products
              where product.Price <= 500
              group product by product.Brand;
foreach (var item in ketqua7)
{
    Console.WriteLine(item.Key);
    foreach(var product in item)
    {
        Console.WriteLine($"{product.Name} - {product.Price}");
    }
}
//Tuong tu
var res7 = (products.Where(product => product.Price <= 500)).GroupBy(product => product.Brand);




// Menh de join
var ketqua8 = from product in products
              join brand in brands on product.Brand equals brand.ID
              select new
              {
                  name = product.Name,
                  brand = brand.Name,
                  price = product.Price
              };
foreach (var item in ketqua8)
    Console.WriteLine($"{item.name,10}{item.price,4}{item.brand,12}");
// tuong tu
var res8 = products.Join(brands, p=>p.Brand, b=>b.ID,(p,b)=>{
    return new
    {
        name = p.Name,
        price = p.Price,
        brand = b.Name
    };
});