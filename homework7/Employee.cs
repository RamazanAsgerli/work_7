using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public double Salary;

        public Employee()
        {
            
        }

        public Employee(string name)
        {
            Name = name;    
        }

        public Employee(string name,string surname) : this(name)
        {
            Surname = surname;
        }

        public Employee(string name,string surname,byte age) : this(name,surname)
        {
            Age = age;
        }

        public Employee(string name, string surname, byte age, string departmentname) : this(name,surname,age) 
        {
            DepartmentName = departmentname;
        }

        public Employee(string name, string surname, byte age, string departmentname,double salary) : this(name,surname,age,departmentname)
        {
            Salary = salary;
        }
        public void ShowFullData()
        {
            Console.WriteLine(GetFullData());
        }

        public string GetFullData()
        {
            return $"{this.Name} {this.Surname} {this.Age} {this.DepartmentName} {this.Salary}";
        }
    }
}

