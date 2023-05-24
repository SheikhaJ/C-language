namespace Event_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather(14);
            weather.onweatherchange += Weather_onweatherchange;
            weather.watherchange(27);
            weather.watherchange(19);

        }

        private static void Weather_onweatherchange(Weather weather)
        {
           // Console.WriteLine($"wather is changed to {weather.Temperature} and the condition is {weather.Condition}");
        }

        
    }
}