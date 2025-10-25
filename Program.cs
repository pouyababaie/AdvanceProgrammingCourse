namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Eneter the Centigerad Number \n");
            string input = Console.ReadLine();

            int inputNumber = int.Parse(input);

            Console.WriteLine($"The Reveresed Number is : {reverseNumWithwhile(inputNumber)}" );

            Console.ReadLine();
        }

        public static int reverseNumWithwhile(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int mod = number % 10;
                reverse *= 10;
                reverse += mod;

                number /= 10;
            }
            return reverse;
        }
    }
}
