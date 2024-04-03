using System;
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
            Console.WriteLine("Книга не найдена.");
        }
    }
    
     public void SortBooks()
    {
        books = books.OrderBy(book => book.Title).ToList();
        Console.WriteLine("Книги отсортированы по названию.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Удалить книгу");
            Console.WriteLine("3. Найти книгу по названию");
            Console.WriteLine("4. Отсортировать книги по названию");
            Console.WriteLine("5. Выйти");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Некорректный ввод.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Введите название книги: ");
                    string title = Console.ReadLine();
                    Console.Write("Введите автора книги: ");
                    string author = Console.ReadLine();
                    library.AddBook(title, author);
                    break;
                case 2:
                    Console.Write("Введите название книги для удаления: ");
                    string titleToRemove = Console.ReadLine();
                    library.RemoveBook(titleToRemove);
                    break;
                case 3:
                    Console.Write("Введите название книги для поиска: ");
                    string titleToSearch = Console.ReadLine();
                    library.SearchBook(titleToSearch);
                    break;
                case 4:
                    library.SortBooks();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        }
    }
}


