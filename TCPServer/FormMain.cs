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

        private void btConnect_Click(object sender, EventArgs e)
        {
            int.TryParse(tbServerPort.Text, out port);
            address = IPAddress.Parse(tbServerIP.Text);
            server = new TcpListener(address, port);

            server.Start();

            while (true)
            {
                try
                {
                    client = server.AcceptTcpClient();
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
                catch
                {
                    server.Stop();
                    break;
                }
            }
        }
    }
}
