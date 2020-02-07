using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver.weather
{
    public interface Observer
    {
        void update(float temp, float humidity, float pressure);
    }
}
