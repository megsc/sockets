using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SocketClient;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{

    public partial class Form1 : Form
    {
        // Creating a Client Socket.
        Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        byte[] bytes = new byte[1024];

        IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
        IPAddress ipAddress;
        IPEndPoint remoteEP;


        public Form1()
        {
            InitializeComponent();
        
            // Connecting to server socket.
            ipAddress = ipHostInfo.AddressList[0];
            remoteEP = new IPEndPoint(ipAddress, 11000);

            clientSock.Connect(remoteEP);

            // Updating form once connected to server and adding messages to textbox1.
            label1.Text = "Client is connected to server";
            textBox1.Text = " >>> Socket connected to " + clientSock.RemoteEndPoint.ToString() + Environment.NewLine + " >>> Enter message to Server ";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Input from Textbox2 to string. 
            string input = textBox2.Text;

            // Adding message from client to server into textbox1 to display to the user.
            textBox1.Text = textBox1.Text + Environment.NewLine + " >>> Client sent: " + input;

            // Encoding the user input string to a byte array to send to the server. 
            byte[] msg = Encoding.ASCII.GetBytes(input);

            int bytesSent = clientSock.Send(msg);

            int bytesRec = clientSock.Receive(bytes);

            // Adding the return message from the server to textbox1.
            textBox1.Text = textBox1.Text + Environment.NewLine + " >>> Server sent: " + Encoding.ASCII.GetString(bytes, 0, bytesRec);

            // Closing sockets.
            clientSock.Shutdown(SocketShutdown.Both);
            clientSock.Close();

        }


        /// <summary>
        /// Making Label4 visible when Textbox2 is in focus. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_Enter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
    }
}
