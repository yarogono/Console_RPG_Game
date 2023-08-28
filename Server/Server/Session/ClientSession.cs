using ServerCore;
using System.Net;

namespace Server.Session
{
    public class ClientSession : PacketSession
    {
        public int SessionId { get; set; }

        public override void OnConnected(EndPoint endPoint)
        {
            throw new NotImplementedException();
        }

        public override void OnSend(int numOfBytes)
        {
            throw new NotImplementedException();
        }
    }
}
