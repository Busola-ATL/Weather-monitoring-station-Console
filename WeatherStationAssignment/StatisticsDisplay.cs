namespace WeatherStationAssignment.Weather;
using Weather.Interfaces;

/// <summary>
/// Another observer. It displays weather statistics.
/// </summary>



public class StatisticsDisplay : IDisplay<string>
{
    double solution;
    IList<double> sumParameters = new List<double>();
    public void Display(string parameter)
    {
        if(double.TryParse(parameter, out solution))
            sumParameters.Add(solution);
        else
            throw new Exception("String can't be passed to double");

        Console.WriteLine("Average temperature: "+ sumParameters.Average());
        Console.WriteLine("Maximum temperature: "+ sumParameters.Max());
        Console.WriteLine("Minimum temperature: "+ sumParameters.Min());

    }
    
}