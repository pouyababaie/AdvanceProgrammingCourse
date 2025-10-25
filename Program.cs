namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Enter a Value for X");
            string x = Console.ReadLine();
            Console.WriteLine("Enter a Value for Y");
            string y = Console.ReadLine();

            int number1 = int.Parse(x);
            int number2 = int.Parse(y);
            int result = (number1 << 0) + (number2 >> 0);
            Console.WriteLine($"Result: \n {result}");
        }

    }
}
