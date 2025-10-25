namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Eneter the product price \n");
            string price = Console.ReadLine();

            Console.WriteLine("Eneter the product discount (empty is equal to 15 %) \n");
            string discount = Console.ReadLine();

            int priceNumber = int.Parse(price);

            int discountNumber = 0;

            if (discount == string.Empty) { discountNumber = 15; } else { discountNumber = int.Parse(discount); }

            Console.WriteLine("Calculated Price with the given discount is : \n");
            Console.WriteLine(CalculateDiscount(priceNumber, discountNumber));


        }



        public static int CalculateDiscount(int itemPrice, int discountPercent = 15)
        {

            int discountvalue = (discountPercent * itemPrice) / 100;

            return itemPrice - discountvalue;
        }

    }
}
