namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Eneter the Centigerad Number \n");
            string centigerad = Console.ReadLine();


            bool isNumber = double.TryParse(centigerad, out double value);



            if (isNumber)
            {
                double centigeradNumber = double.Parse(centigerad);

                Console.WriteLine($"The Average of the inputs is : {(centigeradNumber * 1.8) + 32}");

            }

            Console.ReadLine();
        }

    }
}
