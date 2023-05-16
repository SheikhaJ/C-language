using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_oop //inheritance & polymorphysem
{
    abstract class Animal  //create class with common attribute name and age and methode named move //make the class abstract 
    {
        public string Name { get; set; }
        public int age { get; set; }
            
          public virtual void move() //make it override which mean this methode does some behavior and different behavior in childe class
        {
            Console.WriteLine("moving "); 
        }

        public abstract void MakeSound(); //it will be error if we don't calle it in all childe classes
    }

        class Cat : Animal //create class from the base class it will inherte the attribute from animal class with addition attribute
        {
            public string gender;
            public void sound()
            {
                Console.WriteLine("meo!!");
            } 
            public override void move()
        {
            base.move();
            Console.WriteLine("hey i am moving now..");
        }

        public override void MakeSound()
        {
            Console.WriteLine("this is my voice !");
        }

        public override string ToString() //ToString() method. Types commonly override the Object. to return a string that represents the object instance
        {
            return $"my name is {this.Name}";
        }



    }




    class Dog : Animal //create another sub class
        {
            public string category;
            public void sound()
            {
                Console.WriteLine("woof!!");

            }
           public override void move()
            {
            base.move();
        Console.WriteLine("hey i am moving :) ");
             }

        public override void MakeSound()
        {
            Console.WriteLine("howhowhow!!!!");
        }
    }

        sealed class Eagle: Animal //sealed class to make it not inheitable
        {
            public string category;
        public void flying() //this class has different methode but it can move also because it  
        {
            Console.WriteLine("flying");
        }


           public override void move()
           {
            base.move();
             Console.WriteLine("hey i am moving");
            }

        public override void MakeSound()
        {
            Console.WriteLine("this is my voice !");
        }
    }
    
}
