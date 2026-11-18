// A class to represent  a book in the library
public class Book
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    // Constructor
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Returns a formatted string representation of the book
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}
