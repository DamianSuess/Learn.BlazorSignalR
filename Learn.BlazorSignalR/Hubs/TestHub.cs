using System.Threading.Tasks;
using Learn.BlazorSignalR.Common;
using Microsoft.AspNetCore.SignalR;

namespace Learn.BlazorSignalR.Hubs
{
  public class TestHub : Hub
  {
    public override async Task OnConnectedAsync()
    {
      await Clients.Caller.SendAsync("Connected", Context.ConnectionId);
      // return base.OnConnectedAsync();
    }

    /// <summary>Simple posting out to all connected clients.</summary>
    /// <param name="message"></param>
    /// <returns></returns>
    public async Task SendMessageAsync(string message)
    {
      await Clients.All.SendAsync("Posted", $"Someone sent '{message}'");

      // Send this too...
      await SendObjectAsync("ghost-user", "where did this come from?");
    }

    public async Task SendObjectAsync(string user, string message)
    {
      var packet = new SignaledMessage
      {
        User = user,
        Message = message,
      };

      // Short version:
      // Requires ClientProxyExtension
      // await Clients.All.SendAsync(packet);
      //
      // Long version: Build object array & send it
      string method = typeof(SignaledMessage).Name;
      object[] objs = new object[] { packet };

      await Clients.All.SendCoreAsync(method, objs);
    }
  }
}
