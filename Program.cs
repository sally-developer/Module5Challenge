using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a library
        Library library = new Library("Central Library");

        // Create members
        Member member1 = new Member("Alice", 1);
        Member member2 = new Member("Bob", 2);

        // Add books to the library
        library.AddBook(new Book(
            "The Great Gatsby",
            "F. Scott Fitzgerald",
            "9780743273565"));

        library.AddBook(new Book(
            "To Kill a Mockingbird",
            "Harper Lee",
            "9780446310789"));

        library.AddBook(new Book(
            "1984",
            "George Orwell",
            "9780451524935"));

        // Display available books
        library.DisplayAvailableBooks();

        // Borrow books
        Console.WriteLine("\nBorrowing Books:");

        member1.BorrowBook(library, "9780743273565");
        member2.BorrowBook(library, "9780446310789");

        // Display remaining books
        library.DisplayAvailableBooks();

        // Display borrowed books
        member1.DisplayBorrowedBooks();
        member2.DisplayBorrowedBooks();

        // Return a book
        Console.WriteLine("\nReturning a Book:");

        member1.ReturnBook(library, "9780743273565");

        // Final library display
        library.DisplayAvailableBooks();
    }
}
