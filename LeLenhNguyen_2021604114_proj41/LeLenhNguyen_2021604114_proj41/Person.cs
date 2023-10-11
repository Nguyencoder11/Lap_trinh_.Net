using System;

namespace LeLenhNguyen_2021604114_proj41
{
    class Person
    {
        private string id;
        private string name;
        private int age;
        private string email;
        private string address;

        public void setId(string id)
        {
            this.id = id;
        }
        public string getId()
        {
            return id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return address;
        }
        public void CheckAge()
        {
            if (age >= 18)
            {
                Console.WriteLine("Ban du tuoi bau cu");
            }
            else
            {
                Console.WriteLine("Ban con nho");
            }
        }
        public void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap email: ");
            email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            address = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("Thong tin Person:");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Ten: {name}");
            Console.WriteLine($"Tuoi: {age}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Dia chi: {address}");
        }
    }
}