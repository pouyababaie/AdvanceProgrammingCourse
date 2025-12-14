namespace AdvanceProgrammingCourse
{
    public class Program
    {
        static List<Book> books = PopulateBookList();
        static bool exit = false;

        static List<Book> PopulateBookList()
        {
            List<Book> books = new List<Book>
    {
        new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565", 15000, true),
        new Book("To Kill a Mockingbird", "Harper Lee", "978-0061120084", 18000, true),
        new Book("1984", "George Orwell", "978-0451524935", 12000, false),
        new Book("Pride and Prejudice", "Jane Austen", "978-0141439518", 14000, true),
        new Book("The Catcher in the Rye", "J.D. Salinger", "978-0316769488", 16000, true),
        new Book("Animal Farm", "George Orwell", "978-0452284244", 11000, false),
        new Book("Brave New World", "Aldous Huxley", "978-0060850524", 13000, true),
        new Book("Lord of the Flies", "William Golding", "978-0399501487", 15500, true),
        new Book("The Hobbit", "J.R.R. Tolkien", "978-0547928227", 22000, false),
        new Book("Fahrenheit 451", "Ray Bradbury", "978-1451673319", 14500, true)
    };

            return books;
        }


        static void Main(string[] args)
        {
            DisplayMenu();

            static void ResetForm()
            {
                Console.ReadKey();
                DisplayMenu();
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
                            exit = true;
                            break;
                    }


                }
            }

            static void AddBook()
            {
                Console.Clear();

                Console.WriteLine("Write Books Title: \n");
                string title = Console.ReadLine();

                Console.WriteLine("Write Books Author Name: \n");
                string author = Console.ReadLine();

                Console.WriteLine("Write Books ISBN Code: \n");
                string isbn = Console.ReadLine();

                Console.WriteLine("Write Books Price: \n");
                string price = Console.ReadLine();

                Console.WriteLine("Set Books Availability \n");
                Console.WriteLine("1 be available | 0 be not available \n");
                ConsoleKeyInfo isAvailable = Console.ReadKey();

                if (isAvailable.Key == ConsoleKey.D0 || isAvailable.Key == ConsoleKey.D1)
                {
                    bool available = isAvailable.Key == ConsoleKey.D1;
                    Book book = new(title, author, isbn, long.Parse(price), available);
                    books.Add(book);

                    Console.WriteLine($"Book {book.Title} has been added");
                }
                ResetForm();
            }

            static void SearchBookByTitle()
            {
                Console.Clear();

                Console.WriteLine("Enter book title to search: ");
                string title = Console.ReadLine();

                List<Book> searchedBooks = books.Where(x => x.Title.Contains(title)).ToList();

                if (searchedBooks.Count == 0) Console.WriteLine("No Books Found");

                Console.WriteLine("Search Results: ");
                foreach (var book in searchedBooks)
                {
                    Console.WriteLine(book.Title);
                }

                ResetForm();
            }

            static void DisplayAllBooks()
            {
                Console.Clear();

                if (books.Count == 0) Console.WriteLine("No Books Found");

                Console.WriteLine("Results: \n");
                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Id}.{book.Title}" + "\n");
                }

                ResetForm();

            }

            static void DeleteBook()
            {
                Console.Clear();

                books.ForEach(b => Console.WriteLine(b.Title));

                Console.WriteLine("Enter the name of the book for deleting");
                string searchedBook = Console.ReadLine();

                Book book = books.Where(b => b.Title == searchedBook).FirstOrDefault();
                if (book is not null)
                {
                    books.Remove(book);
                }

                Console.WriteLine($"Book {book.Title} has been deleted");
                ResetForm();
            }

            static void DisplayMostExpensiveBook()
            {
                Console.Clear();

                Book mostExpensiveBook = books.OrderByDescending(b => b.Price).FirstOrDefault();
                if (mostExpensiveBook is not null) Console.WriteLine($"The Most expensive book is ");
                else Console.WriteLine("No books found");

                ResetForm();
            }

            static void DisplayCheapestBook()
            {
                Console.Clear();

                Book cheapestBook = books.OrderByDescending(b => b.Price).Reverse().FirstOrDefault();
                if (cheapestBook is not null) Console.WriteLine($"The Most expensive book is {cheapestBook.Title}");
                else Console.WriteLine("No books found");

                ResetForm();
            }

            static void DisplayBookCount()
            {
                Console.Clear();

                Console.WriteLine($"The total count of books is: {books.Count}");

                ResetForm();
            }

            static void SortAndDisplayByPrice()
            {
                Console.Clear();

                IEnumerable<Book> query = books.OrderBy(b => b.Price);

                foreach (var item in query)
                {
                    Console.WriteLine(item.Title);
                }

                ResetForm();
            }

            static void DisplayBooksByPriceRange()
            {
                Console.Clear();

                Console.WriteLine("Enter Minimum Price: \n");
                long minPrice = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Maximum Price: \n");

                long maxPrice = int.Parse(Console.ReadLine());

                books.Where(x => x.Price <= minPrice && x.Price >= maxPrice);

                ResetForm();
            }

            static void EditBookByISBN()
            {
                Console.Clear();

                Console.WriteLine("Enter the ISBN of the book to edit: \n");
                string isbn = Console.ReadLine();

                Book filteredBook = books.Where(b => b.ISBN == isbn).FirstOrDefault();

                if (filteredBook is not null)
                {
                    Console.WriteLine("Enter new title: \n");
                    string newTitle = Console.ReadLine();

                    Console.WriteLine("Enter new author: \n");
                    string newAuthor = Console.ReadLine();

                    Console.WriteLine("Enter new price: \n");
                    string newPrice = Console.ReadLine();

                    Console.WriteLine("Enter new Availability");
                    Console.WriteLine("1 be available | 0 be not available \n");

                    ConsoleKeyInfo isAvailable = Console.ReadKey();
                    if (isAvailable.Key == ConsoleKey.D0 || isAvailable.Key == ConsoleKey.D1)
                    {
                        bool available = isAvailable.Key == ConsoleKey.D1;
                        filteredBook.Title = newTitle;
                        filteredBook.Author = newAuthor;
                        filteredBook.Price = long.Parse(newPrice);
                        filteredBook.IsAvailable = available;
                    }

                    return;
                }

                ResetForm();
            }

            static void DisplayTotalPrice()
            {
                Console.Clear();

                long prices = books.Select(b => b.Price).Sum();
                Console.WriteLine($"Sum of the prices in books is : {prices}");
                ResetForm();
            }

            static void DisplayAveragePrice()
            {
                Console.Clear();

                long averagePrice = (long)books.Select(b => b.Price).Average();

                Console.WriteLine($"Average price of books is : {averagePrice}");
                
                ResetForm();
            }

            static void DisplayBooksByAuthor()
            {
                Console.Clear();

                Console.WriteLine("Enter Author Name: \n");
                string authorName = Console.ReadLine();

                books.Where(b => b.Author == authorName).ToList().ForEach(b => Console.WriteLine(b.Title));

                ResetForm();
            }


        }

    }
}
