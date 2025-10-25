namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            while (!exit)
            {

                ShowMenu();
                string choice = Console.ReadLine();

                var isNumeric = int.TryParse(choice, out _);

                if (isNumeric)
                {
                    Console.WriteLine($"Your Choice is {choice} \n Entering Setting");

                    switch (choice)
                    {
                        case "1":
                            break;

                        case "2":
                            break;

                        case "3":
                            break;

                        case "4":
                            break;

                        case "5":
                            break;

                        case "6":
                            break;

                        case "7":
                            break;

                        case "8":
                            break;

                        case "9":
                            break;

                        case "0":

                            exit = true;
                            Console.WriteLine("Exiting... Goodbye!");

                            break;
                    }

                }
                else
                {
                    Console.WriteLine($"Undefined Input {choice}");
                    exit = true;
                }
            }

            static void ShowMenu()
            {
                Console.Clear();
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.WriteLine("          BOOK MANAGEMENT SYSTEM");
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.WriteLine("1)---------------->  Add New Book");
                Console.WriteLine("2)---------------->  Search the books by name and show details");
                Console.WriteLine("3)---------------->  Show all the books");
                Console.WriteLine("4)---------------->  Remove the book by ISBN");
                Console.WriteLine("5)---------------->  Show the most expensive book");
                Console.WriteLine("6)---------------->  Show the cheapest book");
                Console.WriteLine("7)---------------->  Show number of books");
                Console.WriteLine("8)---------------->  Show the books by price(Sort by price)");
                Console.WriteLine("9)---------------->  Show the books between two prices");
                Console.WriteLine("0)---------------->  Exit");
                Console.WriteLine("═══════════════════════════════════════════════════");
                Console.Write("Please enter a number: ");
            }

        }



    }
}
