namespace homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Ramazan";
            employee.Surname = "Asgerli";
            employee.Age = 20;
            employee.DepartmentName = "IT";
            employee.Salary = 3500;
            
            Employee employee1 = new Employee();
            employee1.Name = "Niyaz";
            employee1.Surname = "Soltanov";
            employee1.Age = 21;
            employee1.DepartmentName = "Marketing";
            employee1.Salary = 4000;

            Employee employee2 = new Employee();
            employee2.Name = "Rehman";
            employee2.Surname = "Murselov";
            employee2.Age = 20;
            employee2.DepartmentName = "Sales";
            employee2.Salary = 5500;

            Employee employee3 = new Employee();
            employee3.Name = "Ramazan";
            employee3.Surname = "Asgerli";
            employee3.Age = 20;
            employee3.DepartmentName = "Finance";
            employee3.Salary = 5000;

            Department department = new Department();
            int n;
            department.AddEmployee(employee);
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);

            department.ShowEmployeeInfo();
            do
            {
                Console.WriteLine("1. Employee elave et");
                Console.WriteLine("2. Bütün işçilere bax");
                Console.WriteLine("3. Maaş araliğina göre işçileri axtarış et");
                Console.WriteLine("0. Proqrami bitir");
                Console.Write("Seçim et: ");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Employee employees = new Employee();
                        Console.WriteLine("name:");
                        employees.Name = Console.ReadLine();
                        Console.WriteLine("surname:");
                        employees.Surname = Console.ReadLine();
                        Console.WriteLine("age:");
                        employees.Age = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("department name:");
                        employees.DepartmentName = Console.ReadLine();
                        Console.WriteLine("Salary:");
                        employees.Salary = Convert.ToInt32(Console.ReadLine());
                        department.AddEmployee(employees);
                        break;
                    case 2:
                        Console.WriteLine("Bütün işçilərin məlumatları:");
                        department.ShowEmployeeInfo();
                        break;
                    case 0:
                        Console.WriteLine("proqrami bitir");
                        break;
                    default:
                        Console.WriteLine("sehv secim");
                        break;
                }
            } while (n != 0);
        }
    }
}
