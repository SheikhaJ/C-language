namespace BoilerPlate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arr<int> arr = new Arr<int>();
            arr.Add(3);
            arr.Add(1);
            arr.Add(2);
            arr.Add(8);
            arr.Add(9);
            arr.Display();
            arr.RemoveAt(0);
            Console.WriteLine(arr.Count());
            Console.WriteLine(arr.IsEmpty());
            arr.Display();


        }
    }
}