using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Calculation
    {
        

        public string CalculationLine { get; set; }
      

        public void SetCalculationLine()
        {
            string? input = Console.ReadLine();
            CalculationLine = input;

        }

        public void SetLastSymbolCalculationLine()
        {
            string input = "go"; 
            Console.WriteLine("Ввeдите символы, для выхода нипишите \"exit\"");
            while (input != "exit")
            {
                input = Console.ReadLine();
                if (input == "exit") break;
                CalculationLine += input;
            }
        }

        public void GetCalculationLine()
        {
            Console.WriteLine(CalculationLine);
        }

        public void DeleteLastSymbol()
        {
            int deleteSymbol = CalculationLine.Length - 1;
            CalculationLine = CalculationLine.Remove(deleteSymbol);
        }

        public void GetLastSymbol()
        {
            Console.WriteLine(CalculationLine[CalculationLine.Length - 1]);
        }


    }
}
