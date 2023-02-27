namespace _4
{
    internal class Counter
    {

        public int Count { get; set; }

        public Counter()
        {
            Random rand = new Random();
            Count = rand.Next(0, 10);

        }
        public Counter(int count)
        {
            this.Count = count;
        }
        public void Up()
        {
            Count++;
        }
        public void Down()
        {
            Count--;
        }
        public int GetCount
        {
            get { return Count; }
        }



    }
}
