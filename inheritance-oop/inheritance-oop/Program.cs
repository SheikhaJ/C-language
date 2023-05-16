namespace inheritance_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object from cat class
            Cat cat = new Cat();
            cat.Name = "lolo";
            cat.age = 5;
            cat.gender = "femal";
            Console.WriteLine($"{cat.Name} {cat.age} {cat.gender} ");
            cat.move();
            cat.sound();
            cat.MakeSound();
            Console.WriteLine(cat.ToString()); 

            //create object from Dog class
            Dog dog = new Dog();
            dog.Name = "ddd";
            dog.age = 10;
            dog.category = "rrr";
            Console.WriteLine($"{dog.Name} {dog.age} {dog.category} ");
            dog.move();
            dog.sound();
            dog.MakeSound();






        }
    }
}