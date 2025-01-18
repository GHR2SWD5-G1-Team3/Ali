namespace Linq
{
    public  class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1 ,2, 3 ,5,7,9,10,11,12};
            list.Ali(i => i % 2 == 0);
            Console.WriteLine("Hello, World!");
        }
       
    } }
