using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketServer
{
    public class SynchronousSocketListener
    {
        public static string data = null;

        // Listen for a client connection.
        public static void StartListening()
        {
            byte[] bytes = new Byte[1024];

            // Connection details.
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a server socket.
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);
                

                while (true)
                {
                    Console.WriteLine("Waiting for connection....");

                    // Accept client connection.
                    Socket handler = listener.Accept();
                    Console.WriteLine("Connected to client. Awaiting message");
                    data = null;

                    // Receive message from client ensuring message ends with <EOF>.
                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);

                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }

                    Console.WriteLine("Text received : {0}", data);

                    //byte[] msg = Encoding.ASCII.GetBytes(data);

                    // Write message back to Client.
                    Console.WriteLine("\nEnter text to client:");
                    string input = Console.ReadLine();

                    byte[] msg = Encoding.ASCII.GetBytes(input);

                    // Send message back to client and shutdown server socket.
                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();

                }
            }

            // Exception handler for no client connection. 
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }



        public static int Main(string[] args)
        {
            StartListening();
            return 0;
        }


    }


}

    
      
