using System.Threading;

namespace PCL101
{
    public sealed class DesktopSupport
    {
        public static int SpawnThreadAndAddTwoNumbers(int x, int y)
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
    }

}
