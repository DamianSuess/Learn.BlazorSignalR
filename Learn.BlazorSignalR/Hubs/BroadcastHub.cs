using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Learn.BlazorSignalR.Hubs
{
  public class BroadcastHub : Hub
  {
    public async Task SendMessageAsync()
    {
      await Clients.All.SendAsync("ReceiveMessage");
    }
  }
}
