namespace AdvanceProgrammingCourse;

public class Program
{

    private static List<int> List { get; set; } = new List<int>();
    private static bool Exit { get; set; } = false;
    static void Main(string[] args)
    {

        while (!Exit)
        {

            ShowMenu();

        }



    }

    public static void ShowMenu()
    {
        //Console.Clear();
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("          MIDTERM EXAM APPLICATION");
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.WriteLine("1)---------------->  Add a number to the list");
        Console.WriteLine("2)---------------->  Search for a number in the list");
        Console.WriteLine("3)---------------->  Show all numbers in the list");
        Console.WriteLine("4)---------------->  Remove a number from the list");
        Console.WriteLine("5)---------------->  Show the largest number");
        Console.WriteLine("6)---------------->  Show the smallest number");
        Console.WriteLine("7)---------------->  Show the count of numbers");
        Console.WriteLine("8)---------------->  Show sorted list");
        Console.WriteLine("9)---------------->  Show numbers between two values");
        Console.WriteLine("10)---------------->  Edit a number by index");
        Console.WriteLine("11)---------------->  Show sum of all numbers");
        Console.WriteLine("12)---------------->  Show average of all numbers");
        Console.WriteLine("0)---------------->  Exit");
        Console.WriteLine("═══════════════════════════════════════════════════");
        Console.Write("Please enter a number: ");



        string choice = Console.ReadLine();

        var isNumeric = int.TryParse(choice, out _);

        if (isNumeric)
        {
            Console.WriteLine($"Your Choice is {choice} \n ");

            switch (choice)
            {
                case "1":
                    AddNumberToList();
                    break;

                case "2":
                    SearchInList();
                    break;

                case "3":
                    ShowList();
                    break;

                case "4":
                    RemoveFromList();
                    break;

                case "5":
                    ShowLargestNumber();
                    break;

                case "6":
                    ShowSmallestNumber();
                    break;

                case "7":
                    ShowListCount();
                    break;

                case "8":
                    SortList();
                    break;

                case "9":
                    ShowItemsBetweenTwoElement();

                    break;
                case "10":
                    ReplaceValueByIndex();
                    break;
                case "11":
                    ShowSumOfListElements();
                    break;
                case "12":
                    ShowAverage();
                    break;

                case "0":

                    Exit = true;
                    Console.WriteLine("Exiting... Goodbye!");

                    break;
            }

        }
        else
        {
            Console.WriteLine($"Undefined Input {choice}");
            Exit = true;
        }
    }



    static void AddNumberToList()
    {
        Reset();

        Console.WriteLine($"Enter a value \n ");

        string input = Console.ReadLine();

        if (input is not null && !string.IsNullOrEmpty(input))
        {
            int inputInInt = Int32.Parse(input);
            List.Add(inputInInt);

            Console.Clear();

            Console.WriteLine($"The item {input} has been added to the list");


        }
        ShowMenu();

    }

