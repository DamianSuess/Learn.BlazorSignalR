
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnGetBooks = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtHostRest = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(12, 12);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 0;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.BtnConnect_ClickAsync);
      // 
      // txtHostSignalR
      // 
      this.txtHostSignalR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtHostSignalR.Location = new System.Drawing.Point(152, 12);
      this.txtHostSignalR.Name = "txtHostSignalR";
      this.txtHostSignalR.Size = new System.Drawing.Size(436, 23);
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
      this.lstMessages.Location = new System.Drawing.Point(93, 69);
      this.lstMessages.Name = "lstMessages";
      this.lstMessages.Size = new System.Drawing.Size(495, 169);
      this.lstMessages.TabIndex = 2;
      // 
      // btnPost
      // 
      this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPost.Location = new System.Drawing.Point(12, 247);
      this.btnPost.Name = "btnPost";
      this.btnPost.Size = new System.Drawing.Size(75, 23);
      this.btnPost.TabIndex = 3;
      this.btnPost.Text = "Post";
      this.btnPost.UseVisualStyleBackColor = true;
      this.btnPost.Click += new System.EventHandler(this.BtnPost_ClickAsync);
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(12, 39);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
      this.btnDisconnect.TabIndex = 4;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(93, 248);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(414, 23);
      this.textBox1.TabIndex = 5;
      // 
      // btnGetBooks
      // 
      this.btnGetBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetBooks.Location = new System.Drawing.Point(12, 69);
      this.btnGetBooks.Name = "btnGetBooks";
      this.btnGetBooks.Size = new System.Drawing.Size(75, 53);
      this.btnGetBooks.TabIndex = 6;
      this.btnGetBooks.Text = "Get Books (REST)";
      this.btnGetBooks.UseVisualStyleBackColor = true;
      this.btnGetBooks.Click += new System.EventHandler(this.BtnGetBooks_ClickAsync);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(93, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 15);
      this.label1.TabIndex = 7;
      this.label1.Text = "SignalR:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(107, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 15);
      this.label2.TabIndex = 8;
      this.label2.Text = "REST:";
      // 
      // txtHostRest
      // 
      this.txtHostRest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtHostRest.Location = new System.Drawing.Point(152, 41);
      this.txtHostRest.Name = "txtHostRest";
      this.txtHostRest.Size = new System.Drawing.Size(436, 23);
      this.txtHostRest.TabIndex = 9;
      this.txtHostRest.Text = "https://localhost:44321/";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 283);
      this.Controls.Add(this.txtHostRest);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGetBooks);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnDisconnect);
      this.Controls.Add(this.btnPost);
      this.Controls.Add(this.lstMessages);
      this.Controls.Add(this.txtHostSignalR);
      this.Controls.Add(this.btnConnect);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TextBox txtHostSignalR;
    private System.Windows.Forms.ListBox lstMessages;
    private System.Windows.Forms.Button btnPost;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnGetBooks;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtHostRest;
  }
}

