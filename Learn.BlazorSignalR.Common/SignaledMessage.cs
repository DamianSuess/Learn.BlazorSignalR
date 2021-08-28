namespace Learn.BlazorSignalR.Common
{
  /// <remarks>
  ///   <PackageReference Include="SignalR.EasyUse.Interface" Version="0.2.1" />
  ///   https://github.com/Kibnet/SignalR.EasyUse/blob/master/src/SignalR.EasyUse.Server/ClientProxyExtensions.cs
  ///   Sample: https://github.com/Kibnet/SignalRChat/blob/master/SignalRChat.Interface/ReceiveMessage.cs
  /// </remarks>
  public class SignaledMessage // :IClientMethod
  {
    public string User { get; set; }

    public string Message { get; set; }
  }
}
