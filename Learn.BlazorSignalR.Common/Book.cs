using System;

namespace Learn.BlazorSignalR.Common
{
  public class Book
  {
    public Book()
      : this(default, "")
    {
    }

    public Book(string name)
      : this(Guid.NewGuid(), name)
    {
    }

    public Book(Guid id, string name)
    {
      Id = Guid.NewGuid();
      Name = name;
    }

    public Guid Id { get; set; }

    public string Isbn { get; set; }

    public string Name { get; set; }

    public string Author { get; set; }

    public double Price { get; set; }
  }
}
