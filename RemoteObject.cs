using System;

namespace remoteclass
{
    public class xx:MarshalByRefObject
    {
        public int sum(int a, int b)
        {
            Console.WriteLine("SUM CALL");
            Console.WriteLine(a);
            Console.WriteLine(b);
            return a + b;

        }

    }

}

