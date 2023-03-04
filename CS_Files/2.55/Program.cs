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
        var ress = $"Погода в городе: {weatherNow.Name}\n" +
                   $"Температура: {weatherNow.Main.Temp}°C\n" +
                   $"Ощущается как: {weatherNow.Main.Feels_like}°C\n" +
                   $"Максимальная температура в пределах города: {weatherNow.Main.Temp_max}°C\n" +
                   $"Минимальная температура в пределах города: {weatherNow.Main.Temp_mine}°C\n" +
                   $"Погодные условия: {weatherNow.Weather[0].Main}\n" +
                   $"Дополнительные сведения о погодных условиях: {weatherNow.Weather[0].Description}\n" +
                   $"Скорость ветра: {weatherNow.Wind.Speed} М/С\n";
        
        string path = "C:\\Users\\pavel\\Desktop\\UserRequest.txt";
        
        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(ress);
        }
    }

    public static void ShowRequest()
    {
        string path = "C:\\Users\\pavel\\Desktop\\UserRequest.txt";
        using (StreamReader reader = new StreamReader(path))
        {
            string? line;
            while ((line =  reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите название города, \"exit\" для выхода, \"Show\" для показа истории запросов");
            string? city = Console.ReadLine();
            if (city == "Exit") break;
            switch (city)
            {
                case "Show":
                    ShowRequest();
                    break;
                default: CheckTheWeather(city);
                    break;
            }
        }
    }
}
