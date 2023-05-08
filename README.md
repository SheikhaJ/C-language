# _first
اول يوم برمجة على C#




namespace Hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print the first line in c#
            Console.WriteLine("Hello, World!");

            //this is a single comment
            /* this is
            * a multipule
            line comments
            */

            //variable decralation
            string myname = "sheikha"; 
            Console.WriteLine(myname); 

            //there are different type of variables in c#

            string name = "sheikha"; //string used to create charecter, text. myname is a variable where we store the text
            int Num = 5;  // stores integers, without decimals like (147) (78)
            double DoubleNum = 5.99D; //stores floating point numbers, with decimals like (147.3) (78.00)
            char Letter = 'D';  //stores single characters,
            bool myBool = true; //stores values with two states: true or false

            //to create 2 integer and 2 object and use GetHashCode
            //Object.GetHashCode() used to insert and identify an object in a hash-based collection

            int a = 2;
            int b = 3;
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            //This method is used to find the hash code for this instance.

            object obj = new object(); // declaring an object
            object obj1 = new object();
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj1.GetHashCode());

            //String Concatenation: add variable together
            string name1 = "Sheikha";
            int age = 25;
            string job = " full stack";
            Console.WriteLine($"Hello " + name + "your age is " + age + " and you are " + job);
            //make it easier to print
            Console.WriteLine($"Hello {name} your age is {age} and you are{job}");


            //different between use dynamic & var

            dynamic s2 = "ss";
            s2 = 2;
            Console.WriteLine(s2.GetHashCode());

            /* 
             var s2 = "ss";
            s2 = 2;
            Console.WriteLine(s2.GetHashCode());  //it will give error because in var it will take s2 as string
             */

            /* Booleans
             * boolean type is declared with the bool keyword
             */

            int x = 15; //we use the assignment operator (=) to assign the value 15 to a variable called x
            int y = 20;

            bool equal = x == y;
            bool notEqul = x != y;
            bool lessThan = x < y;
            bool greaterThan = x > y;
            bool lessThanOrEqual = x <= y;
            bool greaterThanOrEqual = x >= y;

            Console.WriteLine(equal); //false
            Console.WriteLine(notEqul); //true
            Console.WriteLine(lessThan);  //true
            Console.WriteLine(greaterThan);  //false
            Console.WriteLine(lessThanOrEqual); //true
            Console.WriteLine(greaterThanOrEqual); //false

            /*logical xor operaters
             * ^ is logical exclusive or
            */
            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False








        }
    }
}
