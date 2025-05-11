using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Interfaces;

namespace WeatherStation.Classes
{
    public class WeatherData
    {
        private List<IObserver> _Observers;
        private float _Temperature;
        private float _Humidity;
        private float _Pressure;

        public WeatherData()
        {
            _Observers = new List<IObserver>();
        }
        public void RegisterObserver(IObserver observer)
        {
            _Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _Observers.Remove(observer);
        }

        public void NofifyObservers()
        {
            foreach (IObserver observer in _Observers)
            {
                observer.Update(_Temperature, _Humidity, _Pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NofifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _Temperature = temperature;
            _Humidity = humidity;
            _Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
