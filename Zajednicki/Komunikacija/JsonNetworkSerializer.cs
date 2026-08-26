using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicki.Komunikacija
{
    public class JsonNetworkSerializer
    {
        private readonly Socket socket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonNetworkSerializer(Socket s)
        {
            socket = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };
        }

        public void Send(object message)
        {
            writer.WriteLine(JsonSerializer.Serialize(message));
        }
        public T Receive<T>()
        {
            string json = reader.ReadLine();
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
