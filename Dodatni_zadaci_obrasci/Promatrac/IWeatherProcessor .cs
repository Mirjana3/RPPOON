using System;
using System.Collections.Generic;
using System.Text;

namespace Obrasci_dodatni_zadaci
{
    public interface IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather);
    }
}
