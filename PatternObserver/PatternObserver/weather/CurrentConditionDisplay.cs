using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver.weather
{
    public class CurrentConditionDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display(); // Not very good to call display() inside of update(). See MVC
        }

        public void display()
        {
           Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }
    }

}

