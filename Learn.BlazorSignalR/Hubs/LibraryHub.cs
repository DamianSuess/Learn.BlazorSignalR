using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Learn.BlazorSignalR.Hubs
{
  public class LibraryHub : Hub
  {
    public override async Task OnConnectedAsync()
    {
      await Clients.Caller.SendAsync("Connected", Context.ConnectionId);
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
      await Task.Yield();
      Console.WriteLine($"Disconnected. Exception:{Environment.NewLine}{exception}");
    }
  }
}
