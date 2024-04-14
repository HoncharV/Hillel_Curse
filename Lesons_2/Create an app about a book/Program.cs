namespace Create_an_app_about_a_book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Створіть програму,
            //яка виводить інформацію про книгу,
            //використовуючи форматований рядок.
            //Параметри книги -назва,
            //автор, рік та ціна.
            string name="Head First";
            string author="Andrew Stillman, Jennifer Green";
            string year = "2022";
            int price = 690;/*ціна в гривнях*/
            Console.WriteLine($"The title of the book:{name}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Year:{year}");
            Console.WriteLine("Price:"+Convert.ToInt32(price));
            Console.ReadLine();

        }
    }
}
