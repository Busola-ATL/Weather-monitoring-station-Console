namespace WeatherStationAssignment.WeatherFolder.Interfaces;
/// <summary>
/// IDisplay: A generic interface that will be implemented by all observer classes. 
/// </summary>
/// <typeparam name="T">Any type goes with</typeparam>
public interface IDisplay<T>
{
    void Display(T? parameter);
}