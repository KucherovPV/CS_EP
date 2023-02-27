namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Train> trains = new List<Train>();
            trains.Add(new Train("Kolpashevo", 15, "21.1.51"));
            trains.Add(new Train("Tomsk", 13, "11.11.11"));

            int input = 0;
            Console.WriteLine("Menu\nВведите номер поезда или \"1\" для выхода\n");

            while (input != 1)
            {
                string show = "";
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1) break;
                foreach (Train numTrain in trains)
                {
                    if (numTrain.GetNumber == input)
                    {
                        show = numTrain.ShowTrain();
                        break;
                    }
                }

                if (show != "")
                {
                    Console.WriteLine(show);
                }
                else
                {
                    Console.WriteLine("Такого поезда нет");
                }

            }
        }

    }

}
