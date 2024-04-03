using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(string title, string author)
    {
        Book newBook = new Book { Title = title, Author = author };
        books.Add(newBook);
        Console.WriteLine("Книга успешно добавлена.");
    }

}
    
