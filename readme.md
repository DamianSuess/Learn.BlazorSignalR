# Learn SignalR using Blazor

This is a simple Blazor SignalR Client/Server application using Asp.Net Core 5 and WinForms.

There is no web front-end, this is intended as a pure headless web server with the Clients being actual applications.

## Reproduce this example

### Blazor Server

1. Create a new Blazor app
2. Remove all of the `razor` front-end crap
3. Remove `wwwroot`
4. Add Hubs folder with `TestHub.cs`  (_see code for example_)
5. Add Controllers folder with `BooksController.cs`  (_see code for example_)
6. Create `Services\BookService.cs` to be our mock DB lookup.
7. Wire-up SignalR
   * `Startup.cs`
      * Add `endpoints.MapHub<TestHub>("/testhub");`
      * Remove front end endpoints `endpoints.MapFallbackTo...`

### Client App
Follow the example code.

The client uses 2 keys connections (1) SignalR, (2) REST

| Item | File | URL |
|------|------|-----|
| SignalR Hub     | `Hubs\TestHub.cs`                 | `https://localhost:44321/testhub`
| REST Controller | `Controllers\BooksController.cs`  | `https://localhost:44321/api/books`


## References

* [https://github.com/dotnet/aspnetcore/tree/main/src/SignalR]
* [https://github.com/dotnet/AspNetCore.Docs/pull/21271]
* [Sample App](https://github.com/dotnet/AspNetCore.Docs/tree/main/aspnetcore/tutorials/signalr-blazor/samples/5.0/BlazorServerSignalRApp)
* [SignalR - Controller with Hubs](https://github.com/dotnet/AspNetCore.Docs/blob/main/aspnetcore/signalr/hubcontext/sample/Controllers/HomeController.cs)
* [GitHub - ASP.NET's SignalR Repositories](https://github.com/orgs/aspnet/repositories?q=SignalR&type=&language=&sort=)
* [Video - Blazor with SignalR](https://channel9.msdn.com/Shows/On-NET/Using-SignalR-in-your-Blazor-applications)
  * [Sample's Code](https://github.com/IEvangelist/signalr-chat)

.
