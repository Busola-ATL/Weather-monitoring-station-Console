namespace WeatherStationAssignment.WeatherFolder;
using WeatherFolder.Interfaces;

/// <summary>
///  A factory for creating different types of displays.
/// </summary>
public static class WeatherStation_
{
    public static IDisplay<string> CreateDisplay(string command){
        switch(command){
            case "CurrentConditionsDisplay":
                return new CurrentConditionsDisplay();
            
            case "StatisticsDisplay":
                return new StatisticsDisplay();
            case "ForecastDisplay":
                return new ForecastDisplay();
            default:
                throw new ArgumentException("Input one of the following to carry out operation: CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay");
        }
    }
}