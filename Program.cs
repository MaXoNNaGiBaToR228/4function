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