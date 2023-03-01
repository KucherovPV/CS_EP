using System;

namespace GarageConsoleApp
{
    /// <summary>
    /// Класс Program
    /// здесь описываем логику приложения
    /// вызываем нужные методы пишем обработчики и тд
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Вызовем метод для получения данных о водителях
            // DatabaseRequests.GetDriverQuery();
            Console.WriteLine();
            // Добавим нового водителя в БД
            // DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));
            // Вызовем метод для получения данных о водителях
            // DatabaseRequests.GetDriverQuery();

            // Вызовем метод для получения данных о типах автомобилей
            // DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();
            // Добавим новый тип автомобиля в БД
            // DatabaseRequests.AddTypeCarQuery("Воздушный");
            // Вызовем метод для получения данных о типах автомобилей
            //  DatabaseRequests.GetTypeCarQuery();


            //1 Просмотр и добавление типов машин
            //DatabaseRequests.GetTypeCarQuery();
            //DatabaseRequests.AddTypeCarQuery("");

            //2 Просмотр и добавление водителей и их прав
            //DatabaseRequests.GetDriverRightsCategoryQuery(2);
            // DatabaseRequests.GetDriverQuery();


            //3 Просмотр и добавление машин;
            //   DatabaseRequests.GetCarQuery();
            // DatabaseRequests.GetCarQuery();

            // 4 Просмотр и добавление маршрутов
            // DatabaseRequests.GetItineraryQuery();
            // DatabaseRequests.GetItineraryQuery();

            // 5 Просмотр и добавление рейсов;
            // DatabaseRequests.GetRouteQuery();
            // DatabaseRequests.AddRouteQuery();
            Console.WriteLine("1 - добавить новый тип машины\n" +
                              "1.1 - вывести типы машин\n" +
                              "2 - добавить водителя\n" +
                              "2.1 - вывести водителей\n" +
                              "3 - добавить машину\n" +
                              "3.1 - вывести машины\n" +
                              "4 - добавить маршрут\n" +
                              "4.1 - вывести маршруты\n" +
                              "5 - добавить рейс\n" +
                              "5.1 - вывести рейсы\n" +
                              "\"Close\" для завершения работы\n");

            string input = "";

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Close") break;
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Введите маршрут или \"Выход\" для выхода");
                        input = Console.ReadLine();
                        if (input == "Выход") break;
                        DatabaseRequests.AddTypeCarQuery(input);
                        break;

                    case "1.1":
                        Console.WriteLine("Типы машин");
                        DatabaseRequests.GetTypeCarQuery();
                        break;

                    case "2":
                        Console.WriteLine("1 - добавить водителя\n2 - добавить категорию водителю");
                        string? case2in = Console.ReadLine();
                        switch (case2in)
                        {
                            case"1":
                                Console.WriteLine("Введите имя или \"Выход\" для выхода");
                                string? firstname = Console.ReadLine();
                                if (firstname == "Выход") break;
                                Console.WriteLine("Введите фамилию");
                                string? surname = Console.ReadLine();
                                Console.WriteLine("Введите дату рождения");
                                string? date = Console.ReadLine();
                                DatabaseRequests.AddDriverQuery(firstname, surname, date);
                                break;
                            case "2":
                                Console.WriteLine("id водителя или \"Выход\" для выхода");
                                string? idDrivers = Console.ReadLine();
                                if (idDrivers == "Выход") break;
                                Console.WriteLine("id категории");
                                int idCat = Convert.ToInt32(Console.ReadLine()); 
                                DatabaseRequests.AddDriverRightsCategoryQuery(Convert.ToInt32(idDrivers),idCat);
                                break;
                        }
                        break;
                        
                    case "2.1":
                        
                        DatabaseRequests.GetDriverRightsCategoryQuery();
                        Console.WriteLine("");
                        DatabaseRequests.GetDriverQuery();
                        break;

                    case "3":
                        Console.WriteLine("Введите новый автомобиль");
                        Console.WriteLine("введите тип машины или \"Выход\" для выхода ");
                        string? typeCar =Console.ReadLine();
                        if (typeCar == "Выход") break;
                        Console.WriteLine("введите марку и модель машины");
                        string? nameCar = Console.ReadLine();
                        Console.WriteLine("введите госномер");
                        string? stateNumber = Console.ReadLine();
                        Console.WriteLine("введите кол-во пассажиров");
                        int numPass = Convert.ToInt32(Console.ReadLine());
                        DatabaseRequests.AddCarQuery(Convert.ToInt32(typeCar), nameCar, stateNumber, numPass);
                        break;

                    case "3.1":
                        DatabaseRequests.GetCarQuery();
                        break;

                    case "4":
                        Console.WriteLine("Введите имя маршрута или \"Выход\" для выхода");
                       string? res = Console.ReadLine();
                        if (res == "Выход") break;
                        DatabaseRequests.AddItineraryQuery(res);
                        break;

                    case "4.1":
                        DatabaseRequests.GetItineraryQuery();
                        break;

                    case "5":
                        Console.WriteLine("Введите id водителя или \"Выход\" для выхода");
                        string? idDriver = Console.ReadLine();
                        if (idDriver == "Выход") break;
                        Console.WriteLine("Введите id атомобиля");
                        int idCar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите id маршрута");
                        int idIti = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите кол-во пассажиров");
                        numPass = Convert.ToInt32(Console.ReadLine());
                        DatabaseRequests.AddRouteQuery(Convert.ToInt32(idDriver), idCar, idIti, numPass);
                        break;

                    case "5.1":
                        DatabaseRequests.GetRouteQuery();
                        break;
                }

                {
                }
            }
        }
    }
}