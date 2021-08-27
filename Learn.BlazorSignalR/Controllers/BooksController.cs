using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Learn.BlazorSignalR.Common;
using Learn.BlazorSignalR.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Learn.BlazorSignalR.Controllers
{
  /// <summary>
  /// Sample: https://www.c-sharpcorner.com/article/easily-create-a-real-time-application-with-blazor-and-signalr/
  /// </summary>
  [Route("api/[controller]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private readonly BookService _context;

    public BooksController(BookService context)
    {
      _context = context;
    }

    /// <summary>
    ///   GET" "api/<BooksController>/5"
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public async Task<Book> GetAsync(int id)
    {
      Debug.WriteLine($"GET single book: {id}");

      await Task.Yield();
      return new Book(id.ToString());
    }

    /// <summary>
    ///   GET: api/books
    ///   GET: api/<BooksController>
    /// </summary>
    /// <returns>Collection of books</returns>
    [HttpGet]
    public async Task<IEnumerable<Book>> GetAsync()
    {
      Debug.WriteLine($"GET (books)");
      // Generate 3 fake books
      await Task.Yield();
      IEnumerable<Book> books = new List<Book> { new Book(), new Book(), new Book() };

      // TODO: Send add "request to fake queue" so SignalR can send its own response as well

      return books;
    }

    // POST api/<BooksController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
      Debug.WriteLine($"POST: {value}");
    }

    // PUT api/<BooksController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
      Debug.WriteLine($"PUT: {value}");
    }

    // DELETE api/<BooksController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      Debug.WriteLine($"DELETE: {id}");
    }
  }
}
