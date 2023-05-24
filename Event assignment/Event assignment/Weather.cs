using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_assignment
{
    internal class Weather
    {
        public delegate void weatherchanged(Weather weather);



        public event weatherchanged onweatherchange;

        public int temperature;
        public string condition;

        public string Condition => this.condition;
        public int Temperature { get => this.temperature ; set=> this.temperature=value; }
        public Weather(int temprature) { 
            this.temperature = temprature;
            detectcondition(condition);
        }
        public void detectcondition(string Condition)
        {
            this.condition= Condition;
            if ( temperature <17) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"the weather changed to {temperature} it is cold and rainy");
            }
            else if( temperature >17 && temperature <25) {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"the weather changed to {temperature} it is cold but not rainy");

            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"the weather changed to {temperature} it is hot and melty");
            }
            Console.ForegroundColor= ConsoleColor.White;
        }

        public void watherchange(int newtemperature)
        {
            this.temperature = newtemperature;
            detectcondition(this.condition) ;

                if (onweatherchange != null)
            {
                onweatherchange(this);
            }

        }

    }
}
