namespace Calculation_of_the_amount_of_the_discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price =369;
            int discount = 18;
            int reducedPrice =price-((price / 100) *  discount);
                Console.WriteLine($"Price:{price}");
            Console.WriteLine($"Discount:{discount}");
            Console.WriteLine($"Reduced prsce:{reducedPrice}");
            Console.ReadLine();
        }
    }
}
