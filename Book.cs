namespace AdvanceProgrammingCourse;

internal class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public long Price { get; set; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, string iSBN, long price, bool isAvailable)
    {
        Title = title;
        Author = author;
        ISBN = iSBN;
        Price = price;
        IsAvailable = isAvailable;
    }
}
