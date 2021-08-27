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

    private async void BtnConnect_ClickAsync(object sender, EventArgs e)
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

    private void btnDisconnect_Click(object sender, EventArgs e)
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

    private async void BtnGetBooks_ClickAsync(object sender, EventArgs e)
    {
      // REST - Get Books
      var client = new HttpClient();
      client.BaseAddress = new Uri(txtHostRest.Text);

      var json = await client.GetStringAsync("");

      ListAdd(json);
    }

    private void btnPost_Click(object sender, EventArgs e)
    {
      // Do something RESTful here
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
