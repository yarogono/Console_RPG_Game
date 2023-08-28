using System.Net;
using System.Net.Sockets;

namespace ServerCore
{
    public abstract class Session
    {
        public abstract void OnConnected(EndPoint endPoint);
        public abstract void OnSend(int numOfBytes);

        public void Start(Socket acceptSocket)
        {
            throw new NotImplementedException();
        }
        
        public void Send(ArraySegment<byte> sendBuff)
        {

        }
    }
}
