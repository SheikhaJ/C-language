namespace array_of_employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); {

                new Employee { Name = "employee1", Age = 25, Salary = 1234m, TotoalSales = 122333m };
                new Employee { Name = "employee2", Age = 35, Salary = 987653m, TotoalSales = 1280m };
                new Employee { Name = "employee3", Age = 20, Salary = 12234m, TotoalSales = 122m };
                new Employee { Name = "employee4", Age = 64, Salary = 6234m, TotoalSales = 666333m };
            };

            Filtaration filtaration = new Filtaration(); {
                filtaration.Employeeprocess(employee, "employee who is older than 25", (employee) => employee.Age > 25);
                filtaration.Employeeprocess(employee, "employee who is his salary more than 15000", (employee) => employee.Salary > 15000);
                filtaration.Employeeprocess(employee, "employee who is his total sale more than 4000", (employee) => employee.TotoalSales > 4000);
            };

        }

    } 
}
  


