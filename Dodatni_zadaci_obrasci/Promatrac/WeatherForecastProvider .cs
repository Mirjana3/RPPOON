using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public class WeatherForecastProvider : ILiveWeatherForecast
    {
        private DateTime lastUpdate = DateTime.Now;
        private Weather currentWeather = WeatherService.GetWeatherForecast();
        private List<IWeatherProcessor> processors = new List<IWeatherProcessor>();
        public void Register(IWeatherProcessor processor) 
        { 
            processors.Add(processor); 
        }
        public void PeriodicUpdate()
        {
            if (DateTime.Now >= lastUpdate.AddHours(1))
            {
                currentWeather = WeatherService.GetWeatherForecast();
                Notify();
            }
        }

        public void Unregister(IWeatherProcessor processor)
        {
            processors.Remove(processor);
        }

        public void Notify()
        {
            foreach(IWeatherProcessor processor in processors)
            {
                processor.OnWeatherChanged(currentWeather);
            }
        }
    }
}
