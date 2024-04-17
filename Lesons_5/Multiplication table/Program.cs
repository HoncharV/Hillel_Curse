namespace Multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Таблиця множення
            for (int i = 1;i <= 10; i++) // 1*1=1
            {
               for (int j = 1; j <=10; j++)
               {
                   Console.WriteLine($"{i} * {j} = {i*j}");
               }
            }
            Console.ReadKey();
        }
    }
}
