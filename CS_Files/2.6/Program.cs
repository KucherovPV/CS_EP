using Newtonsoft.Json;
using System.Net;

namespace WeatherApp;

public class Program
{
    public static void CheckTheWeather(string city)
    {
        //Console.WriteLine("Введите название города");
        //string? city = Console.ReadLine();

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(
            $"https://api.openweathermap.org/data/2.5/weather?q={city}" +
            $"&units=metric&lang=ru&APPID=e900fd9269316c95152b38fb38db8dc4");
        HttpWebResponse res = (HttpWebResponse)request.GetResponse();
        StreamReader read = new StreamReader(res.GetResponseStream());
        string response = read.ReadToEnd();
        WeatherResponse weatherNow = JsonConvert.DeserializeObject<WeatherResponse>(response);
        Console.WriteLine($"Погода в городе: {weatherNow.Name}\n" +
                          $"Температура: {weatherNow.Main.Temp}°C\n" +
                          $"Ощущается как: {weatherNow.Main.Feels_like}°C\n" +
                          $"Максимальная температура в пределах города: {weatherNow.Main.Temp_max}°C\n" +
                          $"Минимальная температура в пределах города: {weatherNow.Main.Temp_mine}°C\n" +
                          $"Погодные условия: {weatherNow.Weather[0].Main}\n" +
                          $"Дополнительные сведения о погодных условиях: {weatherNow.Weather[0].Description}\n" +
                          $"Скорость ветра: {weatherNow.Wind.Speed} М/С\n");
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите название города");
            string? city = Console.ReadLine();
            if (city == "Exit") break;
            CheckTheWeather(city);
        }
    }
}