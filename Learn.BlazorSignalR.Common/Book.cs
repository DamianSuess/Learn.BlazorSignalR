using System;

namespace Learn.BlazorSignalR.Common
{
  public class Book
  {
    public Book()
      : this(Guid.NewGuid().ToString())
    {
    }

    public Book(string name)
    {
      Id = Guid.NewGuid().ToString();
      Name = name;
    }

    public string Id { get; set; }

    public string Isbn { get; set; }

    public string Name { get; set; }

    public string Author { get; set; }

    public double Price { get; set; }
  }
}
