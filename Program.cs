using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            int[] arr2 = new int[3] { 6, 4, 5 };
            Console.WriteLine(arr2[0]);

            string[] strings = { "code", "academy", "C#" };
            Console.WriteLine(strings[0]);

            //multi dimention
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 12;
            matrix[0, 1] = 24;
            matrix[1, 0] = 30;
            matrix[1, 1] = 41;
            Console.WriteLine(matrix[0,0]);

            //jugged array
            int[][] JuggedA = new int[3][];
            JuggedA[0] = new int[] { 21, 32, 32 };
            JuggedA[1] = new int[] { 37, 49 };
            JuggedA[2] = new int[] { 26, 37, 58, 19 };
            Console.WriteLine(JuggedA[0]);

            //Jagged array using initializer list
            /* int[][] JuggedA1 = new int[][] {
                 new int[] { 0, 20, 30 };
                 new int[] { 35, 45 };
                 new int[] { 61, 71, 81 }; 
              }; */

            
            //array sliceing
            int[] numbers = new int[] { 11,22,33,44,55 }; 

            int[] slice = numbers[2..4];
            Console.WriteLine(slice[0]);

            int[] slice1 = numbers[2..^2];
            Console.WriteLine(slice1[0]);

            int[] slice2 = numbers[..2];
            Console.WriteLine(slice2[0]);

            int[] slice3 = numbers[2..];
            Console.WriteLine(slice3[0]);


            //even or add
            int x = 10;
            string y =(x % 2 == 0) ? "even" : "odd";
            Console.WriteLine(y);

            //Null Value
            int? z = null;
            Console.WriteLine(z);


            string str = null;
            Console.WriteLine(str);

            //
            string str1 = null;
            str1 = (str1 == null) ? "coding" : str1;
            Console.WriteLine(str1);

            string str11 = null;
            str11 = str11 ?? "coding";
            Console.WriteLine(str11);

            //

            /*
            string str12 = null;
            Console.WriteLine(str12.ToUpper());
            */ //error

            //
            string str12 = null;
            Console.WriteLine(str12?.ToUpper());

            //statemrnts & block statement
            int k = 5;
            {
                int r = 6;
                Console.WriteLine(r);
            } 
            Console.WriteLine(y);

            //increment and Decrement
            int x1 = 1;
            int y1 = 2;
            //Prefix
            Console.WriteLine(++x1);
            Console.WriteLine(--y1);

            //Postfix
            Console.WriteLine(x1++);
            Console.WriteLine(y1--);

            //Conditioning
            //if statement: program to check the final projecr>=85% and absence >= 75% from first try
            

















        }
    }
}