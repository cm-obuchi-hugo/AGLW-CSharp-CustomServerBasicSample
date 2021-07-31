using System;

namespace AGLW_CSharp_CustomServerBasicSample
{
    class Program
    {
        static private GameServer server = null;

        static void Main(string[] args)
        {
            server = new GameServer();
            server.Start();

            while(server.IsAlive)
            {

            }

            
        }
    }
}
