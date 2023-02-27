using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_3_
{
    public class Nums
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }

        public Nums(int Num1,int Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
            
        }

       

        public void Sum()
        {
            Console.WriteLine($"Сумма чисел: {Num1 + Num2}");
           
        }
        public void ShowNum()
        {
            Console.WriteLine("Первое число равно: " + Num1);
            Console.WriteLine("Второе число равно: " + Num2);

        }
        public void ChangeNum()
        {  
         int  input = 0;
            while(input != 3) {
                Console.WriteLine("1 - Изменить первое число\n2 - Изменить второе число\n3 - Выйти в основное меню");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 3) break;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите желаемое число ");
                        input = Convert.ToInt32(Console.ReadLine());
                        Num1 = input;
                        Console.WriteLine("Первое число равно: "+Num1);

                        break;
                    case 2:
                        Console.WriteLine("Введите желаемое число ");
                        input = Convert.ToInt32(Console.ReadLine());
                        Num2 = input;
                        Console.WriteLine("Второе число равно: " + Num2);
                        break;
                    case 3:
                        break;
                }
                    }
        }
        public void WhoIsBigger()
        {
            if (Num1 > Num2)
            {
                Console.WriteLine("Наибольшее число" + Num1);
            }
            else
            {
                Console.WriteLine("Наибольшее число" + Num2);
            }
        }

        public void Menu()
        {
           
        }
    }
}
