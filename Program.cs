namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            bool exit = false;
            DisplayMenu();
            string choice = Console.ReadLine();
            while (!exit)
            {
                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        SearchBookByTitle();
                        break;
                    case "3":
                        DisplayAllBooks();
                        break;
                    case "4":
                        DeleteBook();
                        break;
                    case "5":
                        DisplayMostExpensiveBook();
                        break;
                    case "6":
                        DisplayCheapestBook();
                        break;
                    case "7":
                        DisplayBookCount();
                        break;
                    case "8":
                        SortAndDisplayByPrice();
                        break;
                    case "9":
                        DisplayBooksByPriceRange();
                        break;
                    case "10":
                        EditBookByISBN();
                        break;
                    case "11":
                        DisplayTotalPrice();
                        break;
                    case "12":
                        DisplayAveragePrice();
                        break;
                    case "13":
                        DisplayBooksByAuthor();
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }


            static void DisplayMenu()
            {
                Console.Clear();
                Console.WriteLine("===== Library Management System =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book by Title");
                Console.WriteLine("3. Display All Books");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Display Most Expensive Book");
                Console.WriteLine("6. Display Cheapest Book");
                Console.WriteLine("7. Display Book Count");
                Console.WriteLine("8. Sort Books by Price");
                Console.WriteLine("9. Display Books by Price Range");
                Console.WriteLine("10. Edit Book by ISBN");
                Console.WriteLine("11. Display Total Price");
                Console.WriteLine("12. Display Average Price");
                Console.WriteLine("13. Display Books by Author");
                Console.WriteLine("0. Exit");
                Console.WriteLine("======================================");
                Console.Write("Enter your choice: ");
            }

            static void AddBook()
            {
                Console.WriteLine("Write Books Title: ");
                string title = Console.ReadLine();

                Console.WriteLine("Write Books Author Name: ");
                string author = Console.ReadLine();

                Console.WriteLine("Write Books ISBN Code: ");
                string isbn = Console.ReadLine();

                Console.WriteLine("Write Books Price: ");
                string price = Console.ReadLine();

                Console.WriteLine("Set Books Availability \n");
                Console.WriteLine("1 be available | 0 be not available \n");
                ConsoleKeyInfo isAvailable = Console.ReadKey();

                if (isAvailable.Key == ConsoleKey.D0 || isAvailable.Key == ConsoleKey.D1)
                {
                    bool available = isAvailable.Key == ConsoleKey.D1;
                    Book book = new(title, author, isbn, long.Parse(price), available);
                    books.Add(book);
                }

                return;
            }

            static void SearchBookByTitle()
            {
                Console.WriteLine("Enter book title to search: ");
                string title = Console.ReadLine();

                List<Book> searchedBooks = books.Where(x => x.Title.Contains(title)).ToList();

                if (searchedBooks.Count == 0) Console.WriteLine("No Books Found");

                Console.WriteLine("Search Results: ");
                foreach (var book in searchedBooks)
                {
                    Console.WriteLine(book.Title);
                }

                DisplayMenu();
            }

            static void DisplayAllBooks()
            {
                if (books.Count == 0) Console.WriteLine("No Books Found");

                Console.WriteLine("Results: \n");
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title + "\n");
                }

                DisplayMenu();
            }

            static void DeleteBook()
            {

                DisplayAllBooks();

                Console.WriteLine("Enter the name of the book for deleting");
                string searchedBook = Console.ReadLine();

                Book book = books.Where(b => b.Title == searchedBook).FirstOrDefault();
                if (book is not null)
                {
                    books.Remove(book);
                }

                DisplayMenu();
            }

            static void DisplayMostExpensiveBook()
            {
                Book mostExpensiveBook = books.OrderByDescending(b => b.Price).FirstOrDefault();
                if (mostExpensiveBook is not null) Console.WriteLine($"The Most expensive book is ");
                else Console.WriteLine("No books found");

                DisplayMenu();
            }

            static void DisplayCheapestBook()
            {
                Book cheapestBook = books.OrderByDescending(b => b.Price).Reverse().FirstOrDefault();
                if (cheapestBook is not null) Console.WriteLine($"The Most expensive book is ");
                else Console.WriteLine("No books found");

                DisplayMenu();
            }

            static void DisplayBookCount()
            {
                Console.WriteLine($"The total count of books is: {books.Count}");
            }

            static void SortAndDisplayByPrice()
            {
                // TODO: Sort books by price and print them
            }

            static void DisplayBooksByPriceRange()
            {
                // TODO: Get two prices and print books between those prices
            }

            static void EditBookByISBN()
            {
                // TODO: Get ISBN and edit book information
            }

            static void DisplayTotalPrice()
            {
                // TODO: Calculate and print the total price of all books
            }

            static void DisplayAveragePrice()
            {
                // TODO: Calculate and print the average price of books
            }

            static void DisplayBooksByAuthor()
            {
                // TODO: Get author name and print all their books
            }


        }



    }
}
