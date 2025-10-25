namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Eneter the First Number \n");
            string first = Console.ReadLine();

            Console.WriteLine("Eneter the Second Number \n");
            string second = Console.ReadLine();

            Console.WriteLine("Eneter the Third Number \n");
            string third = Console.ReadLine();

            bool isNumber = int.TryParse(first, out int value) && int.TryParse(second, out int value2) && int.TryParse(third, out int value3);



            if (isNumber)
            {
                int firstNumber = int.Parse(first);
                int secondNumber = int.Parse(second);
                int thirdNumber = int.Parse(third);
                Console.WriteLine($"The Average of the inputs is : {(firstNumber + secondNumber + thirdNumber) / 3}");

            }

            Console.ReadLine();
        }

    }
}
