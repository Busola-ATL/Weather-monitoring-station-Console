namespace WeatherStationAssignment.Weather;
using Weather.Interfaces;

/// <summary>
/// CurrentConditionsDisplay: This observer displays the current weather conditions.
/// </summary>

public class CurrentConditionsDisplay : IDisplay<string>
{
    private double result;
    private DateTime dateTime = new DateTime();
    public  void Display(string param){

        if(double.TryParse(param, out result))
        {
            switch(result){
            case <= -20.0: 
                Console.WriteLine("{0}°C: Extreme Cold", result);
                break;

            case <= -5.0: 
                 Console.WriteLine("{0}°C: Cold", result);
                 break;
            case <= 10.0: 
                 Console.WriteLine("{0}°C: Cool", result);
                 break;
            case <= 25.0: 
                 Console.WriteLine("{0}°C: Mild", result);
                 break;

            case <=35.0: 
                 Console.WriteLine("{0}°C: Walm", result);
                 break;
            case <=70.0: 
                 Console.WriteLine("{0}°C: Extremely warm", result);
                 break;
            default:
                throw new Exception("wrong value inserted");
        };
        }
        Console.WriteLine("Today's Date: "+ dateTime.Date);
        Console.WriteLine("Current Time: "+ dateTime.TimeOfDay);
    }

}