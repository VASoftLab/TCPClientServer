using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TCPServer
{
    public partial class FormMain : Form
    {
        IPAddress address;
        int port;
        TcpListener server;
        TcpClient client;

        private bool flag = true;

        NetworkStream stream;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btConnect_Click(object sender, EventArgs e)
        {
            flag = true;
            
            lbConnectionStatus.Text = $"CONNECTION STATUS: ON";
            lbConnectionStatus.ForeColor = Color.Green;

            await ListenAsync();            
        }

        private async Task ListenAsync()
        {
            int.TryParse(tbServerPort.Text, out port);
            address = IPAddress.Parse(tbServerIP.Text);
            server = new TcpListener(address, port);

            server.Start();

            while (flag)
            {
                try
                {
                    client = await server.AcceptTcpClientAsync();
                    stream = client.GetStream();

                    try
                    {
                        if (stream.CanRead)
                        {
                            byte[] readerBuffer = new byte[1024];
                            StringBuilder messageBuffer = new StringBuilder();
                            int numberOfBytesRead = 0;
                            do
                            {
                                numberOfBytesRead = stream.Read(readerBuffer, 0, readerBuffer.Length);
                                messageBuffer.AppendFormat("{0}", Encoding.UTF8.GetString(readerBuffer, 0, numberOfBytesRead));
                            }
                            while (stream.DataAvailable);

                            lbMessages.Invoke(new Action(() =>
                            {
                                lbMessages.Items.Add(messageBuffer);
                            }));

                            Byte[] responseData = Encoding.UTF8.GetBytes("SUCCESS!");
                            stream.Write(responseData, 0, responseData.Length);
                        }
                    }
                    finally
                    {
                        stream.Close();
                        client.Close();
                    }
                }
                catch (Exception E)
                {
                    if (server.Server.Connected)
                        server.Stop();

                    break;
                }
            }

            if (!flag)
            {
                server.Stop();
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            flag = false;
            
            if (stream != null)
                stream.Close();
            
            if (client != null)
                client.Close();

            
            server.Stop();

            if (server.Server.Connected)
            {
                lbConnectionStatus.Text = $"CONNECTION STATUS: ON";
                lbConnectionStatus.ForeColor = Color.Green;                
            }
            else
            {
                lbConnectionStatus.Text = $"CONNECTION STATUS: OFF";
                lbConnectionStatus.ForeColor = Color.Red;
            }
        }
    }
}
