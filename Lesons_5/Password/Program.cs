namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Напишіть програму, яка «запитуватиме» правильний пароль,
            //доки він не буде введений. Правильний пароль нехай буде "root".
            //Якщо пароль неправильний, програма повинна сказати "Неправильний пароль!
            string p;
            do
            {
                Console.WriteLine("enter password!!!");
              p=Console.ReadLine();
                Console.WriteLine("The password is incorrect, please enter it again");
            }
            while (p!= "root");
        }
    }
} 
