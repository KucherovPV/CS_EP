using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{

    public class Person
    {
        public int Num1 { get; set; }

        public int Num2 { get; set; }


        public Person(int Num1, int Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
        }
        public Person()
        {
           Num1 = 222;
           Num2 = 333;
        }



        ~Person()
        {
            Console.WriteLine($"{Num1} has been deleted");
            Console.WriteLine($"{Num2} has been deleted");
        }
    }
}