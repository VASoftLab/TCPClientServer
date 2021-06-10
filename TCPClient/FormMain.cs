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

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Send a message
                message = tbMessage.Text;
                data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
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
            // stream.Dispose();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                hostname = tbServerIP.Text;
                int.TryParse(tbServerPort.Text, out port); 
                client = new TcpClient(hostname, port);
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
    }
}
