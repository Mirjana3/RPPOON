using System;

public enum Weather { Synny, Rainy, Snowy}

namespace Obrasci_dodatni_zadaci
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherForecastProvider weatherProvider = new WeatherForecastProvider();
            WeatherStatistics weatherStatistics = new WeatherStatistics();
            WeatherDisplay weatherDisplay = new WeatherDisplay();

            weatherProvider.Register(weatherStatistics);
            weatherProvider.Register(weatherDisplay);

            weatherProvider.PeriodicUpdate();

            weatherProvider.Unregister(weatherStatistics);

            weatherProvider.PeriodicUpdate();
        }
    }
}
// Radi se o obrascu ponašanja, a to je Promatrač.
