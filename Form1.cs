using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_task2._1
{
    public partial class Form1 : Form
    {
        string name;
        private TcpClient client;
        private NetworkStream stream;
        private const int PORT = 12345;
        private const string IP = "127.0.0.1";
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient(IP, PORT);
            stream = client.GetStream();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SendMessages(name);
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {
            messagesTB.AppendText($"{name} змінив ім'я на {nameTB.Text}");
            name = nameTB.Text;
        }

        public void SendMessages(string name)
        {
            try
            {
                new Thread(ReceiveMessages).Start();
                while (true)
                {
                    string message = mSendBox.Text;
                    byte[] buffer = Encoding.UTF8.GetBytes($"{name}: {message}");
                    stream.Write(buffer, 0, buffer.Length);
                    messagesTB.AppendText($"Я: {message}");
                }

            }
            catch (Exception ex)
            {
                messagesTB.AppendText($"Помилка надсилання повідомлення: {ex.Message}");
            }

        }

        public void ReceiveMessages()
        {
            while (true)
            {
                Thread.Sleep(1000);
                try
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = 0;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        messagesTB.AppendText(message);
                    }
                }
                catch (Exception ex)
                {
                    messagesTB.AppendText($"Помилка надсилання повідомлення: {ex.Message}");
                    break;
                }
            }
        }
    }
}
