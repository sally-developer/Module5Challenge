using System;
using System.Collections.Generic;
using System.Linq;

//This represents a library
public class Library
{
    // Library name
    public string Name { get; set; }

    // Stores all books in the library
    private List<Book> Books { get; set; }

    // Constructor
    public Library(string name)
    {
        Name = name;
        Books = new List<Book>();
    }

    // Adds a book to the library
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }

    // Removes a book using its ISBN
    public bool RemoveBook(string isbn)
    {
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);

        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Removed: {bookToRemove}");
            return true;
        }

        Console.WriteLine("Book not found.");
        return false;
    }

    // Displays all available books
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("\nAvailable Books:");

        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    // Retrieves a book by ISBN
    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}
