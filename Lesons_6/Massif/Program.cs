namespace Massif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Задати масив із 10 елементів.
            //Заповнити цей масив рандомними числами від -100 до 100.
            //Знайти кількість додатніх чисел у масиві.
            //Вивести на екран масив і кількість порахованих чисел.


            int minValue = -100;
            int maxValue = 100;
            int arraySize = 10;

            int[] randomArray = new int[arraySize];

            Random rand = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                randomArray[i] = rand.Next(minValue, maxValue);
                Console.WriteLine(randomArray[i]);
            }
            
            Console.ReadKey();
        }
            
    }
}
