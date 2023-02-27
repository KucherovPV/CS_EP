using _2._4_1_;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student pat = new Student();

            int res = 0;
            Console.WriteLine("Меню выбора:\n" +
                "1-изменить ФИО\n" +
                "2-изменить дату рождения\n" +
                "3-изменить группу\n" +
                "4-вывод информации\n" +
                "5-выход из меню");

            while (res != 5)
            {
                res = Convert.ToInt32(Console.ReadLine());
                if (res == 5) break;

                switch (res)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите ФИО");
                            pat.Fio = Console.ReadLine();
                            Console.WriteLine($"новое ФИО: {pat.Fio}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите дату");
                            pat.Date = Console.ReadLine();
                            Console.WriteLine($"новая дата: {pat.Date}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите группу");
                            pat.Group = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"новая группа: {pat.Group}");
                            break;
                        }
                    case 4:
                        Console.WriteLine($"Фамилия: {pat.Fio}");
                        Console.WriteLine($"Дата рождения: {pat.Date}");
                        Console.Write($"Оценки: ");
                        foreach (var num in pat.Mark)
                        {
                            Console.Write($"{num} ");
                        }
                        Console.WriteLine(" ");
                        break;
                }
            }
        }
    }
}