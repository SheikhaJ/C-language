using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace phone_book
{
    internal class Program
    {
        class phonebook
        {
            public string[] Name; //declaration only
            private string[] number;
            private int len;

            public phonebook(int _len) //constructer take the length of phon book as parameter and inisialize the name and number accordingly
            {
                this.len = _len;
                Name = new string[this.len];
                number = new string[this.len];
            }
            //struct

            //property
            /* public void setValues(int index, string name, string number) //set
             {

                 if(index >= 0 && index <= name.Length) //to check user will not give negitave value or greater than length
                 {

                         this.name[index] = name;
                         this.number[index] = number;

                 }



             } 
             public string getValues(string name) //get
             {
                 for (int i = 0; i < this.len; i++)
                 {
                     if (this.name[i] == name)
                     {
                         return this.number[i];
                     }
                 }
                 return "not found";
             } */

            //indexer //It enables you to access the elements of an object as if they were elements of an array or a collection.
            public string this[int index, string name] //defined using this keyward and index parameter
            {

                set //assignt number
                {
                    if (index >= 0 && index <= len)
                    {

                        this.Name[index] = name;
                        this.number[index] = value;

                    }

                }
                    get //search for name
                {
                    for (int i = 0; i < this.len; i++)
                    {
                        if (this.Name[i] == name)
                        {
                            return this.number[i];
                        }
                    }
                    return "not found";
                }
            }
            
                public string this[ string name] //second index one parameter 
            {

                get
                {
                    for (int i = 0; i < this.len; i++)
                    {
                        if (this.Name[i] == name)
                        {
                            return this.number[i];
                        }
                    }
                    return "not found";
                }
            }

        }

    

        static void Main(string[] args)
        {
            phonebook ph = new phonebook(3); //length is 3
 
            //prop
            // ph.setValues(0, "shekha", "77788899");
            // ph.setValues(1, "fatma", "77766699");
            //ph.setValues(2, "safa", "77755599");
            // Console.WriteLine(ph.getValues("fatma"));

            //indexer
            ph[0, "sheikha"] = "12345";
            ph[1, "fatma"] = "1234";
            ph[2, "safa"] = "001234";
            Console.WriteLine(ph[2,"safa"]); //search for safa number in index 2
            Console.WriteLine(ph[1, "fatma"]);
            Console.WriteLine(ph["sheikha"]); //search for number by name using the second index which take name as parameter


        }
    }
}
