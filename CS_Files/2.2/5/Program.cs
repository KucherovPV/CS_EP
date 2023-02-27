namespace _5
{
    internal class Program
    {
        public static void Method()
        {
            Person tom = new Person();
        }
        static void Main(string[] args)
        {
            Method();
            GC.Collect();

        }
    }
}