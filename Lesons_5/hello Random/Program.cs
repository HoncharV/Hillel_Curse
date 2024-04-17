namespace hello_Random
{
    internal class Program
    {
        static void Main(string[] arge)
        {            //2) Програма загадує число від 1 до 146(привіт, Random).
                     //Користувач намагається вгадати його.
                     //У разі неправильної відповіді програма підказує «більше» або «менше»
            Random random = new Random();

            int min = 1;
            int max = 146;
            int randomNumber = random.Next(min, max);
            int p;

            do
            {
                Console.WriteLine("guess the number");
                p = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{randomNumber}");
                if (p < randomNumber) Console.WriteLine("more");
                if (p > randomNumber) Console.WriteLine("Less");
            }
            while (p != randomNumber);
        }
    }
}
