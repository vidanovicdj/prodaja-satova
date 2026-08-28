using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.Exceptions
{
    [Serializable]
    internal class ServerCommunicationException : Exception
    {
        public ServerCommunicationException() { }
        public ServerCommunicationException(string? message) : base(message) { }
        public ServerCommunicationException(string? message, Exception? innerException) : base(message, innerException) { }
    }
}
