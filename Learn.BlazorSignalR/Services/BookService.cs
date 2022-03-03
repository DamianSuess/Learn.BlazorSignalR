using System;
using System.Collections.Generic;
using Learn.BlazorSignalR.Common;

namespace Learn.BlazorSignalR.Data
{
  public class BookService
  {
    private List<Book> _books;
    private Dictionary<Guid, Book> _bookDict;

    public BookService()
    {
      _books = new List<Book>
      {
        new Book("AAAAA"),
        new Book("BBBBB"),
        new Book("CCCCC"),
      };

      _bookDict = new Dictionary<Guid, Book>();
      var book1 = new Book("AAAA");
      var book2 = new Book("BBBB");
      var book3 = new Book("CCCC");
      _bookDict.Add(book1.Id, book1);
    }

    public List<Book> GetAll()
    {
      return _books;
    }

    public void Add(Book book)
    {
      _books.Add(book);
    }

    public void Remove(Book book)
    {
      
    }
  }
}
