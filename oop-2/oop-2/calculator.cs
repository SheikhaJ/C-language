using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2
{
    //create class with name calculator
    internal class calculator
    { 
        public int add(int x, int y) => x + y;
        
        public double add(double x, double y) => x + y; // => same as return but the body in one line (lamda exprision)
        
        public string add(string x, string y) => x + y; //methode signature: same methode with different parameter

        public string isEven(int v) => (v % 2 == 0) ? "even" : "odd"; //


    }
    

}
