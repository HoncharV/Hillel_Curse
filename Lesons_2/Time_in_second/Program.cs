namespace Time_in_second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("drive an hour:");
            int houe=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("drive an minutes:");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("drive an seconds");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int justSeconds =( seconds + (minutes * 60)+(houe * (60*60)));
            Console.WriteLine("Just seconds:" + Convert.ToInt32(justSeconds));
           
            Console.ReadLine();
        }
    }
}