    static void SearchInList()
    {

        Reset();

        Console.WriteLine($"Enter a value \n ");

        string searchTerm = Console.ReadLine();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            int inputInt = Int32.Parse(searchTerm);
            try
            {
                List.Find(x => x == inputInt);
                Console.WriteLine($"The Searched value is availble {inputInt} at index of {List.FindIndex(x => x == inputInt)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        ShowMenu();



    }

    static void ShowList()
    {
        Reset();

        Console.WriteLine("The List is :");

        List.ForEach(x =>
        {
            Console.WriteLine(x.ToString());
        });

        ShowMenu();

    }

    static void RemoveFromList()
    {
        Reset();


        Console.WriteLine($"Enter a value \n ");

        string searchTerm = Console.ReadLine();
        if (!string.IsNullOrEmpty(searchTerm))
        {
            int inputInt = int.Parse(searchTerm);

            bool isSuccess = List.Remove(inputInt);

            if (isSuccess) Console.WriteLine($"The item {inputInt} is successfully removed");
            else Console.WriteLine("The value is not in the range");

            ShowMenu();
        }
    }

    static void ShowLargestNumber()
    {
        Reset();

        Console.WriteLine($"The first option is using LINQ .MAX() method \n {List.Max()}");


        int largest = List[0];

        for (int i = 0; i < List.Count; i++)
        {
            if (List[i] > largest)
            {
                largest = List[i];
            }
        }

        Console.WriteLine($"The second option is using Manual itteration \n {largest}");

        ShowMenu();

    }

    static void ShowSmallestNumber()
    {
        Reset();

        Console.WriteLine($"The first option is using LINQ .MIN() method \n {List.Min()}");


        int largest = List[0];

        for (int i = 0; i < List.Count; i++)
        {
            if (List[i] < largest)
            {
                largest = List[i];
            }
        }

        Console.WriteLine($"The second option is using Manual itteration \n {largest}");

        ShowMenu();

    }

    static void ShowListCount()
    {
        Reset();

        Console.WriteLine($"The items in the list are this many : \n {List.Count}");

        ShowMenu();
    }

    static void SortList()
    {
        Reset();

        Console.WriteLine("Sorted list : \n");


        List.Sort();

        List.ForEach(x =>
        {
            Console.WriteLine(x);
        });

        ShowMenu();
    }

    static void ShowItemsBetweenTwoElement()
    {
        Reset();

        Console.WriteLine("Enter the first number (min value):");
        string searchTerm = Console.ReadLine();
        Console.WriteLine("Enter the second number (max value):");
        string searchTerm2 = Console.ReadLine();

        if (!string.IsNullOrEmpty(searchTerm) && !string.IsNullOrEmpty(searchTerm2))
        {
            int minValue = int.Parse(searchTerm);
            int maxValue = int.Parse(searchTerm2);

            if (minValue > maxValue)
            {
                minValue = minValue ^ maxValue;
                maxValue = minValue ^ maxValue;
                minValue = minValue ^ maxValue;
            }


            List<int> range = new List<int>();

            foreach (int number in List)
            {
                if (number >= minValue && number <= maxValue)
                {
                    range.Add(number);
                }
            }

            if (range.Count == 0)
            {
                Console.WriteLine($"No numbers found between {minValue} and {maxValue}");
            }
            else
            {
                Console.WriteLine($"\nNumbers between {minValue} and {maxValue}:");
                foreach (var item in range)
                {
                    Console.WriteLine(item);
                }
            }
        }


        ShowMenu();
    }

    static void ReplaceValueByIndex()
    {
        Reset();

        Console.WriteLine("Enter the number (index):");
        string searchTerm = Console.ReadLine();

        Console.WriteLine("Enter the replacing number (new value):");
        string searchTerm2 = Console.ReadLine();

        if (!string.IsNullOrEmpty(searchTerm) && !string.IsNullOrEmpty(searchTerm2))
        {
            int index = int.Parse(searchTerm);

            int value = int.Parse(searchTerm2);


            Console.WriteLine("List with initial value: \n");

            foreach (var item in List)
            {
                Console.WriteLine($"{item} \n");
            }


            List[index] = value;


            foreach (var item in List)
            {
                Console.WriteLine("List with new value : \n");

                Console.WriteLine(item);
            }

        }


        ShowMenu();

    }

    static void ShowSumOfListElements()
    {
        Reset();

        Console.WriteLine($"The sum by the LINQ method .SUM() is : \n  {List.Sum()}");

        int sum = 0;
        foreach (var item in List)
        {
            sum += item;
        }

        Console.WriteLine($"The sum by manual method is : \n  {sum}");


        ShowMenu();
    }

    static void ShowAverage()
    {
        Reset();

        int average = 0;
        int sum = 0;
        foreach (var item in List)
        {
            sum += item;
        }

        average = sum / List.Count;

        Console.WriteLine($"Average: {average}");


        ShowMenu();
    }


    static void Reset()
    {
        Console.Clear();
        if (List.Count == 0) { Console.WriteLine("The list is empty"); return; }


    }



}
