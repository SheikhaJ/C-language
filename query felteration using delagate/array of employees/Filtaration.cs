using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_of_employees
{
    internal class Filtaration
    {
        public delegate bool salarycondition(Employee e);
        public void Employeeprocess(Employee[] emp, string title, salarycondition con)
        {
            Console.WriteLine(title);
            foreach (Employee e in emp)
            {
                if (con(e))
                {
                    Console.WriteLine($"{e.Name} ,{e.Age}, {e.Salary}, {e.TotoalSales}");
                }
            }
        }
        
    }
}
