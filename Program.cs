namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            Console.WriteLine("Circle Area Calculator \n");

            Console.WriteLine("Eneter the Radius \n");
            string radius = Console.ReadLine();

            bool isNumber = int.TryParse(radius, out int value);


            int radiusNumber = int.Parse(radius);

            if (isNumber)
            {
                Console.WriteLine($"The Area of the Circle is : {Math.PI * (Math.Pow(radiusNumber,2))}");
                Console.WriteLine($"The Circunference is : {2 * (Math.PI) * radiusNumber}");

            }

            Console.ReadLine();
        }

    }
}
