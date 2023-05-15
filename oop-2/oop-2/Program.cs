using System.Xml;
using System.Xml.Schema;

namespace oop_2
{
    internal class Program
    {
        //create a methode to do specific task
        //declation of methode is <access modifier> <dataType> void methode name (parameter) {statements}
        public static void PrintLine(int cnt, string Pattern) //static methode which we can called directly from the class
        {
            for(int i = 0; i < cnt; i++)
            {
                Console.Write(Pattern);

            }
            Console.WriteLine();

        }
        public static void Swap(ref int x, ref int y)  //ref keyword allows the method to modify the value of the original argument but must be initialized before it is passed to the method
        {
            int temp = x;
            x = y; y = temp;
        
        }

        public static void SumMul(int x, int y, out int S, out int M) //out keyword: the value does not need to be initialized before it is passed to the method
        {
            S = x+y;
            M = x*y;
        }


        static void Main(string[] args)
        {
            int x, y,z;
            Console.WriteLine("Please enter the first number : ");
            x = Convert.ToInt32(Console.ReadLine());
            PrintLine(10, "*"); //the methode which we created before we calle it directly to do task

            Console.WriteLine("Please enter the second number : ");
            y = Convert.ToInt32(Console.ReadLine());
            PrintLine(20, "&");

            Console.WriteLine("Please enter the third number : ");
            z = Convert.ToInt32(Console.ReadLine());
            PrintLine(10, "____");  



            int a =9, b = 6;
                Swap(ref a, ref b);
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");


            int q=2, r=3, Sresult, Mresult;
            SumMul(q, r, out Sresult, out Mresult);
            Console.WriteLine($"sum of q and r = {Sresult}");
            Console.WriteLine($"multiplication between q and r = {Mresult}");

            //call calculator class
            calculator cal = new calculator(); //create object which is a copy of calculator class
            int i=4, j=5;
            double n = 1.2, l = 10.9;
            string e = "AAA", p = "DDD";
            Console.WriteLine(cal.add(i,j));
            Console.WriteLine(cal.add(n,l));
            Console.WriteLine(cal.add(e,p));

            //call Person class and create a copy of it 
            Person A = new Person();
            A.FirstName = "Sheikha";
            A.LastName = "Aljabri";
            A.age = 25;
            A.isMarige = false;
            A.job = "job seeker";
            A.Address = "Samail";
            Console.WriteLine($"name: {A.FirstName} {A.LastName}, age: {A.age}, is marige? {A.isMarige}, job: {A.job}, from: {A.Address}");         



        }
    }
}