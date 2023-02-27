namespace _2
{
    internal class Train
    {
        public string NamePlace { get; set; }
        public int Number { get; set; }
        public string Date { get; set; }

        public Train(string NamePlace, int Number, string Date)
        {
            this.NamePlace = NamePlace;
            this.Number = Number;
            this.Date = Date;
        }

        public int GetNumber
        {
            get
            {
                return Number;
            }
        }


        public string ShowTrain()
        {
            return ($"Пункт назначения: {NamePlace}\n" +
                $"Номер поезда: {Number}\n" +
                $"Время: {Date}");


        }
    }
}

