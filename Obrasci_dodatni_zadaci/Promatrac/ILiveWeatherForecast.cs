using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public interface ILiveWeatherForecast
    {
        public void Register(IWeatherProcessor processor);
        public void Unregister(IWeatherProcessor processor);
        public void Notify();
    }
}
