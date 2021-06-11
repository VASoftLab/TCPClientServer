using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace TCPClient
{
    public partial class FormMain : Form
    {
        TcpClient client;
        Byte[] data;
        NetworkStream stream;

        string hostname;
        int port;
        string message;

        Byte[] readingData;
        String responseData;
        StringBuilder completeMessage;
        int numberOfBytesRead;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ClientInitialization()
        {
            readingData = new Byte[256];
            responseData = String.Empty;
            completeMessage = new StringBuilder();
            numberOfBytesRead = 0;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ClientInitialization();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Send a message
                message = tbMessage.Text;               
                
                data = Encoding.UTF8.GetBytes(message + "\r\n");
                await stream.WriteAsync(data, 0, data.Length);

                // SendMessage(client, message);

                // Get an answer
                responseData = String.Empty;
                completeMessage.Clear();
                numberOfBytesRead = 0;
                do
                {
                    numberOfBytesRead = stream.Read(readingData, 0, readingData.Length);
                    completeMessage.AppendFormat("{0}", Encoding.UTF8.GetString(readingData, 0, numberOfBytesRead));
                }
                while (stream.DataAvailable);

                responseData = completeMessage.ToString();

                tbAnswer.Invoke(new Action(() =>
                {
                    tbAnswer.Text = responseData;
                }));
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            try
            {                
                stream.Close();
                client.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                if ((client != null) && (client.Connected))
                    lbConnectionStatus.Text = $"CONNECTION STATUS: ON";
                else
                    lbConnectionStatus.Text = $"CONNECTION STATUS: OFF";
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                hostname = tbServerIP.Text;
                int.TryParse(tbServerPort.Text, out port);
                client = new TcpClient(hostname, port);
                client.NoDelay = true;
                stream = client.GetStream();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                if ((client != null) && (client.Connected))
                    lbConnectionStatus.Text = $"CONNECTION STATUS: ON";
                else
                    lbConnectionStatus.Text = $"CONNECTION STATUS: OFF";
            }
        }

        public void SendMessage(TcpClient client, string message)
        {
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(message);
            writer.Flush();
        }

        private async void btSendHack_Click(object sender, EventArgs e)
        {
            hostname = tbServerIP.Text;
            int.TryParse(tbServerPort.Text, out port);
            client = new TcpClient(hostname, port);
            client.NoDelay = true;
            stream = client.GetStream();

            try
            {
                // Send a message

                message = tbMessage.Text;
                // SendMessage(client, message);

                data = Encoding.UTF8.GetBytes(message + "\r\n");
                await stream.WriteAsync(data, 0, data.Length);

                // Get an answer
                responseData = String.Empty;
                completeMessage.Clear();
                numberOfBytesRead = 0;
                do
                {
                    numberOfBytesRead = stream.Read(readingData, 0, readingData.Length);
                    completeMessage.AppendFormat("{0}", Encoding.UTF8.GetString(readingData, 0, numberOfBytesRead));
                }
                while (stream.DataAvailable);

                responseData = completeMessage.ToString();

                tbAnswer.Invoke(new Action(() =>
                {
                    tbAnswer.Text = responseData;
                }));
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }



            stream.Close();
            client.Close();
        }
    }
}
