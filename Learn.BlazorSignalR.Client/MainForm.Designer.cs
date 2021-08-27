
namespace Learn.BlazorSignalR.Client
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnConnect = new System.Windows.Forms.Button();
      this.txtHostSignalR = new System.Windows.Forms.TextBox();
      this.lstMessages = new System.Windows.Forms.ListBox();
      this.btnPost = new System.Windows.Forms.Button();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.txtMessage = new System.Windows.Forms.TextBox();
      this.btnGetBooks = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtHostRest = new System.Windows.Forms.TextBox();
      this.btnSignalRSend = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(6, 22);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(92, 23);
      this.btnConnect.TabIndex = 0;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.BtnSignalrConnect_ClickAsync);
      // 
      // txtHostSignalR
      // 
      this.txtHostSignalR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtHostSignalR.Location = new System.Drawing.Point(178, 12);
      this.txtHostSignalR.Name = "txtHostSignalR";
      this.txtHostSignalR.Size = new System.Drawing.Size(410, 23);
      this.txtHostSignalR.TabIndex = 1;
      this.txtHostSignalR.Text = "https://localhost:44321/";
      // 
      // lstMessages
      // 
      this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstMessages.FormattingEnabled = true;
      this.lstMessages.ItemHeight = 15;
      this.lstMessages.Location = new System.Drawing.Point(126, 69);
      this.lstMessages.Name = "lstMessages";
      this.lstMessages.Size = new System.Drawing.Size(462, 169);
      this.lstMessages.TabIndex = 2;
      // 
      // btnPost
      // 
      this.btnPost.Location = new System.Drawing.Point(6, 51);
      this.btnPost.Name = "btnPost";
      this.btnPost.Size = new System.Drawing.Size(92, 23);
      this.btnPost.TabIndex = 3;
      this.btnPost.Text = "Post";
      this.btnPost.UseVisualStyleBackColor = true;
      this.btnPost.Click += new System.EventHandler(this.BtnRestPost_ClickAsync);
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(6, 51);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(92, 23);
      this.btnDisconnect.TabIndex = 4;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new System.EventHandler(this.BtnSignalrDisconnect_Click);
      // 
      // txtMessage
      // 
      this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMessage.Location = new System.Drawing.Point(126, 248);
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.Size = new System.Drawing.Size(462, 23);
      this.txtMessage.TabIndex = 5;
      // 
      // btnGetBooks
      // 
      this.btnGetBooks.Location = new System.Drawing.Point(6, 22);
      this.btnGetBooks.Name = "btnGetBooks";
      this.btnGetBooks.Size = new System.Drawing.Size(92, 23);
      this.btnGetBooks.TabIndex = 6;
      this.btnGetBooks.Text = "Get Books";
      this.btnGetBooks.UseVisualStyleBackColor = true;
      this.btnGetBooks.Click += new System.EventHandler(this.BtnRestGetBooks_ClickAsync);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(123, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 15);
      this.label1.TabIndex = 7;
      this.label1.Text = "SignalR:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(137, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 15);
      this.label2.TabIndex = 8;
      this.label2.Text = "REST:";
      // 
      // txtHostRest
      // 
      this.txtHostRest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtHostRest.Location = new System.Drawing.Point(178, 41);
      this.txtHostRest.Name = "txtHostRest";
      this.txtHostRest.Size = new System.Drawing.Size(410, 23);
      this.txtHostRest.TabIndex = 9;
      this.txtHostRest.Text = "https://localhost:44321/";
      // 
      // btnSignalRSend
      // 
      this.btnSignalRSend.Location = new System.Drawing.Point(6, 80);
      this.btnSignalRSend.Name = "btnSignalRSend";
      this.btnSignalRSend.Size = new System.Drawing.Size(92, 22);
      this.btnSignalRSend.TabIndex = 10;
      this.btnSignalRSend.Text = "Send Msg";
      this.btnSignalRSend.UseVisualStyleBackColor = true;
      this.btnSignalRSend.Click += new System.EventHandler(this.BtnSignalrSend_ClickAsync);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnConnect);
      this.groupBox1.Controls.Add(this.btnSignalRSend);
      this.groupBox1.Controls.Add(this.btnDisconnect);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(108, 116);
      this.groupBox1.TabIndex = 11;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "SignalR";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnGetBooks);
      this.groupBox2.Controls.Add(this.btnPost);
      this.groupBox2.Location = new System.Drawing.Point(12, 134);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(108, 87);
      this.groupBox2.TabIndex = 12;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "REST";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(19, 251);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(101, 15);
      this.label3.TabIndex = 13;
      this.label3.Text = "Custom Message:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 283);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.txtHostRest);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMessage);
      this.Controls.Add(this.lstMessages);
      this.Controls.Add(this.txtHostSignalR);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TextBox txtHostSignalR;
    private System.Windows.Forms.ListBox lstMessages;
    private System.Windows.Forms.Button btnPost;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.TextBox txtMessage;
    private System.Windows.Forms.Button btnGetBooks;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtHostRest;
    private System.Windows.Forms.Button btnSignalRSend;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
  }
}

