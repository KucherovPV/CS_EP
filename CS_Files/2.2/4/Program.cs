namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ing = "go";
            Counter name;
            Console.WriteLine("Выберите начало отсчёта:\n1 - По умолчанию\n2 - Произвольное");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {

                name = new Counter();

            }
            else
            {
                Console.WriteLine("Введите начало отсчёта");
                input = Convert.ToInt32(Console.ReadLine());
                name = new Counter(input);
            }

            Console.WriteLine("Нажмите клавишу \"Enter\" для прибавления к числу еденицы\n" +
                    "Введите \"-\" чтобы отнять отнять еденицу\n" +
                    "Введите\"s\" чтобы узнать текущее состояние счетчика\n" +
                    "Введите\"exit\" чтобы выйти из счетчика");

            while (ing != "exit")
            {
                ing = Console.ReadLine();
                if (ing == "exit") break;

                switch (ing)
                {
                    case "":
                        name.Up();
                        break;
                    case "-":
                        name.Down();
                        break;
                    case "s":
                        int res = name.GetCount;
                        Console.WriteLine("Текущее состояние счётчика: " + res);
                        break;
                }

            }
        }
    }
}




