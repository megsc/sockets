using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace SocketClient
{
    // code for console based client
    

    //public class SynchronousSocketClient
    //{
    //    public static void StartClient()
    //    {
    //        byte[] bytes = new byte[1024];

    //        //connect to server
    //        try
    //        {
    //            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
    //            IPAddress ipAddress = ipHostInfo.AddressList[0];
    //            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

    //            //create a socket
    //            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    //            try
    //            {
    //                sender.Connect(remoteEP);

    //                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());

    //                Console.WriteLine("Enter text to server");

    //                string input = Console.ReadLine();

    //                byte[] msg = Encoding.ASCII.GetBytes(input);

    //                int bytesSent = sender.Send(msg);

    //                int bytesRec = sender.Receive(bytes);
    //                Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));

    //                Console.Read();

    //                sender.Shutdown(SocketShutdown.Both);
    //                sender.Close();

    //            }

    //            catch (ArgumentNullException ane)
    //            {
    //                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
    //            }

    //            catch (SocketException se)
    //            {
    //                Console.WriteLine("SocketException : {0}", se.ToString());
    //            }

    //            catch (Exception e)
    //            {
    //                Console.WriteLine("Unexpected exception : {0}", e.ToString());
    //            }

    //        }

    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.ToString());
    //        }
    //    }


    //    public static int Main(string[] args)
    //    {
    //        StartClient();
    //        return 0;
    //    }
    //}

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
