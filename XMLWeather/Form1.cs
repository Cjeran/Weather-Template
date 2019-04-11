﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //date, currentTemp, min, max, currentTime, condition, location, windSpeed, sunrise, sunset, precipitation, windDirection, humidity, visibility, night, eve, morn;

                //create a day object
                Day d = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("precipitation");
                d.precipitation = reader.GetAttribute("value") + "mm";

                reader.ReadToFollowing("windDirection");
                d.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                d.windSpeed = reader.GetAttribute("mps") + " mps";

                reader.ReadToFollowing("temperature");
                d.currentTemp = reader.GetAttribute("day") + "°C";
                d.min = reader.GetAttribute("min") + "°C";
                d.max = reader.GetAttribute("max") + "°C";
                d.night = reader.GetAttribute("night") + "°C";
                d.eve = reader.GetAttribute("eve") + "°C";
                d.morn = reader.GetAttribute("morn") + "°C";

                reader.ReadToFollowing("humidity");
                d.humidity = reader.GetAttribute("value") + reader.GetAttribute("unit");

                //TODO: if day object not null add to the days list
                if (d.date == null) { break; }
                days.Add(d);
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
        }


    }
}
