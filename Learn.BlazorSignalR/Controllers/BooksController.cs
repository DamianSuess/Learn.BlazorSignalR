﻿using System.Collections.Generic;
using System.Threading.Tasks;
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
      // Generate 3 fake books
      await Task.Yield();
      IEnumerable<Book> books = new List<Book> { new Book(), new Book(), new Book() };
      return books;
    }

    // POST api/<BooksController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<BooksController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<BooksController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
