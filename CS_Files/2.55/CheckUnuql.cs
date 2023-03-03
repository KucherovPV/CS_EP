namespace WeatherApp
{
    public class CheckUnuql
    {
        public double Speed { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public double Temp_mine { get; set; }
        public double Temp_max { get; set; }

        public CheckUnuql(string name,double temp,double feelsLike,double tempMax,double tempMine, string mainDis, string description, double speed)
        {
          
        }
    }
}