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
            
            int n = 10;
            int[] a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)// генерування масиву випадковими числами
            a[i] = rand.Next(-100, 100);
            Console.WriteLine("Результати:");//виведення елементів даного масиву,
                                             //та подвоєні елементи
            Console.WriteLine("#  елемент  ");

            for (int i = 0; i < n; i++)



            {

                Console.WriteLine(a[i]);

            }
            Console.ReadLine();
        }
    }
}
