using System;

namespace Learn.BlazorSignalR.Data
{
  public class Book
  {
    public Book(string name)
    {
      Name = name;
    }

    public Book()
    {
      Name = Guid.NewGuid().ToString();
    }

    public string Name { get; set; }
  }
}
