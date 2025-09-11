using ObserverPattern.Interfaces;
using System;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float totalTemp = 0;
        private float maxTemp = float.MinValue;
        private float minTemp = float.MaxValue;
        private int measurements = 0;

        public StatisticsDisplay(Subject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            totalTemp += temp;
            measurements++;

            maxTemp = Math.Max(maxTemp, temp);
            minTemp = Math.Min(minTemp, temp);

            Display();
        }

        public void Display()
        {
            float avgTemp = totalTemp / measurements;
            Console.WriteLine($"Gemiddelde: {avgTemp:F1}°C | Max: {maxTemp:F1}°C | Min: {minTemp:F1}°C");
        }
    }
}
