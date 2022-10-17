using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
namespace remoteserver
{
    class rs
    {
        static void Main(string[] args)
        {
            ChannelServices.RegisterChannel(new HttpChannel(8080), false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(remoteclass.xx),"Sandra",WellKnownObjectMode.Singleton); // SingleCall
            Console.Write(" Server is Up & Running");
            Console.Read();

        }

    }

}
