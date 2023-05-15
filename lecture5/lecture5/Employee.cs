using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture5
{
    public class Employee
    {
        public const double TAX = 0.03; //constant: hold fixid value
        public string firstName; //public is access modifier , can access and modified from class memeber
        public string lastName;
        public double loggedHours;
        public double wig;
        public int addOne(int x) //methode: add function
        {
            return x+1;
        }

    }
    
}
