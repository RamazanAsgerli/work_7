using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    internal class Department
    {
        public Employee[] Employees = new Employee[] { };


        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee; 
        }

        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public void ShowEmployeeInfo()
        {
            for(int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i].GetFullData()}");
            }
        }
    }

    
}
