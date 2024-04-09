﻿using WeatherStationAssignment.WeatherFolder;

var weatherData = new WeatherData<string>();
Console.WriteLine("Please enter any of the following commands: (CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay: ");

    var obs1 = Console.ReadLine()?? "";
    weatherData.Subscribe(WeatherStation_.CreateDisplay(obs1));
    weatherData.Value = Console.ReadLine()?? "";
