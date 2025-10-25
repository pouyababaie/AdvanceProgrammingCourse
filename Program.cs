namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            Console.WriteLine("Rectangle Area Calculator \n");

            Console.WriteLine("Eneter the X Axis ");
            string XAxis = Console.ReadLine();

            Console.WriteLine("Eneter the Y Axis ");
            string YAxis = Console.ReadLine();

            bool isNumber = int.TryParse(XAxis, out int value) && int.TryParse(YAxis, out int value2);


            int XAxisNumber = int.Parse(XAxis);

            int YAxisNumber = int.Parse(YAxis);

            if (isNumber)
            {
                Console.WriteLine($"The Area of the Rectangle is : {XAxisNumber * YAxisNumber}");
                Console.WriteLine($"The Perimeter of the Rectangle is : {2 * (XAxisNumber + YAxisNumber)}");

            }

            Console.ReadLine();
        }

    }
}
