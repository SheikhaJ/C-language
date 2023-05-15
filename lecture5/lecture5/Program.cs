
namespace lecture5
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //make a copy of employee class
            
            
            Console.WriteLine("Enter no of employees:"); //to get the size of array used to save each epmloyee information
            int empNumber = Convert.ToInt32(Console.ReadLine());

            Employee[] arr = new Employee[empNumber]; 

            for (int i = 0; i < empNumber; i++)
            {
                //get input information from user
                Console.WriteLine("First name:"); 
                employee.firstName = Console.ReadLine();

                Console.WriteLine("Last name:");
                employee.lastName = Console.ReadLine();

                Console.WriteLine("loggedHours:");
                employee.loggedHours = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wig:");
                employee.wig = Convert.ToDouble(Console.ReadLine());

                double totalSalary = employee.loggedHours * employee.wig; //claculate the total salary
                double taxSalary = totalSalary * Employee.TAX; //calculate the tax salary using constant value from employee class and calle it by the main class
                double netSalary = totalSalary - taxSalary; //calculate the net salary

                Console.WriteLine($"your salary ={netSalary}");
            } 





            /*Console.WriteLine("First employee salary:");
            
            employee.firstName = "joe";
            employee.lastName = "ter";
            employee.loggedHours = 10;
            employee.wig= 10;

            double totalSalary= employee.loggedHours * employee.wig;
            double taxSalary = totalSalary *   Employee.TAX;
            double netSalary = totalSalary - taxSalary;

            Console.WriteLine($"your salary ={netSalary}");*/








    }
}
}