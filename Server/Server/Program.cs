using Server.Session;
using ServerCore;
using System.Net;

namespace Server
{
    class Program
    {
        private static Listener _listener = new Listener();

        static void Main(string[] args)
        {

            string host = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(host);
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

            _listener.Init(endPoint, () => { return SessionManager.Instance.Generate(); });

            Console.WriteLine("Listening...");

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}