using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBookShelf.Domain.Entites.BookAggregate;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int NumberOfCopies { get; private set; }

    public Book(int id, string title, string author, int numberOfCopies)
    {
        Id = id;
        Title = title;
        Author = author;
        NumberOfCopies = numberOfCopies;
    }
}
