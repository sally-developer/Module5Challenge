using System;
using System.Collections.Generic;
using System.Linq;

//This class represents a library member
public class Member
{
    // Member information
    public string Name { get; set; }
    public int ID { get; set; }

    // Stores books borrowed by the member
    private List<Book> BorrowedBooks { get; set; }

    // Constructor
    public Member(string name, int id)
    {
        Name = name;
        ID = id;
        BorrowedBooks = new List<Book>();
    }

    // Allows a member to borrow a book
    public void BorrowBook(Library library, string isbn)
    {
        Book book = library.GetBook(isbn);

        if (book != null)
        {
            BorrowedBooks.Add(book);
            library.RemoveBook(isbn);

            Console.WriteLine($"{Name} borrowed: {book}");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }

    // Allows a member to return a book
    public void ReturnBook(Library library, string isbn)
    {
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

        if (book != null)
        {
            BorrowedBooks.Remove(book);
            library.AddBook(book);

            Console.WriteLine($"{Name} returned: {book}");
        }
        else
        {
            Console.WriteLine("Book not found in borrowed list.");
        }
    }

    // Displays all books borrowed by the member
    public void DisplayBorrowedBooks()
    {
        Console.WriteLine($"\n{Name}'s Borrowed Books:");

        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
    }
}

