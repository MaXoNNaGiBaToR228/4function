﻿using System;
using System.Collections.Generic;
using System.Linq;

class Library
{

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}


    private List<Book> books = new List<Book>();

    public void AddBook(string title, string author)
    {
        Book newBook = new Book { Title = title, Author = author };
        books.Add(newBook);
        Console.WriteLine("Книга успешно добавлена.");
    }




    public void RemoveBook(string title)
    {
        
        
        Book bookToRemove = books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Книга успешно удалена.");
        }
        else
        {
            Console.WriteLine("Книга не найдена.");
        }
    }
    
    public void SearchBook(string title)
    {
        Book foundBook = books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (foundBook != null)
        {
            Console.WriteLine($"Найдена книга: {foundBook.Title} - {foundBook.Author}");
        }
        else
        {
            Console.WriteLine("Книга не найденааа.");
        }
    }
}
