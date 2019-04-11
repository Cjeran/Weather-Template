using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, min, max, currentTime, condition, location, windSpeed, sunrise, sunset,
                    precipitation, windDirection, humidity, visibility, night, eve, morn;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = max = min = sunrise = sunset
                = windSpeed = windDirection = precipitation = visibility = humidity = night = eve = morn = "";
        }
    }
}
