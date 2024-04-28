namespace hello_Random
{
    internal class Program
    {
        static void Main(string[] arge)
        {            //2) Програма загадує число від 1 до 146(привіт, Random).
                     //Користувач намагається вгадати його.
                     //У разі неправильної відповіді програма підказує «більше» або «менше»
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random random = new Random();

            int min = 1;
            int max = 146;
            int randomNumber = random.Next(min, max);
            int p;
           // Console.WriteLine(randomNumber);

            do
            {
                Console.WriteLine("guess the number");
                p = Convert.ToInt32(Console.ReadLine());
                
                if (p < randomNumber) Console.WriteLine("еLess больше");
                if (p > randomNumber) Console.WriteLine("more меньше");
                if (p == randomNumber) Console.WriteLine("Ура ви відгадали загадане число");
            }
            while (p != randomNumber);
            Console.ReadLine();
        }
    }
}
