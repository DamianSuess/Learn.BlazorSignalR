using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Learn.BlazorSignalR.Hubs
{
  public class TestHub : Hub
  {
    public override async Task OnConnectedAsync()
    {
      await Clients.Caller.SendAsync("Connect", Context.ConnectionId);
      // return base.OnConnectedAsync();
    }

    public async Task SendMessageAsync()
    {
      await Clients.All.SendAsync("ReceiveMessage");
    }
  }
}
