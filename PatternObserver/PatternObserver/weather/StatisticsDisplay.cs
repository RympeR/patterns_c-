using System;
using System.Collections.Generic;
using System.Text;

namespace PatternObserver.weather
{
    class StatisticsDisplay : Observer, DisplayElement
    {

        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            tempSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }

            display();
        }

        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " + (tempSum / numReadings) + "/" + maxTemp + "/" + minTemp);
        }
    }
}

