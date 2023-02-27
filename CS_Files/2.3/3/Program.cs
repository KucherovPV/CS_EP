namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Calculation name = new Calculation();
           
            int res = 0;
            Console.WriteLine("Меню:\n1 - Ввести строку\n" +
                    "2 - прибавлять по символу к строке\n" +
                    "3 - вывод строки\n" +
                    "4 - получить последний символ\n" +
                    "5 - удалить последний символ\n" +
                    "6 - выход ");
            while (res != 6)
            {
                res =Convert.ToInt32(Console.ReadLine());
                
                switch (res)
                {
                    case 1:
                        name.SetCalculationLine();
                        break;
                    case 2:
                        name.SetLastSymbolCalculationLine();
                        break;     
                    case 3:
                        name.GetCalculationLine();
                        break;
                    case 4:
                        name.GetLastSymbol();
                        break;
                    case 5:
                        name.DeleteLastSymbol();
                        break;
                        
                }

            }
        }
    }
}