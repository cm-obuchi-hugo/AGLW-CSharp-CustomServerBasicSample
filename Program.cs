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

            // It might be looping forever.
            // It's just a test for the build,
            // we will terminate the GameLift fleet manually ourself.
            // So nothing to worry here.
            while(server.IsAlive)
            {

            }
        }
    }
}
