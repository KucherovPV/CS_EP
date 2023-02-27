namespace _2._4_1_
{
    internal class Student
    {
        public string Fio
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }
        public int Group
        {
            get;
            set;
        }
        public int[] Mark
        {
            get;
            set;
        }
        public Student()
        {
            Fio = "Кучеров Павел Витальевич";
            Date = "16.08.2004";
            Group = 623;
            Mark = new int[5] { 5, 5, 5, 4, 5 };
        }
    }
}
