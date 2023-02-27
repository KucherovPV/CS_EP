using System.Reflection.Metadata;

namespace _1
{

    internal class Worker
    {
        
        public string Name { get; set;}
        
        public string Surname { get; set; }

        public int Rate { get; set; }
    
        public int Days { get; set; }
        
                          
         public Worker()
        {
          Name = "Patrick";
           Surname = "Bateman";
           Rate = 1767;
           Days = 23;
        }   
      public void GetSalary()
        {
            Console.WriteLine($"Зарплата сотрудника {Name} {Surname} составляет {Rate*Days}");
        }


    }
}
