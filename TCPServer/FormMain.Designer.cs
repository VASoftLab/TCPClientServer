
namespace TCPServer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbTimeout = new System.Windows.Forms.TextBox();
            this.lbTimeout = new System.Windows.Forms.Label();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.lbServerPort = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.lbServerIP = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lbConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(168, 56);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(100, 23);
            this.btDisconnect.TabIndex = 15;
            this.btDisconnect.Text = "DISCONNECT";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(12, 56);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(150, 23);
            this.btConnect.TabIndex = 14;
            this.btConnect.Text = "CONNECT";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbTimeout
            // 
            this.tbTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeout.Location = new System.Drawing.Point(274, 28);
            this.tbTimeout.Name = "tbTimeout";
            this.tbTimeout.Size = new System.Drawing.Size(100, 22);
            this.tbTimeout.TabIndex = 13;
            this.tbTimeout.Text = "1000";
            // 
            // lbTimeout
            // 
            this.lbTimeout.AutoSize = true;
            this.lbTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeout.Location = new System.Drawing.Point(271, 9);
            this.lbTimeout.Name = "lbTimeout";
            this.lbTimeout.Size = new System.Drawing.Size(64, 16);
            this.lbTimeout.TabIndex = 12;
            this.lbTimeout.Text = "Timeout";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerPort.Location = new System.Drawing.Point(168, 28);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(100, 22);
            this.tbServerPort.TabIndex = 11;
            this.tbServerPort.Text = "1234";
            // 
            // lbServerPort
            // 
            this.lbServerPort.AutoSize = true;
            this.lbServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbServerPort.Location = new System.Drawing.Point(168, 9);
            this.lbServerPort.Name = "lbServerPort";
            this.lbServerPort.Size = new System.Drawing.Size(36, 16);
            this.lbServerPort.TabIndex = 10;
            this.lbServerPort.Text = "Port";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerIP.Location = new System.Drawing.Point(12, 28);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(150, 22);
            this.tbServerIP.TabIndex = 9;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // lbServerIP
            // 
            this.lbServerIP.AutoSize = true;
            this.lbServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbServerIP.Location = new System.Drawing.Point(12, 9);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(22, 16);
            this.lbServerIP.TabIndex = 8;
            this.lbServerIP.Text = "IP";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.Location = new System.Drawing.Point(12, 100);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(72, 16);
            this.lbMessage.TabIndex = 16;
            this.lbMessage.Text = "Message";
            // 
            // lbMessages
            // 
            this.lbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 16;
            this.lbMessages.Location = new System.Drawing.Point(15, 119);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(359, 388);
            this.lbMessages.TabIndex = 17;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbConnectionStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(384, 22);
            this.ssMain.TabIndex = 18;
            this.ssMain.Text = "statusStrip1";
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(192, 17);
            this.lbConnectionStatus.Text = "CONNECTION STATUS: UNKNOWN";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(274, 513);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 23);
            this.btClose.TabIndex = 19;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.tbTimeout);
            this.Controls.Add(this.lbTimeout);
            this.Controls.Add(this.tbServerPort);
            this.Controls.Add(this.lbServerPort);
            this.Controls.Add(this.tbServerIP);
            this.Controls.Add(this.lbServerIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCPServer";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbTimeout;
        private System.Windows.Forms.Label lbTimeout;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label lbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lbConnectionStatus;
        private System.Windows.Forms.Button btClose;
    }
}

