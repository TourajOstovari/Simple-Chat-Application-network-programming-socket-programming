using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.Sockets.TcpClient tcpListener = new System.Net.Sockets.TcpClient(("127.0.0.1"), 8080);
            tcpListener.NoDelay = true;
            tcpListener.SendBufferSize = 2500;
            System.Net.Sockets.Socket socket = tcpListener.Client;
            System.Net.Sockets.NetworkStream nt = new System.Net.Sockets.NetworkStream(socket);
            System.IO.StreamWriter wr = new System.IO.StreamWriter(nt);
            string msg = " ";
            while (msg != "")
            {
                Console.WriteLine($"Type your message:");
                wr.WriteLine(Console.ReadLine());
                wr.Flush();
            }
        }
    }
}
