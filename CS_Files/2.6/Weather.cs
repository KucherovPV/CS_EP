namespace WeatherApp;

public class MainInfo
{
    public double Temp { get; set; }
    public double Feels_like { get; set; }
    public double Temp_mine { get; set; }
    public double Temp_max { get; set; }
}

public class WeatherInfo
{
    public string Main { get; set; }
    public string Description { get; set; }
}

public class WindInfo
{
    public double Speed { get; set; }
}

public class WeatherResponse
{
    public string Name { get; set; }
    public MainInfo Main { get; set; }
    public WeatherInfo[] Weather { get; set; }
    public WindInfo Wind { get; set; }
}