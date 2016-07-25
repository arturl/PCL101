using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCL101
{
    internal class CommonUtils
    {
        // This function is completely cross-platform and works on any project the includes Shared.Common
        public static int SillyAdditionImplementation(int x, int y)
        {
            int result = 0;

            for (int i = 0; i < x; ++i)
            {
                result++;
            }

            for (int i = 0; i < y; ++i)
            {
                result++;
            }
            return result;
        }

        public static void UseSockets()
        {
            // Socket s = new Socket(AddressFamily.InterNetworkV6, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}