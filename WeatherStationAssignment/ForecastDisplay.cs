namespace WeatherStationAssignment.Weather;
using Weather.Interfaces;

/// <summary>
/// Another observer and decorator.
/// </summary>
public class ForecastDisplay : IDisplay<string>
{
    private double output;
    public void Display(String param){
        if(double.TryParse(param, out output))
        {
            switch(output){
            case <= -20.0: 
                Console.WriteLine("{0}°C: Raining! ", output);
                break;

            case <= -5.0: 
                 Console.WriteLine("{0}°C: Rainy day! ", output);
                 break;
            case <= 10.0: 
                 Console.WriteLine("{0}°C: Sunny and partly cloudy! ", output);
                 break;
            case <= 25.0: 
                 Console.WriteLine("{0}°C: Sunny day all week! ", output);
                 break;

            case <=35.0: 
                 Console.WriteLine("{0}°C: Walm! ", output);
                 break;
            default:
                throw new Exception("wrong input");
        };
        }
    }
}