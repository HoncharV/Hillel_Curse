namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            //2) Написати програму,
            //яка обчислює квадрат
            //будь - якого введеного числа(бажано використати Math).
            Console.WriteLine("enter a number:");
            int number=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.BigMul.SquareRoot(number));
            //Console.WriteLine(number);
            int squareRoot = number * number;
            Console.WriteLine("Square root = "+ squareRoot);
            Console.ReadKey();
        }
    }
}
