using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Interfaces;

namespace WeatherStation.Classes
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float _Temperature;
        private float _Humidity;
        private WeatherData _WeatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _Temperature = temperature;
            _Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _Temperature + "F degrees and " + _Humidity + "% humidity");
        }
    }
}
