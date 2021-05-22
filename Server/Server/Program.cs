using System;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Net.Sockets.TcpListener  tcpListener = new System.Net.Sockets.TcpListener(System.Net.IPAddress.Parse("127.0.0.1"), 8080);
            tcpListener.Server.NoDelay = true;
            tcpListener.Server.ReceiveBufferSize = 2500;
            tcpListener.Start();
            System.Net.Sockets.Socket socket = tcpListener.AcceptSocket();
            System.Net.Sockets.NetworkStream nt = new System.Net.Sockets.NetworkStream(socket);
            System.IO.StreamReader wr = new System.IO.StreamReader(nt);
            while (true)
            {
                Console.WriteLine($"your message: {wr.ReadLine()}");
            }
        }
    }
}
