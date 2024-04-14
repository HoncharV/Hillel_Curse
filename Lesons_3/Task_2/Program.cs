namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //2) Написати програму,
            //яка обчислює квадрат
            //будь - якого введеного числа(бажано використати Math).
            //Console.WriteLine("enter a number:");
            //int number=Convert.ToInt32(Console.ReadLine());
            //int squareRoot = number * number;
            //Console.WriteLine("Square root = "+ squareRoot);
            // варіат_2 з методом marh
            Console.WriteLine("re-enter the number");
            double a = Convert.ToDouble(Console.ReadLine());
            double s = Math.Pow(a,2);
            Console.WriteLine("Square root = " + s);
            Console.ReadKey();
        }
    }
}
