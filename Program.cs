using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

class ChatClient
{
    static async Task Main(string[] args)
    {
        string serverIp = "127.0.0.1"; // localhost
        int port = 5000;

        try
        {
            using TcpClient client = new TcpClient();
            await client.ConnectAsync(serverIp, port);
            Console.WriteLine("Connected to chat server!");

            NetworkStream stream = client.GetStream();

            
            _ = ReceiveMessagesAsync(stream);

            
            while (true)
            {
                string? msg = Console.ReadLine();
                if (string.IsNullOrEmpty(msg)) continue;

                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                await stream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    private static async Task ReceiveMessagesAsync(NetworkStream stream)
    {
        byte[] buffer = new byte[1024];
        try
        {
            while (true)
            {
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) break; 
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"[Server] {message}");
            }
        }
        catch { }
        finally
        {
            Console.WriteLine("Disconnected from server.");
        }
    }
}
