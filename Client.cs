using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
namespace remoteclient
{
    public class rcl
    {
        public static void Main(string [ ] args)
        {
            remoteclass.xx robj = (remoteclass.xx) Activator.GetObject(typeof(remoteclass.xx), "http://mono_1:8080/sandrakumi");
            Console.WriteLine(robj.sum(10,10));

        }

    }

}
