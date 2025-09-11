using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            if (humidity < 60 && temperature > 20)
            {
                Console.WriteLine("Mooi weer komt er aan");
            }
            else if (humidity > 80)
            {
                Console.WriteLine("Trek je paraplu’s uit de kast");
            }
            else
            {
                Console.WriteLine("Het weer blijft stabiel");
            }
        }
    }
}