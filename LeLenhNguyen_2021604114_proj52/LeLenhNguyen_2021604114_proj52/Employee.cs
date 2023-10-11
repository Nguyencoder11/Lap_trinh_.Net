using System;

namespace LeLenhNguyen_2021604114_proj52
{
    class Employee
    {
        private string id, name;
        private int age, workingdays;
        private double salary;

        private const int price = 50;

        public Employee(string id, string name, int age, int workingdays) {
            this.id = id;
            this.name = name;
            this.age = age;
            this.workingdays = workingdays;
            this.salary = CalculateSalary();
        }

        private int CalculateSalary()
        {
            return workingdays * price;
        }

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
        public int getAge() { 
            return age;
        }
        public void setWorkingDays(int workingdays) { 
            this.workingdays = workingdays;
            this.salary = CalculateSalary();
        }
        public int getWorkingDays()
        {
            return workingdays;
        }
        public double getSalary()
        {
            return salary;
        }
        public void Input()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Working Days: " + workingdays);
            Console.WriteLine("Salary: " + salary);
        }

        public void Output()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Working Days: " + workingdays);
            Console.WriteLine("Salary: " + salary);
        }
    }
}