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

            //int n = 10;
            //int[] a = new int[n];
            //Random random = new Random();
            //for (int i = 0; i < n; i++) // генерування масиву випадковими числами
            //    a[i] = random.Next(-100,100);
            //Console.WriteLine("Result:");//виведення елементів даного масиву

            //{

            //}
            int l = 10;
            int[] a = new int[l];
            
            //Console.WriteLine(a.Length);
            Random random = new Random();
            int i = 0;
            for (; i < l; i++)
            {
                a[i] = random.Next(-100,100);
                Console.WriteLine(a[i]);    
            }
            
                Console.ReadLine();
        }
    }
}
