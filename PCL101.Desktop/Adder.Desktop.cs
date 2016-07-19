using System.Threading;

namespace PCL101
{
    public sealed class Adder
    {
        private static int SpawnThreadAndAddTwoNumbers(int x, int y)
        {
            int z = 0;
            var ev = new ManualResetEvent(false);
            var t = new Thread(() =>
            {
                z = CommonUtils.SillyAdditionImplementation(x, y);
                ev.Set();
            });
            t.Start();
            ev.WaitOne();
            return z;
        }

        public static int add(int x, int y)
        {
            return SpawnThreadAndAddTwoNumbers(x, y);
        }
    }

}
