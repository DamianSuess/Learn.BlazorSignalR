using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace Learn.BlazorSignalR.Client
{
  public partial class MainForm : Form
  {
    private HubConnection _connection;
    private string _clientConnectionId;

    public MainForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txtHostSignalR.Text = "https://localhost:44321/testhub";
      txtHostRest.Text = "https://localhost:44321/api/books";
    }

    private async void BtnSignalrConnect_ClickAsync(object sender, EventArgs e)
    {
      // Build connection
      _connection = new HubConnectionBuilder()
        .WithUrl(txtHostSignalR.Text)
        .Build();

      _connection.Closed += async (error) =>
      {
        await Task.Yield();
        ListAdd("Connection Closed");
      };

      // Listen for SignalR Feedback
      _connection.On<string>("Connected", (connectionId) =>
      {
        ListAdd($"Connected - {connectionId}");
        SetConnectionId(connectionId);
      });

      _connection.On<string>("Posted", (value) =>
      {
        ListAdd($"[POST] - {value.ToString()}");
      });

      // Connect
      try
      {
        ListAdd("Connecting...");
        btnConnect.Enabled = false;
        await _connection.StartAsync();

        btnPost.Enabled = true;
      }
      catch (Exception ex)
      {
        ListAdd($"Connect Error - {ex.Message}");
        btnConnect.Enabled = true;
        btnPost.Enabled = false;
      }
    }

    private void BtnSignalrDisconnect_Click(object sender, EventArgs e)
    {
      try
      {
        _connection.StopAsync();
      }
      catch (Exception ex)
      {
        ListAdd($"Disconnect Error - {ex.Message}");
        btnConnect.Enabled = true;
        btnPost.Enabled = false;
      }
    }

    private async void BtnSignalrSend_ClickAsync(object sender, EventArgs e)
    {
      // Sends a message via SignalR and will be picked up by the Hub
      // SignalR will then send back a 'Posted' message back.
      // NOTE: The 'methodName' MUST match the Hub's method name to get picked up.
      try
      {
        var msg = string.IsNullOrEmpty(txtMessage.Text) ? "Default message from client" : txtMessage.Text;
        await _connection.InvokeAsync("SendMessageAsync", msg);
      }
      catch (Exception ex)
      {
        ListAdd($"SignalR Invoke Error - {ex.Message}");
      }
    }

    private async void BtnRestGetBooks_ClickAsync(object sender, EventArgs e)
    {
      // REST - Get Books
      var client = new HttpClient();
      client.BaseAddress = new Uri(txtHostRest.Text);

      var json = await client.GetStringAsync("");

      ListAdd(json);
    }

    private async void BtnRestPost_ClickAsync(object sender, EventArgs e)
    {
      ////// Do something RESTful here
      ////var client = new HttpClient();
      ////client.BaseAddress = new Uri(txtHostRest.Text);
      ////
      ////Book book = new Book("Quick Blazor Examples with SuessLabs");
      ////var json = System.Text.Json.JsonSerializer.Serialize(book);
      ////
      ////// POST - Add new item
      ////// PUT  - Update item
      ////var response = await client.PostAsync(
      ////  "",    //// $"api/item",
      ////  new StringContent(json, Encoding.UTF8, "application/json"));
      ////
      ////ListAdd("Sent RESTful POST of a Book.. wait for SignalR to confirm it was queued.");
    }

    private void ListAdd(string message)
    {
      lstMessages.Items.Add($"{DateTime.Now} - {message}");
      lstMessages.SelectedIndex = lstMessages.Items.Count - 1;
    }

    private void SetConnectionId(string connectionId)
    {
      _clientConnectionId = connectionId;
    }
  }
}
