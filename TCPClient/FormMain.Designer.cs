
namespace TCPClient
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
            this.lbServerIP = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.lbServerPort = new System.Windows.Forms.Label();
            this.tbTimeout = new System.Windows.Forms.TextBox();
            this.lbTimeout = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lbConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btClose = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.btSendHack = new System.Windows.Forms.Button();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServerIP
            // 
            this.lbServerIP.AutoSize = true;
            this.lbServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbServerIP.Location = new System.Drawing.Point(12, 9);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(22, 16);
            this.lbServerIP.TabIndex = 0;
            this.lbServerIP.Text = "IP";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerIP.Location = new System.Drawing.Point(12, 28);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(150, 22);
            this.tbServerIP.TabIndex = 1;
            this.tbServerIP.Text = "127.0.0.1";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbServerPort.Location = new System.Drawing.Point(168, 28);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(100, 22);
            this.tbServerPort.TabIndex = 3;
            this.tbServerPort.Text = "1234";
            // 
            // lbServerPort
            // 
            this.lbServerPort.AutoSize = true;
            this.lbServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbServerPort.Location = new System.Drawing.Point(168, 9);
            this.lbServerPort.Name = "lbServerPort";
            this.lbServerPort.Size = new System.Drawing.Size(36, 16);
            this.lbServerPort.TabIndex = 2;
            this.lbServerPort.Text = "Port";
            // 
            // tbTimeout
            // 
            this.tbTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTimeout.Location = new System.Drawing.Point(274, 28);
            this.tbTimeout.Name = "tbTimeout";
            this.tbTimeout.Size = new System.Drawing.Size(100, 22);
            this.tbTimeout.TabIndex = 5;
            this.tbTimeout.Text = "1000";
            // 
            // lbTimeout
            // 
            this.lbTimeout.AutoSize = true;
            this.lbTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimeout.Location = new System.Drawing.Point(271, 9);
            this.lbTimeout.Name = "lbTimeout";
            this.lbTimeout.Size = new System.Drawing.Size(64, 16);
            this.lbTimeout.TabIndex = 4;
            this.lbTimeout.Text = "Timeout";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(12, 56);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(150, 23);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "CONNECT";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(168, 56);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(100, 23);
            this.btDisconnect.TabIndex = 7;
            this.btDisconnect.Text = "DISCONNECT";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbConnectionStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 239);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(384, 22);
            this.ssMain.TabIndex = 8;
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
            this.btClose.Location = new System.Drawing.Point(272, 203);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 23);
            this.btClose.TabIndex = 9;
            this.btClose.Text = "CLOSE";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.Location = new System.Drawing.Point(12, 119);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(360, 22);
            this.tbMessage.TabIndex = 11;
            this.tbMessage.Text = "R;-0.5;0;0;0;0;0";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMessage.Location = new System.Drawing.Point(12, 100);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(72, 16);
            this.lbMessage.TabIndex = 10;
            this.lbMessage.Text = "Message";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(12, 147);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(150, 23);
            this.btSend.TabIndex = 12;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAnswer.Location = new System.Drawing.Point(168, 148);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(204, 22);
            this.tbAnswer.TabIndex = 14;
            // 
            // btSendHack
            // 
            this.btSendHack.Location = new System.Drawing.Point(12, 176);
            this.btSendHack.Name = "btSendHack";
            this.btSendHack.Size = new System.Drawing.Size(150, 23);
            this.btSendHack.TabIndex = 15;
            this.btSendHack.Text = "SEND";
            this.btSendHack.UseVisualStyleBackColor = true;
            this.btSendHack.Click += new System.EventHandler(this.btSendHack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btSendHack);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ssMain);
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
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label lbServerPort;
        private System.Windows.Forms.TextBox tbTimeout;
        private System.Windows.Forms.Label lbTimeout;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lbConnectionStatus;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button btSendHack;
    }
}

